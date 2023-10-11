using System;

using Framework.DomainDriven.BLL;
using Framework.Workflow.Domain.Definition;



namespace Framework.Workflow.BLL
{
    public partial interface IDomainTypeBLL : IPathBLL<DomainType>
    {
        DomainType GetByType(Type domainObjectType);
    }
}
