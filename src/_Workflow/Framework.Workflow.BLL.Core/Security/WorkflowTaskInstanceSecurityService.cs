using System;

using Framework.SecuritySystem;
using Framework.SecuritySystem.Rules.Builders;
using Framework.Workflow.Domain.Runtime;

namespace Framework.Workflow.BLL
{
    public class WorkflowTaskInstanceSecurityService : ContextDomainSecurityService<TaskInstance, Guid>
    {
        public WorkflowTaskInstanceSecurityService(
                ISecurityProvider<TaskInstance> disabledSecurityProvider,
                ISecurityOperationResolver securityOperationResolver,
                ISecurityExpressionBuilderFactory securityExpressionBuilderFactory,
                SecurityPath<TaskInstance> securityPath,
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


        protected override ISecurityProvider<TaskInstance> CreateSecurityProvider(SecurityOperation securityOperation)
        {
            if (securityOperation == null) throw new ArgumentNullException(nameof(securityOperation));

            var baseProvider = base.CreateSecurityProvider(securityOperation);

            if (securityOperation == WorkflowSecurityOperation.WorkflowView)
            {
                var watcherProvider = this.Context.GetWatcherSecurityProvider<TaskInstance>(taskInstance => taskInstance.Workflow);

                return baseProvider.Or(watcherProvider);
            }
            else
            {
                return baseProvider;
            }
        }
    }
}
