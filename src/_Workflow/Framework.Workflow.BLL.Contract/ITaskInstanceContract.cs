using Framework.Workflow.Domain.Runtime;

namespace Framework.Workflow.BLL
{
    public interface ITaskInstanceContract : IDomainObjectContract<TaskInstance>
    {
        //[BLLSecurityMode(BLLSecurityMode.Edit)]
        //[ContractMethod("RecalculateTaskInstanceAssignees")]
        //void RecalculateAssignees(RecalculateTaskInstancesAssigneesModel recalculateTaskInstancesModel);
    }
}
