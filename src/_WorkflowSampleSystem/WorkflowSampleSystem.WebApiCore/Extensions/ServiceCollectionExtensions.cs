using System;
using System.Collections.Generic;

using Framework.Authorization;
using Framework.Authorization.BLL;
using Framework.Authorization.Events;
using Framework.Authorization.Generated.DTO;
using Framework.Configuration.BLL;
using Framework.Configuration.BLL.Notification;
using Framework.Configuration.Generated.DTO;
using Framework.Core;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.NHibernate;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.DomainDriven.ServiceModel.Service;
using Framework.Events;
using Framework.Graphviz;
using Framework.Graphviz.Dot;
using Framework.HierarchicalExpand;
using Framework.QueryableSource;
using Framework.Security.Cryptography;
using Framework.SecuritySystem;
using Framework.SecuritySystem.Rules.Builders;
using Framework.Workflow.ServiceEnvironment;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.Domain;
using WorkflowSampleSystem.Generated.DTO;

using TargetSystemServiceFactory = Framework.Workflow.BLL.TargetSystemServiceFactory;

namespace WorkflowSampleSystem.WebApiCore;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterLegacyBLLContext(this IServiceCollection services)
    {
        services.AddSingleton(LazyInterfaceImplementHelper.CreateNotImplemented<IDotVisualizer<DotGraph>>());

        services.AddSingleton<Framework.Workflow.BLL.TargetSystemServiceCompileCache<IWorkflowSampleSystemBLLContext, PersistentDomainObjectBase>>();
        services.AddSingleton<Framework.Workflow.BLL.TargetSystemServiceCompileCache<IWorkflowSampleSystemAuthorizationBLLContext, Framework.Authorization.Domain.PersistentDomainObjectBase>>();

        services.AddScoped<TargetSystemServiceFactory>();
        services.AddScoped(sp => sp.GetRequiredService<TargetSystemServiceFactory>().Create<IWorkflowSampleSystemAuthorizationBLLContext, Framework.Authorization.Domain.PersistentDomainObjectBase, AuthorizationSecurityOperationCode>(TargetSystemHelper.AuthorizationName, new[] { typeof(Framework.Authorization.Domain.Permission) }));
        services.AddScoped(sp => sp.GetRequiredService<TargetSystemServiceFactory>().Create<IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Domain.PersistentDomainObjectBase, WorkflowSampleSystemSecurityOperationCode>(tss => tss.IsMain, new []{ typeof(Location)}));

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

        services.AddScoped<EvaluatedData<IWorkflowSampleSystemBLLContext, IWorkflowSampleSystemDTOMappingService>>();
        services.AddScoped<IWorkflowSampleSystemDTOMappingService, WorkflowSampleSystemServerPrimitiveDTOMappingService>();

        services.AddScoped<IOperationEventSenderContainer<PersistentDomainObjectBase>, OperationEventSenderContainer<PersistentDomainObjectBase>>();

        services.AddScoped<IOperationEventListener<Framework.Authorization.Domain.PersistentDomainObjectBase>, AuthorizationEventsSubscriptionManager>();
        services.AddScoped<IMessageSender<IDomainOperationSerializeData<Framework.Authorization.Domain.PersistentDomainObjectBase>>, AuthorizationLocalDBEventMessageSender>();

        services.AddSingleton(AvailableValuesHelper.AvailableValues.ToValidation());

        services.AddSingleton<IDefaultMailSenderContainer>(new DefaultMailSenderContainer("WorkflowSampleSystem_Sender@luxoft.com"));

        services.AddScoped<IBLLSimpleQueryBase<Framework.Persistent.IEmployee>>(sp => sp.GetRequiredService<IEmployeeBLLFactory>().Create());

        services.RegisterHierarchicalObjectExpander();

        services.RegisterAdditonalAuthorizationBLL();


        services.RegisterGenericServices();
        services.RegisterAuthorizationSystem();

        services.RegisterAuthorizationBLL();
        services.RegisterConfigurationBLL();
        services.RegisterWorkflowBLL();
        services.RegisterMainBLL();

        services.AddScopedFromLazyInterfaceImplement<IWorkflowSampleSystemAuthorizationBLLContext, WorkflowSampleSystemAuthorizationBLLContext>();

        services.AddScopedFrom<IAuthorizationBLLContext, IWorkflowSampleSystemAuthorizationBLLContext>();
        services.AddScopedFrom<AuthorizationBLLContext, WorkflowSampleSystemAuthorizationBLLContext>();

        return services;
    }

    public static IServiceCollection RegisterHierarchicalObjectExpander(this IServiceCollection services)
    {
        return services.AddSingleton<IHierarchicalRealTypeResolver, ProjectionHierarchicalRealTypeResolver>()
                       .AddScoped<IHierarchicalObjectExpanderFactory<Guid>, HierarchicalObjectExpanderFactory<PersistentDomainObjectBase, Guid>>();
    }

    public static IServiceCollection RegisterAdditonalAuthorizationBLL(this IServiceCollection services)
    {
        return services.AddScopedFrom<ISecurityTypeResolverContainer, IWorkflowSampleSystemBLLContext>()
                       .AddScoped<IAuthorizationExternalSource, AuthorizationExternalSource<IWorkflowSampleSystemBLLContext, PersistentDomainObjectBase, AuditPersistentDomainObjectBase, WorkflowSampleSystemSecurityOperationCode>>();
    }

    public static IServiceCollection RegisterMainBLL(this IServiceCollection services)
    {
        return services

                .AddScoped(sp => sp.GetRequiredService<IDBSession>().GetDALFactory<PersistentDomainObjectBase, Guid>())

                .AddScoped<BLLSourceEventListenerContainer<PersistentDomainObjectBase>>()

                .AddSingleton<WorkflowSampleSystemValidatorCompileCache>()

                .AddScoped<IWorkflowSampleSystemValidator>(sp =>
                     new WorkflowSampleSystemValidator(sp.GetRequiredService<IWorkflowSampleSystemBLLContext>(), sp.GetRequiredService<WorkflowSampleSystemValidatorCompileCache>()))

                .AddSingleton(new WorkflowSampleSystemMainFetchService().WithCompress().WithCache().WithLock().Add(FetchService<PersistentDomainObjectBase>.OData))
                .AddScoped<IWorkflowSampleSystemSecurityService, WorkflowSampleSystemSecurityService>()
                .AddScoped<IWorkflowSampleSystemBLLFactoryContainer, WorkflowSampleSystemBLLFactoryContainer>()
                .AddSingleton<ICryptService<CryptSystem>, CryptService<CryptSystem>>()
                .AddScoped<IWorkflowSampleSystemBLLContextSettings>(_ => new WorkflowSampleSystemBLLContextSettings { TypeResolver  = new[] { new WorkflowSampleSystemBLLContextSettings().TypeResolver, TypeSource.FromSample<BusinessUnitSimpleDTO>().ToDefaultTypeResolver() }.ToComposite() })
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

    public static IServiceCollection RegisterDependencyInjections(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddEnvironment(configuration);

        return services;
    }
}
