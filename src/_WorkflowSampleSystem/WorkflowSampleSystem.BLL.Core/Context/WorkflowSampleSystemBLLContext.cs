using System;

using Framework.Authorization.BLL;
using Framework.Core;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.BLL.Security;
using Framework.DomainDriven.Tracking;
using Framework.HierarchicalExpand;
using Framework.QueryLanguage;
using Framework.SecuritySystem;
using Framework.Workflow.BLL;

using WorkflowSampleSystem.Domain;

namespace WorkflowSampleSystem.BLL
{
    public partial class WorkflowSampleSystemBLLContext
    {
        public WorkflowSampleSystemBLLContext(
            IServiceProvider serviceProvider,
            IOperationEventSenderContainer<PersistentDomainObjectBase> operationSenders,
            ITrackingService<PersistentDomainObjectBase> trackingService,
            IAccessDeniedExceptionService accessDeniedExceptionService,
            IStandartExpressionBuilder standartExpressionBuilder,
            IWorkflowValidator validator,
            IHierarchicalObjectExpanderFactory<Guid> hierarchicalObjectExpanderFactory,
            IFetchService<PersistentDomainObjectBase, FetchBuildRule> fetchService,
            IRootSecurityService<PersistentDomainObjectBase> securityService,
            IWorkflowSampleSystemBLLFactoryContainer logics,
            IAuthorizationBLLContext authorization,
            Framework.Configuration.BLL.IConfigurationBLLContext configuration,
            IWorkflowBLLContext workflow,
            IWorkflowSampleSystemBLLContextSettings settings)
            : base(serviceProvider, operationSenders, trackingService, accessDeniedExceptionService, standartExpressionBuilder, validator, hierarchicalObjectExpanderFactory, fetchService)
        {
            this.SecurityService = securityService ?? throw new ArgumentNullException(nameof(securityService));
            this.Logics = logics ?? throw new ArgumentNullException(nameof(logics));

            this.Authorization = authorization ?? throw new ArgumentNullException(nameof(authorization));
            this.Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            this.Workflow = workflow ?? throw new ArgumentNullException(nameof(workflow));

            this.TypeResolver = settings.TypeResolver;
        }

        public IRootSecurityService<PersistentDomainObjectBase> SecurityService { get; }

        public override IWorkflowSampleSystemBLLFactoryContainer Logics { get; }

        public IAuthorizationBLLContext Authorization { get; }

        public Framework.Configuration.BLL.IConfigurationBLLContext Configuration { get; }

        public IWorkflowBLLContext Workflow { get; }

        public ITypeResolver<string> TypeResolver { get; }
    }
}
