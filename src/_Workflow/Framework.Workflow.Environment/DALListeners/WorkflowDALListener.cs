using System;

using Framework.DomainDriven;
using Framework.Workflow.BLL;



namespace Framework.Workflow.Environment
{
    public class WorkflowDALListener : IFlushedDALListener
    {
        private readonly ITargetSystemService targetSystemService;


        public WorkflowDALListener(ITargetSystemService targetSystemService)
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
