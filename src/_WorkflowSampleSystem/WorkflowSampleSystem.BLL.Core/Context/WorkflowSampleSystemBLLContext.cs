﻿using System;

using Framework.Authorization.BLL;
using Framework.Core;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.BLL.Security;
using Framework.SecuritySystem.Rules.Builders;
using Framework.DomainDriven.BLL.Tracking;
using Framework.HierarchicalExpand;
using Framework.QueryLanguage;
using Framework.Security.Cryptography;
using Framework.SecuritySystem;
using Framework.Validation;
using Framework.Workflow.BLL;

using JetBrains.Annotations;

using WorkflowSampleSystem.Domain;

namespace WorkflowSampleSystem.BLL
{
    public partial class WorkflowSampleSystemBLLContext : ISecurityTypeResolverContainer
    {
        public WorkflowSampleSystemBLLContext(
            IServiceProvider serviceProvider,
            [NotNull] IDALFactory<PersistentDomainObjectBase, Guid> dalFactory,
            [NotNull] IOperationEventSenderContainer<PersistentDomainObjectBase> operationSenders,
            [NotNull] BLLSourceEventListenerContainer<PersistentDomainObjectBase> sourceListeners,
            [NotNull] IObjectStateService objectStateService,
            [NotNull] IAccessDeniedExceptionService<PersistentDomainObjectBase> accessDeniedExceptionService,
            [NotNull] IStandartExpressionBuilder standartExpressionBuilder,
            [NotNull] IValidator validator,
            [NotNull] IHierarchicalObjectExpanderFactory<Guid> hierarchicalObjectExpanderFactory,
            [NotNull] IFetchService<PersistentDomainObjectBase, FetchBuildRule> fetchService,
            [NotNull] IWorkflowSampleSystemSecurityService securityService,
            [NotNull] ISecurityExpressionBuilderFactory<PersistentDomainObjectBase, Guid> securityExpressionBuilderFactory,
            [NotNull] IWorkflowSampleSystemBLLFactoryContainer logics,
            [NotNull] IAuthorizationBLLContext authorization,
            [NotNull] Framework.Configuration.BLL.IConfigurationBLLContext configuration,
            [NotNull] IWorkflowBLLContext workflow,
            [NotNull] IWorkflowSampleSystemBLLContextSettings settings)
            : base(serviceProvider, dalFactory, operationSenders, sourceListeners, objectStateService, accessDeniedExceptionService, standartExpressionBuilder, validator, hierarchicalObjectExpanderFactory, fetchService)
        {
            this.SecurityExpressionBuilderFactory = securityExpressionBuilderFactory ?? throw new ArgumentNullException(nameof(securityExpressionBuilderFactory));

            this.SecurityService = securityService ?? throw new ArgumentNullException(nameof(securityService));
            this.Logics = logics ?? throw new ArgumentNullException(nameof(logics));

            this.Authorization = authorization ?? throw new ArgumentNullException(nameof(authorization));
            this.Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            this.Workflow = workflow ?? throw new ArgumentNullException(nameof(workflow));

            this.TypeResolver = settings.TypeResolver;
        }

        public IWorkflowSampleSystemSecurityService SecurityService { get; }

        public ISecurityExpressionBuilderFactory<PersistentDomainObjectBase, Guid> SecurityExpressionBuilderFactory { get; }

        public override IWorkflowSampleSystemBLLFactoryContainer Logics { get; }

        public IAuthorizationBLLContext Authorization { get; }

        public Framework.Configuration.BLL.IConfigurationBLLContext Configuration { get; }

        public IWorkflowBLLContext Workflow { get; }

        public ITypeResolver<string> TypeResolver { get; }

        ITypeResolver<string> ISecurityTypeResolverContainer.SecurityTypeResolver => this.TypeResolver;
    }
}
