using System;
using System.Collections.Generic;
using System.Linq;

using Framework.Core;
using Framework.DomainDriven;
using Framework.Persistent;
using Framework.SecuritySystem;
using Framework.Workflow.Domain;
using Framework.Workflow.Domain.Definition;
using Framework.Workflow.Domain.Runtime;



namespace Framework.Workflow.BLL
{
    public interface ITargetSystemService :

        ITypeResolverContainer<DomainType>,

        ITargetSystemElement<TargetSystem>,

        IAnonymousObjectBuilder<Framework.Workflow.Domain.Runtime.WorkflowInstance>,
        IAnonymousObjectBuilder<Framework.Workflow.Domain.Runtime.ExecutedCommand>
    {
        IAnonymousTypeBuilder<Framework.Workflow.Domain.Definition.Workflow> WorkflowTypeBuilder { get; }

        IAnonymousTypeBuilder<Framework.Workflow.Domain.Definition.Command> CommandTypeBuilder { get; }


        ICommandAccessService CommandAccessService { get; }



        object TargetSystemContext { get; }

        ITypeResolver<string> TypeResolverS { get; }

        Type TargetSystemContextType { get; }


        Type PersistentDomainObjectBaseType { get; }


        IList<WorkflowInstance> TryCreate(Array domainObjects);

        IList<WorkflowInstance> TryChange(Array domainObjects);

        IList<WorkflowInstance> TryRemove(Array domainObjects);




        IWorkflowMachine GetWorkflowMachine(WorkflowInstance workflowInstance);

        IMassWorkflowMachine GetMassWorkflowMachine(Domain.Definition.Workflow definition, WorkflowInstance[] workflowInstances);


        IEnumerable<ITryResult<object>> GetAnonymousObjects(Framework.Workflow.Domain.Definition.Workflow workflow, IEnumerable<WorkflowInstance> workflowInstances);



        StartWorkflowRequest GetStartWorkflowRequest(Framework.Workflow.Domain.Definition.Workflow workflow, object parameters);



        List<AvailableTaskInstanceWorkflowGroup> GetAvailableTaskInstanceWorkflowGroups(DomainType sourceType, Guid domainObjectId = default (Guid));



        bool ExistsObject(DomainType domainType, Guid domainObjectId);


        SecurityProvider<TaskInstance> GetTaskInstanceSecurityProvider(IGrouping<Role, Task> taskRoleGroup);


        DALChanges<WorkflowInstance> ProcessDALChanges(DALChanges changes);
    }

    public interface ITargetSystemService<out TBLLContext, in TPersistentDomainObjectBase> : ITargetSystemService
        where TPersistentDomainObjectBase : class
    {
        new TBLLContext TargetSystemContext { get; }


        IList<WorkflowInstance> TryCreate<TDomainObject>(IEnumerable<TDomainObject> domainObjects)
            where TDomainObject : class, TPersistentDomainObjectBase;

        IList<WorkflowInstance> TryChange<TDomainObject>(IEnumerable<TDomainObject> domainObjects)
            where TDomainObject : class, TPersistentDomainObjectBase;

        IList<WorkflowInstance> TryRemove<TDomainObject>(IEnumerable<TDomainObject> domainObjects)
            where TDomainObject : class, TPersistentDomainObjectBase;


        ISecurityProvider<TDomainObject> GetSecurityProvider<TDomainObject>(IRoleSource roleSource)
            where TDomainObject : class, TPersistentDomainObjectBase;

        ISecurityProvider<TDomainObject> GetSecurityProvider<TDomainObject>(Role role)
            where TDomainObject : class, TPersistentDomainObjectBase;
    }
}
