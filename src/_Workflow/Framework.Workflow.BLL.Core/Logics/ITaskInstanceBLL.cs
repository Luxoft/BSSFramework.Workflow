using System.Collections.Generic;

using Framework.Workflow.Domain;



namespace Framework.Workflow.BLL
{
    public partial interface ITaskInstanceBLL : ITaskInstanceContract
    {
        List<AvailableTaskInstanceWorkflowGroup> GetAvailableGroups(AvailableTaskInstanceMainFilterModel filter);

        List<AvailableTaskInstanceWorkflowGroup> GetAvailableGroups(AvailableTaskInstanceUntypedMainFilterModel filter);
    }
}
