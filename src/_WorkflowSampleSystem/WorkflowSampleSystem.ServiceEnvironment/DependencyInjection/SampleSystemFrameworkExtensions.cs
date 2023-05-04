using System;

using Framework.Authorization;
using Framework.Authorization.BLL;
using Framework.Authorization.Events;
using Framework.Authorization.Generated.DTO;
using Framework.Configuration.BLL;
using Framework.Configuration.BLL.Notification;
using Framework.Configuration.Generated.DTO;
using Framework.Core;
using Framework.DependencyInjection;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.DomainDriven.ServiceModel.Service;
using Framework.DomainDriven.WebApiNetCore;
using Framework.Events;
using Framework.Persistent;
using Framework.QueryableSource;
using Framework.SecuritySystem;
using Framework.SecuritySystem.Rules.Builders;
using Framework.Workflow.BLL;
using Framework.Workflow.Generated.DTO;
using Framework.Workflow.ServiceEnvironment;

using Microsoft.Extensions.DependencyInjection;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.Domain;
using WorkflowSampleSystem.Generated.DTO;

namespace WorkflowSampleSystem.ServiceEnvironment;

public static class WorkflowSampleSystemFrameworkExtensions
{
    public static IServiceCollection RegisterGeneralBssFramework(this IServiceCollection services)
    {
        return services.RegisterGenericServices()
                       .RegisterWebApiGenericServices()
                       .RegisterWorkflowBLL()
                       .RegisterWorkflowWebApiGenericServices()

                       .RegisterMainBLLContext()
                       .RegisterWorkflowTargetSystems()
                       .RegisterListeners()
                       .RegisterContextEvaluator()

                       .RegisterSupportServices();
    }

    private static IServiceCollection RegisterMainBLLContext(this IServiceCollection services)
    {
        return services

               .AddSingleton<WorkflowSampleSystemValidatorCompileCache>()

               .AddScoped<IWorkflowSampleSystemValidator, WorkflowSampleSystemValidator>()

               .AddSingleton(new WorkflowSampleSystemMainFetchService().WithCompress().WithCache().WithLock().Add(FetchService<PersistentDomainObjectBase>.OData))
               .AddScoped<IWorkflowSampleSystemSecurityService, WorkflowSampleSystemSecurityService>()
               .AddScoped<IWorkflowSampleSystemBLLFactoryContainer, WorkflowSampleSystemBLLFactoryContainer>()
               .AddScoped<IWorkflowSampleSystemBLLContextSettings>(_ => new WorkflowSampleSystemBLLContextSettings { TypeResolver = new[] { new WorkflowSampleSystemBLLContextSettings().TypeResolver, TypeSource.FromSample<BusinessUnitSimpleDTO>().ToDefaultTypeResolver() }.ToComposite() })
               .AddScopedFromLazyInterfaceImplement<IWorkflowSampleSystemBLLContext, WorkflowSampleSystemBLLContext>()

               .AddScopedFrom<ISecurityOperationResolver<PersistentDomainObjectBase, WorkflowSampleSystemSecurityOperationCode>, IWorkflowSampleSystemBLLContext>()
               .AddScopedFrom<IDisabledSecurityProviderContainer<PersistentDomainObjectBase>, IWorkflowSampleSystemSecurityService>()
               .AddScopedFrom<IWorkflowSampleSystemSecurityPathContainer, IWorkflowSampleSystemSecurityService>()
               .AddScoped<IQueryableSource<PersistentDomainObjectBase>, BLLQueryableSource<IWorkflowSampleSystemBLLContext, PersistentDomainObjectBase, DomainObjectBase, Guid>>()
               .AddScoped<ISecurityExpressionBuilderFactory<PersistentDomainObjectBase, Guid>, Framework.SecuritySystem.Rules.Builders.MaterializedPermissions.SecurityExpressionBuilderFactory<PersistentDomainObjectBase, Guid>>()
               .AddScoped<IAccessDeniedExceptionService<PersistentDomainObjectBase>, AccessDeniedExceptionService<PersistentDomainObjectBase, Guid>>()

               .Self(WorkflowSampleSystemSecurityServiceBase.Register)
               .Self(WorkflowSampleSystemBLLFactoryContainer.RegisterBLLFactory);
    }

