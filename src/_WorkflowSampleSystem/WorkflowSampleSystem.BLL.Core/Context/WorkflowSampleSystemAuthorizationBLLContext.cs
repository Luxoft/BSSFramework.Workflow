using System;

using Framework.Authorization.BLL;
using Framework.Authorization.Domain;
using Framework.Authorization.Environment;
using Framework.Authorization.Notification;
using Framework.Authorization.SecuritySystem;
using Framework.Authorization.SecuritySystem.ExternalSource;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.BLL.Configuration;
using Framework.DomainDriven.BLL.Security;
using Framework.DomainDriven.Tracking;
using Framework.HierarchicalExpand;
using Framework.QueryLanguage;
using Framework.SecuritySystem;

namespace WorkflowSampleSystem.BLL;

public class WorkflowSampleSystemAuthorizationBLLContext : AuthorizationBLLContext, IWorkflowSampleSystemAuthorizationBLLContext
{
    public WorkflowSampleSystemAuthorizationBLLContext(
            IServiceProvider serviceProvider,
            IOperationEventSenderContainer<PersistentDomainObjectBase> operationSenders,
            ITrackingService<PersistentDomainObjectBase> trackingService,
            IAccessDeniedExceptionService accessDeniedExceptionService,
            IStandartExpressionBuilder standartExpressionBuilder,
            IAuthorizationValidator validator,
            IHierarchicalObjectExpanderFactory<Guid> hierarchicalObjectExpanderFactory,
            IFetchService<PersistentDomainObjectBase, FetchBuildRule> fetchService,
            IDateTimeService dateTimeService,
            IConfigurationBLLContext configuration,
            IRootSecurityService<PersistentDomainObjectBase> securityService,
            IAuthorizationBLLFactoryContainer logics,
            IAuthorizationExternalSource externalSource,
            INotificationPrincipalExtractor notificationPrincipalExtractor,
            IAuthorizationBLLContextSettings settings,
            IAuthorizationSystem<Guid> authorizationSystem,
            IRunAsManager runAsManager,
            IAvailablePermissionSource availablePermissionSource,
            ISecurityOperationParser securityOperationParser,
            IAvailableSecurityOperationSource availableSecurityOperationSource,
            IActualPrincipalSource actualPrincipalSource,
            IWorkflowApproveProcessor workflowApproveProcessor)
            : base(
                   serviceProvider,
                   operationSenders,
                   trackingService,
                   accessDeniedExceptionService,
                   standartExpressionBuilder,
                   validator,
                   hierarchicalObjectExpanderFactory,
                   fetchService,
                   dateTimeService,
                   configuration,
                   securityService,
                   logics,
                   externalSource,
                   notificationPrincipalExtractor,
                   settings,
                   authorizationSystem,
                   runAsManager,
                   availablePermissionSource,
                   securityOperationParser,
                   availableSecurityOperationSource,
                   actualPrincipalSource)
    {
        this.WorkflowApproveProcessor = workflowApproveProcessor;
    }

    public ISecurityProvider<Operation> GetOperationSecurityProvider()
    {
        return new OperationSecurityProvider(this.AvailablePermissionSource);
    }

    public IWorkflowApproveProcessor WorkflowApproveProcessor
    {
        get;
    }
}
