using System;
using System.Linq;

using Framework.DomainDriven.BLL;
using Framework.Workflow.Domain.Definition;



namespace Framework.Workflow.BLL
{
    public partial interface IWorkflowBLL : IPathBLL<Framework.Workflow.Domain.Definition.Workflow>
    {
        IQueryable<Framework.Workflow.Domain.Definition.Workflow> GetForActiveLambdaAvailable(Type domainObjectType);

        IQueryable<Framework.Workflow.Domain.Definition.Workflow> GetForActiveLambdaAvailable(DomainType domainType);


        IQueryable<Framework.Workflow.Domain.Definition.Workflow> GetForAutoRemovingAvailable(Type domainObjectType);

        IQueryable<Framework.Workflow.Domain.Definition.Workflow> GetForAutoRemovingAvailable(DomainType domainType);
    }
}
