using System;
using System.Linq;

using Framework.Workflow.Domain.Definition;

namespace Framework.Workflow.BLL
{
    public partial interface IStartWorkflowDomainObjectConditionBLL
    {
        IQueryable<StartWorkflowDomainObjectCondition> GetAvailable(Type domainObjectType);

        IQueryable<StartWorkflowDomainObjectCondition> GetAvailable(DomainType domainType);
    }
}
