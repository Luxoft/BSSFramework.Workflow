using System;

using Framework.Authorization.BLL;
using Framework.Authorization.Domain;
using Framework.Core.Services;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.BLL.Configuration;
using Framework.DomainDriven.BLL.Security;
using Framework.DomainDriven.BLL.Tracking;
using Framework.HierarchicalExpand;
using Framework.QueryLanguage;
using Framework.SecuritySystem;
using Framework.SecuritySystem.Rules.Builders;

using JetBrains.Annotations;

namespace WorkflowSampleSystem.BLL;

public class WorkflowSampleSystemAuthorizationBLLContext : AuthorizationBLLContext, IWorkflowSampleSystemAuthorizationBLLContext
{
    public WorkflowSampleSystemAuthorizationBLLContext(
            [NotNull] IServiceProvider serviceProvider,
            [NotNull] IDALFactory<PersistentDomainObjectBase, Guid> dalFactory,
            [NotNull] IOperationEventSenderContainer<PersistentDomainObjectBase> operationSenders,
            [NotNull] IObjectStateService objectStateService,
            [NotNull] IAccessDeniedExceptionService<PersistentDomainObjectBase> accessDeniedExceptionService,
            [NotNull] IStandartExpressionBuilder standartExpressionBuilder,
            [NotNull] IAuthorizationValidator validator,
            [NotNull] IHierarchicalObjectExpanderFactory<Guid> hierarchicalObjectExpanderFactory,
            [NotNull] IFetchService<PersistentDomainObjectBase, FetchBuildRule> fetchService,
            [NotNull] IDateTimeService dateTimeService,
            [NotNull] IUserAuthenticationService userAuthenticationService,
            [NotNull] ISecurityExpressionBuilderFactory<PersistentDomainObjectBase, Guid> securityExpressionBuilderFactory,
            [NotNull] IConfigurationBLLContext configuration,
            [NotNull] IAuthorizationSecurityService securityService,
            [NotNull] IAuthorizationBLLFactoryContainer logics,
            [NotNull] IAuthorizationExternalSource externalSource,
            [NotNull] IRunAsManager runAsManager,
            [NotNull] ISecurityTypeResolverContainer securityTypeResolverContainer,
            [NotNull] IWorkflowApproveProcessor workflowApproveProcessor,
            [NotNull] IRuntimePermissionOptimizationService optimizeRuntimePermissionService,
            [NotNull] IAuthorizationBLLContextSettings settings)

            : base(
                   serviceProvider,
                   dalFactory,
                   operationSenders,
                   objectStateService,
                   accessDeniedExceptionService,
                   standartExpressionBuilder,
                   validator,
                   hierarchicalObjectExpanderFactory,
                   fetchService,
                   dateTimeService,
                   userAuthenticationService,
                   securityExpressionBuilderFactory,
                   configuration,
                   securityService,
                   logics,
                   externalSource,
                   runAsManager,
                   securityTypeResolverContainer,
                   optimizeRuntimePermissionService,
                   settings)
    {
        this.WorkflowApproveProcessor = workflowApproveProcessor ?? throw new ArgumentNullException(nameof(workflowApproveProcessor));
    }

    public IWorkflowApproveProcessor WorkflowApproveProcessor { get; }
}