    private static IServiceCollection RegisterWorkflowTargetSystems(this IServiceCollection services)
    {
        services.AddSingleton<Framework.Workflow.BLL.TargetSystemServiceCompileCache<IWorkflowSampleSystemBLLContext, PersistentDomainObjectBase>>();
        services.AddSingleton<Framework.Workflow.BLL.TargetSystemServiceCompileCache<IWorkflowSampleSystemAuthorizationBLLContext, Framework.Authorization.Domain.PersistentDomainObjectBase>>();

        services.AddScoped<Framework.Workflow.BLL.TargetSystemServiceFactory>();
        services.AddScopedFrom((Framework.Workflow.BLL.TargetSystemServiceFactory factory) => factory.Create<IWorkflowSampleSystemAuthorizationBLLContext, Framework.Authorization.Domain.PersistentDomainObjectBase, AuthorizationSecurityOperationCode>(TargetSystemHelper.AuthorizationName, new[] { typeof(Framework.Authorization.Domain.Permission) }));
        services.AddScopedFrom((Framework.Workflow.BLL.TargetSystemServiceFactory factory) => factory.Create<IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Domain.PersistentDomainObjectBase, WorkflowSampleSystemSecurityOperationCode>(tss => tss.IsMain, new[] { typeof(Location) }));

        return services;
    }
    private static IServiceCollection RegisterListeners(this IServiceCollection services)
    {
        services.AddSingleton<IInitializeManager, InitializeManager>();

        services.AddScoped<IBeforeTransactionCompletedDALListener, DenormalizeHierarchicalDALListener<IWorkflowSampleSystemBLLContext, PersistentDomainObjectBase, NamedLock, NamedLockOperation>>();
        services.AddScoped<IBeforeTransactionCompletedDALListener, FixDomainObjectEventRevisionNumberDALListener>();

        services.AddScoped<DefaultAuthDALListener>();

        services.AddScopedFrom<IBeforeTransactionCompletedDALListener, DefaultAuthDALListener>();
        services.AddScopedFrom<IManualEventDALListener<Framework.Authorization.Domain.PersistentDomainObjectBase>, DefaultAuthDALListener>();

        services.AddScoped<EvaluatedData<IAuthorizationBLLContext, IAuthorizationDTOMappingService>>();
        services.AddScoped<IAuthorizationDTOMappingService, AuthorizationServerPrimitiveDTOMappingService>();

        services.AddScoped<EvaluatedData<IConfigurationBLLContext, IConfigurationDTOMappingService>>();
        services.AddScoped<IConfigurationDTOMappingService, ConfigurationServerPrimitiveDTOMappingService>();

        services.AddScoped<EvaluatedData<IWorkflowBLLContext, IWorkflowDTOMappingService>>();
        services.AddScoped<IWorkflowDTOMappingService, WorkflowServerPrimitiveDTOMappingService>();

        services.AddScoped<EvaluatedData<IWorkflowSampleSystemBLLContext, IWorkflowSampleSystemDTOMappingService>>();
        services.AddScoped<IWorkflowSampleSystemDTOMappingService, WorkflowSampleSystemServerPrimitiveDTOMappingService>();

        services.AddScoped<IOperationEventSenderContainer<PersistentDomainObjectBase>, OperationEventSenderContainer<PersistentDomainObjectBase>>();

        services.AddScoped<IOperationEventListener<Framework.Authorization.Domain.PersistentDomainObjectBase>, AuthorizationEventsSubscriptionManager>();
        services.AddScoped<IMessageSender<IDomainOperationSerializeData<Framework.Authorization.Domain.PersistentDomainObjectBase>>, AuthorizationLocalDBEventMessageSender>();

        return services;
    }

    private static IServiceCollection RegisterContextEvaluator(this IServiceCollection services)
    {
        services.AddSingleton<IContextEvaluator<IWorkflowSampleSystemBLLContext>, ContextEvaluator<IWorkflowSampleSystemBLLContext>>();
        services.AddScoped<IApiControllerBaseEvaluator<EvaluatedData<IWorkflowSampleSystemBLLContext, IWorkflowSampleSystemDTOMappingService>>, ApiControllerBaseSingleCallEvaluator<EvaluatedData<IWorkflowSampleSystemBLLContext, IWorkflowSampleSystemDTOMappingService>>>();

        return services;
    }

    private static IServiceCollection RegisterSupportServices(this IServiceCollection services)
    {
        // For auth
        services.AddScopedFrom<ISecurityTypeResolverContainer, IWorkflowSampleSystemBLLContext>();
        services.AddScoped<IAuthorizationExternalSource, AuthorizationExternalSource<IWorkflowSampleSystemBLLContext, PersistentDomainObjectBase, AuditPersistentDomainObjectBase, WorkflowSampleSystemSecurityOperationCode>>();

        // For notification
        services.AddSingleton<IDefaultMailSenderContainer>(new DefaultMailSenderContainer("WorkflowSampleSystem_Sender@luxoft.com"));
        services.AddScopedFrom<IBLLSimpleQueryBase<IEmployee>, IEmployeeBLLFactory>(factory => factory.Create());

        // For expand tree
        services.RegisterHierarchicalObjectExpander<PersistentDomainObjectBase>();

        // For repository
        services.AddScoped(_ => new LegacyPersistentDomainObjectBaseList(typeof(PersistentDomainObjectBase)));

        return services;
    }
}
