using System;

using Framework.SecuritySystem;
using Framework.SecuritySystem.Rules.Builders;
using Framework.Workflow.Domain.Runtime;

namespace Framework.Workflow.BLL
{
    public class WorkflowWorkflowInstanceSecurityService : ContextDomainSecurityService<WorkflowInstance, Guid>
    {
        public WorkflowWorkflowInstanceSecurityService(
                ISecurityProvider<WorkflowInstance> disabledSecurityProvider,
                ISecurityOperationResolver securityOperationResolver,
                ISecurityExpressionBuilderFactory securityExpressionBuilderFactory,
                SecurityPath<WorkflowInstance> securityPath,
                IWorkflowBLLContext context)
                : base(
                       disabledSecurityProvider,
                       securityOperationResolver,
                       securityExpressionBuilderFactory,
                       securityPath)
        {
            this.Context = context;
        }

        public IWorkflowBLLContext Context { get; }

        protected override ISecurityProvider<WorkflowInstance> CreateSecurityProvider(SecurityOperation securityOperation)
        {
            if (securityOperation == null) throw new ArgumentNullException(nameof(securityOperation));

            var baseProvider = base.CreateSecurityProvider(securityOperation);

            var watcherProvider = this.Context.GetWatcherSecurityProvider<WorkflowInstance>(workflowInstance => workflowInstance);

            if (securityOperation == WorkflowSecurityOperation.WorkflowView)
            {
                return baseProvider.Or(watcherProvider);
            }
            else
            {
                return baseProvider;
            }
        }
    }
}
