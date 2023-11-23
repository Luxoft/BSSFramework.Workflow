using Framework.Authorization.BLL;
using Framework.Authorization.Events;
using Framework.Authorization.Generated.DTO;
using Framework.Authorization.SecuritySystem;
using Framework.Configuration;
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
                       .RegisterListeners()
                       .RegisterContextEvaluator()
                       .RegisterSupportServices()

                       // Legacy

                       .RegisterLegacyGenericServices()
                       .RegisterContextEvaluators()
                       .RegisterMainBLLContext()

                       // Workflow

                       .RegisterLegacyWorkflow()
                       .RegisterWorkflowTargetSystems();
    }

    private static IServiceCollection RegisterMainBLLContext(this IServiceCollection services)
    {
        return services

               .AddSingleton<WorkflowSampleSystemValidationMap>()
               .AddSingleton<WorkflowSampleSystemValidatorCompileCache>()
               .AddScoped<IWorkflowSampleSystemValidator, WorkflowSampleSystemValidator>()

               .AddSingleton(new WorkflowSampleSystemMainFetchService().WithCompress().WithCache().WithLock().Add(FetchService<PersistentDomainObjectBase>.OData))
               .AddScoped<IWorkflowSampleSystemBLLFactoryContainer, WorkflowSampleSystemBLLFactoryContainer>()
               .AddScoped<IWorkflowSampleSystemBLLContextSettings>(_ => new WorkflowSampleSystemBLLContextSettings { TypeResolver = new[] { new WorkflowSampleSystemBLLContextSettings().TypeResolver, TypeSource.FromSample<BusinessUnitSimpleDTO>().ToDefaultTypeResolver() }.ToComposite() })
               .AddScopedFromLazyInterfaceImplement<IWorkflowSampleSystemBLLContext, WorkflowSampleSystemBLLContext>()

               .Self(WorkflowSampleSystemBLLFactoryContainer.RegisterBLLFactory);
    }

    private static IServiceCollection RegisterWorkflowTargetSystems(this IServiceCollection services)
    {
        services.AddSingleton<Framework.Workflow.BLL.TargetSystemServiceCompileCache<IWorkflowSampleSystemBLLContext, PersistentDomainObjectBase>>();
        services.AddSingleton<Framework.Workflow.BLL.TargetSystemServiceCompileCache<IWorkflowSampleSystemAuthorizationBLLContext, Framework.Authorization.Domain.PersistentDomainObjectBase>>();

        services.AddScoped<Framework.Workflow.BLL.TargetSystemServiceFactory>();
        services.AddScopedFrom((Framework.Workflow.BLL.TargetSystemServiceFactory factory) => factory.Create<IWorkflowSampleSystemAuthorizationBLLContext, Framework.Authorization.Domain.PersistentDomainObjectBase>(TargetSystemHelper.AuthorizationName, new[] { typeof(Framework.Authorization.Domain.Permission) }));
        services.AddScopedFrom((Framework.Workflow.BLL.TargetSystemServiceFactory factory) => factory.Create<IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Domain.PersistentDomainObjectBase>(tss => tss.IsMain, new[] { typeof(Location) }));

        return services;
    }

    private static IServiceCollection RegisterListeners(this IServiceCollection services)
    {
        services.AddSingleton<IInitializeManager, InitializeManager>();

        services.AddScoped<IBeforeTransactionCompletedDALListener, DenormalizeHierarchicalDALListener<PersistentDomainObjectBase, NamedLock, NamedLockOperation>>();
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
        services.AddScoped<IApiControllerBaseEvaluator<EvaluatedData<IWorkflowSampleSystemBLLContext, IWorkflowSampleSystemDTOMappingService>>, ApiControllerBaseSingleCallEvaluator<EvaluatedData<IWorkflowSampleSystemBLLContext, IWorkflowSampleSystemDTOMappingService>>>();

        return services;
    }

    private static IServiceCollection RegisterSupportServices(this IServiceCollection services)
    {
        // For notification
        services.AddSingleton<IDefaultMailSenderContainer>(new DefaultMailSenderContainer("WorkflowSampleSystem_Sender@luxoft.com"));
        services.AddScopedFrom<IBLLSimpleQueryBase<IEmployee>, IEmployeeBLLFactory>(factory => factory.Create());

        // For expand tree
        services.RegisterHierarchicalObjectExpander<PersistentDomainObjectBase>();

        // Serilog
        services.AddSingleton(Serilog.Log.Logger);

        return services;
    }
}
