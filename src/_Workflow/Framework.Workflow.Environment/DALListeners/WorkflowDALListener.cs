using System;

using Framework.DomainDriven.BLL;
using Framework.Workflow.BLL;

using JetBrains.Annotations;

namespace Framework.Workflow.Environment
{
    public class WorkflowDALListener : IFlushedDALListener
    {
        private readonly ITargetSystemService targetSystemService;


        public WorkflowDALListener([NotNull] ITargetSystemService targetSystemService)
        {
            this.targetSystemService = targetSystemService ?? throw new ArgumentNullException(nameof(targetSystemService));
        }

        public void Process(DALChangesEventArgs eventArgs)
        {
            if (eventArgs == null) throw new ArgumentNullException(nameof(eventArgs));

            var result = this.targetSystemService.ProcessDALChanges(eventArgs.Changes);
        }
    }
}
