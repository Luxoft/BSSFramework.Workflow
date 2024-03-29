﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Framework.Workflow.BLL
{
    
    
    public partial class WorkflowBLLContext : Framework.DomainDriven.BLL.Security.SecurityBLLBaseContext<Framework.Workflow.Domain.PersistentDomainObjectBase, System.Guid, Framework.Workflow.BLL.IWorkflowBLLFactoryContainer>, Framework.DomainDriven.BLL.IBLLFactoryContainerContext<Framework.DomainDriven.BLL.IBLLFactoryContainer<Framework.DomainDriven.BLL.Security.IDefaultSecurityBLLFactory<Framework.Workflow.Domain.PersistentDomainObjectBase, System.Guid>>>, Framework.Workflow.BLL.IWorkflowBLLContext
    {
        
        Framework.DomainDriven.BLL.IBLLFactoryContainer<Framework.DomainDriven.BLL.IDefaultBLLFactory<Framework.Workflow.Domain.PersistentDomainObjectBase, System.Guid>> Framework.DomainDriven.BLL.IBLLFactoryContainerContext<Framework.DomainDriven.BLL.IBLLFactoryContainer<Framework.DomainDriven.BLL.IDefaultBLLFactory<Framework.Workflow.Domain.PersistentDomainObjectBase, System.Guid>>>.Logics
        {
            get
            {
                return this.Logics;
            }
        }
        
        Framework.DomainDriven.BLL.IBLLFactoryContainer<Framework.DomainDriven.BLL.Security.IDefaultSecurityBLLFactory<Framework.Workflow.Domain.PersistentDomainObjectBase, System.Guid>> Framework.DomainDriven.BLL.IBLLFactoryContainerContext<Framework.DomainDriven.BLL.IBLLFactoryContainer<Framework.DomainDriven.BLL.Security.IDefaultSecurityBLLFactory<Framework.Workflow.Domain.PersistentDomainObjectBase, System.Guid>>>.Logics
        {
            get
            {
                return this.Logics;
            }
        }
    }
    
    public partial interface IWorkflowBLLContext : Framework.DomainDriven.BLL.Security.IAccessDeniedExceptionServiceContainer, Framework.DomainDriven.BLL.Security.ISecurityServiceContainer<Framework.DomainDriven.BLL.Security.IRootSecurityService<Framework.Workflow.Domain.PersistentDomainObjectBase>>, Framework.DomainDriven.BLL.IBLLFactoryContainerContext<Framework.Workflow.BLL.IWorkflowBLLFactoryContainer>, Framework.DomainDriven.IFetchServiceContainer<Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.DomainDriven.FetchBuildRule>
    {
        
        new Framework.Workflow.BLL.IWorkflowBLLFactoryContainer Logics
        {
            get;
        }
    }
    
    public partial class SecurityDomainBLLBase<TDomainObject, TOperation> : Framework.DomainDriven.BLL.Security.DefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, TDomainObject, System.Guid, TOperation>
        where TDomainObject : Framework.Workflow.Domain.PersistentDomainObjectBase
        where TOperation :  struct, System.Enum
    {
        
        public SecurityDomainBLLBase(Framework.Workflow.BLL.IWorkflowBLLContext context, nuSpec.Abstraction.ISpecificationEvaluator specificationEvaluator = null) : 
                base(context, specificationEvaluator)
        {
        }
        
        public SecurityDomainBLLBase(Framework.Workflow.BLL.IWorkflowBLLContext context, Framework.SecuritySystem.ISecurityProvider<TDomainObject> securityProvider, nuSpec.Abstraction.ISpecificationEvaluator specificationEvaluator = null) : 
                base(context, securityProvider, specificationEvaluator)
        {
        }
    }
    
    public partial class SecurityDomainBLLBase<TDomainObject> : Framework.Workflow.BLL.SecurityDomainBLLBase<TDomainObject, Framework.DomainDriven.BLL.BLLBaseOperation>
        where TDomainObject : Framework.Workflow.Domain.PersistentDomainObjectBase
    {
        
        public SecurityDomainBLLBase(Framework.Workflow.BLL.IWorkflowBLLContext context) : 
                base(context)
        {
        }
        
        public SecurityDomainBLLBase(Framework.Workflow.BLL.IWorkflowBLLContext context, Framework.SecuritySystem.ISecurityProvider<TDomainObject> securityProvider) : 
                base(context, securityProvider)
        {
        }
    }
    
    public partial interface IWorkflowBLLFactoryContainer : Framework.DomainDriven.BLL.IBLLFactoryContainer<Framework.DomainDriven.BLL.Security.IDefaultSecurityBLLFactory<Framework.Workflow.Domain.PersistentDomainObjectBase, System.Guid>>
    {
        
        Framework.Workflow.BLL.ICommandBLL Command
        {
            get;
        }
        
        Framework.Workflow.BLL.ICommandEventBLL CommandEvent
        {
            get;
        }
        
        Framework.Workflow.BLL.ICommandEventBLLFactory CommandEventFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.ICommandBLLFactory CommandFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IConditionStateBLL ConditionState
        {
            get;
        }
        
        Framework.Workflow.BLL.IConditionStateEventBLL ConditionStateEvent
        {
            get;
        }
        
        Framework.Workflow.BLL.IConditionStateEventBLLFactory ConditionStateEventFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IConditionStateBLLFactory ConditionStateFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IDomainTypeBLL DomainType
        {
            get;
        }
        
        Framework.Workflow.BLL.IDomainTypeBLLFactory DomainTypeFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IEventBLL Event
        {
            get;
        }
        
        Framework.Workflow.BLL.IEventBLLFactory EventFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IExecutedCommandBLL ExecutedCommand
        {
            get;
        }
        
        Framework.Workflow.BLL.IExecutedCommandBLLFactory ExecutedCommandFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.INamedLockBLL NamedLock
        {
            get;
        }
        
        Framework.Workflow.BLL.INamedLockBLLFactory NamedLockFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IParallelStateBLL ParallelState
        {
            get;
        }
        
        Framework.Workflow.BLL.IParallelStateBLLFactory ParallelStateFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IParallelStateFinalEventBLL ParallelStateFinalEvent
        {
            get;
        }
        
        Framework.Workflow.BLL.IParallelStateFinalEventBLLFactory ParallelStateFinalEventFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IRoleBLL Role
        {
            get;
        }
        
        Framework.Workflow.BLL.IRoleBLLFactory RoleFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IStartWorkflowDomainObjectConditionBLL StartWorkflowDomainObjectCondition
        {
            get;
        }
        
        Framework.Workflow.BLL.IStartWorkflowDomainObjectConditionBLLFactory StartWorkflowDomainObjectConditionFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateBLL State
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateBaseBLL StateBase
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateBaseBLLFactory StateBaseFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateDomainObjectEventBLL StateDomainObjectEvent
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateDomainObjectEventBLLFactory StateDomainObjectEventFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateBLLFactory StateFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateInstanceBLL StateInstance
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateInstanceBLLFactory StateInstanceFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateTimeoutEventBLL StateTimeoutEvent
        {
            get;
        }
        
        Framework.Workflow.BLL.IStateTimeoutEventBLLFactory StateTimeoutEventFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.ITargetSystemBLL TargetSystem
        {
            get;
        }
        
        Framework.Workflow.BLL.ITargetSystemBLLFactory TargetSystemFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.ITaskBLL Task
        {
            get;
        }
        
        Framework.Workflow.BLL.ITaskBLLFactory TaskFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.ITaskInstanceBLL TaskInstance
        {
            get;
        }
        
        Framework.Workflow.BLL.ITaskInstanceBLLFactory TaskInstanceFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.ITransitionBLL Transition
        {
            get;
        }
        
        Framework.Workflow.BLL.ITransitionBLLFactory TransitionFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.ITransitionInstanceBLL TransitionInstance
        {
            get;
        }
        
        Framework.Workflow.BLL.ITransitionInstanceBLLFactory TransitionInstanceFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IWorkflowBLL Workflow
        {
            get;
        }
        
        Framework.Workflow.BLL.IWorkflowBLLFactory WorkflowFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IWorkflowInstanceBLL WorkflowInstance
        {
            get;
        }
        
        Framework.Workflow.BLL.IWorkflowInstanceBLLFactory WorkflowInstanceFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IWorkflowLambdaBLL WorkflowLambda
        {
            get;
        }
        
        Framework.Workflow.BLL.IWorkflowLambdaBLLFactory WorkflowLambdaFactory
        {
            get;
        }
        
        Framework.Workflow.BLL.IWorkflowSourceBLL WorkflowSource
        {
            get;
        }
        
        Framework.Workflow.BLL.IWorkflowSourceBLLFactory WorkflowSourceFactory
        {
            get;
        }
    }
    
    public partial interface ICommandBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.Command, System.Guid>
    {
        
        System.Collections.Generic.List<Framework.Workflow.Domain.Definition.Command> GetListBy(Framework.Workflow.Domain.AvailableCommandFilterModel filter, Framework.DomainDriven.IFetchContainer<Framework.Workflow.Domain.Definition.Command> fetchs);
    }
    
    public partial interface ICommandBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.ICommandBLL, Framework.Workflow.Domain.Definition.Command>
    {
    }
    
    public partial interface ICommandEventBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.CommandEvent, System.Guid>
    {
    }
    
    public partial interface ICommandEventBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.ICommandEventBLL, Framework.Workflow.Domain.Definition.CommandEvent>
    {
    }
    
    public partial interface IConditionStateBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.ConditionState, System.Guid>
    {
    }
    
    public partial interface IConditionStateBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IConditionStateBLL, Framework.Workflow.Domain.Definition.ConditionState>
    {
    }
    
    public partial interface IConditionStateEventBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.ConditionStateEvent, System.Guid>
    {
    }
    
    public partial interface IConditionStateEventBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IConditionStateEventBLL, Framework.Workflow.Domain.Definition.ConditionStateEvent>
    {
    }
    
    public partial interface IDomainTypeBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.DomainType, System.Guid>
    {
    }
    
    public partial interface IDomainTypeBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IDomainTypeBLL, Framework.Workflow.Domain.Definition.DomainType>
    {
    }
    
    public partial interface IEventBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.Event, System.Guid>
    {
        
        System.Collections.Generic.List<Framework.Workflow.Domain.Definition.Event> GetListBy(Framework.Workflow.Domain.EventRootFilterModel filter, Framework.DomainDriven.IFetchContainer<Framework.Workflow.Domain.Definition.Event> fetchs);
    }
    
    public partial interface IEventBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IEventBLL, Framework.Workflow.Domain.Definition.Event>
    {
    }
    
    public partial interface IParallelStateBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.ParallelState, System.Guid>
    {
    }
    
    public partial interface IParallelStateBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IParallelStateBLL, Framework.Workflow.Domain.Definition.ParallelState>
    {
    }
    
    public partial interface IParallelStateFinalEventBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.ParallelStateFinalEvent, System.Guid>
    {
    }
    
    public partial interface IParallelStateFinalEventBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IParallelStateFinalEventBLL, Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>
    {
    }
    
    public partial interface IRoleBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.Role, System.Guid>
    {
    }
    
    public partial interface IRoleBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IRoleBLL, Framework.Workflow.Domain.Definition.Role>
    {
    }
    
    public partial interface IStartWorkflowDomainObjectConditionBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.StartWorkflowDomainObjectCondition, System.Guid>
    {
    }
    
    public partial interface IStartWorkflowDomainObjectConditionBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IStartWorkflowDomainObjectConditionBLL, Framework.Workflow.Domain.Definition.StartWorkflowDomainObjectCondition>
    {
    }
    
    public partial interface IStateBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.State, System.Guid>
    {
    }
    
    public partial interface IStateBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IStateBLL, Framework.Workflow.Domain.Definition.State>
    {
    }
    
    public partial interface IStateBaseBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.StateBase, System.Guid>
    {
    }
    
    public partial interface IStateBaseBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IStateBaseBLL, Framework.Workflow.Domain.Definition.StateBase>
    {
    }
    
    public partial interface IStateDomainObjectEventBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.StateDomainObjectEvent, System.Guid>
    {
    }
    
    public partial interface IStateDomainObjectEventBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IStateDomainObjectEventBLL, Framework.Workflow.Domain.Definition.StateDomainObjectEvent>
    {
    }
    
    public partial interface IStateTimeoutEventBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.StateTimeoutEvent, System.Guid>
    {
    }
    
    public partial interface IStateTimeoutEventBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IStateTimeoutEventBLL, Framework.Workflow.Domain.Definition.StateTimeoutEvent>
    {
    }
    
    public partial interface ITargetSystemBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.TargetSystem, System.Guid>
    {
    }
    
    public partial interface ITargetSystemBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.ITargetSystemBLL, Framework.Workflow.Domain.Definition.TargetSystem>
    {
    }
    
    public partial interface ITaskBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.Task, System.Guid>
    {
    }
    
    public partial interface ITaskBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.ITaskBLL, Framework.Workflow.Domain.Definition.Task>
    {
    }
    
    public partial interface ITransitionBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.Transition, System.Guid>
    {
    }
    
    public partial interface ITransitionBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.ITransitionBLL, Framework.Workflow.Domain.Definition.Transition>
    {
    }
    
    public partial interface IWorkflowBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.Workflow, System.Guid>
    {
        
        Framework.Workflow.Domain.Definition.Workflow Create(Framework.Workflow.Domain.WorkflowCreateModel createModel);
    }
    
    public partial interface IWorkflowBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IWorkflowBLL, Framework.Workflow.Domain.Definition.Workflow>
    {
    }
    
    public partial interface IWorkflowLambdaBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.WorkflowLambda, System.Guid>
    {
    }
    
    public partial interface IWorkflowLambdaBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IWorkflowLambdaBLL, Framework.Workflow.Domain.Definition.WorkflowLambda>
    {
    }
    
    public partial interface IWorkflowSourceBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Definition.WorkflowSource, System.Guid>
    {
    }
    
    public partial interface IWorkflowSourceBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IWorkflowSourceBLL, Framework.Workflow.Domain.Definition.WorkflowSource>
    {
    }
    
    public partial interface INamedLockBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.NamedLock, System.Guid>
    {
    }
    
    public partial interface INamedLockBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.INamedLockBLL, Framework.Workflow.Domain.NamedLock>
    {
    }
    
    public partial interface IExecutedCommandBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Runtime.ExecutedCommand, System.Guid>
    {
    }
    
    public partial interface IExecutedCommandBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IExecutedCommandBLL, Framework.Workflow.Domain.Runtime.ExecutedCommand>
    {
    }
    
    public partial interface IStateInstanceBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Runtime.StateInstance, System.Guid>
    {
    }
    
    public partial interface IStateInstanceBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IStateInstanceBLL, Framework.Workflow.Domain.Runtime.StateInstance>
    {
    }
    
    public partial interface ITaskInstanceBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Runtime.TaskInstance, System.Guid>
    {
        
        System.Collections.Generic.List<Framework.Workflow.Domain.Runtime.TaskInstance> GetListBy(Framework.Workflow.Domain.TaskInstanceRootFilterModel filter, Framework.DomainDriven.IFetchContainer<Framework.Workflow.Domain.Runtime.TaskInstance> fetchs);
    }
    
    public partial interface ITaskInstanceBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.ITaskInstanceBLL, Framework.Workflow.Domain.Runtime.TaskInstance>
    {
    }
    
    public partial interface ITransitionInstanceBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Runtime.TransitionInstance, System.Guid>
    {
    }
    
    public partial interface ITransitionInstanceBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.ITransitionInstanceBLL, Framework.Workflow.Domain.Runtime.TransitionInstance>
    {
    }
    
    public partial interface IWorkflowInstanceBLL : Framework.DomainDriven.BLL.Security.IDefaultSecurityDomainBLLBase<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.Runtime.WorkflowInstance, System.Guid>
    {
    }
    
    public partial interface IWorkflowInstanceBLLFactory : Framework.DomainDriven.BLL.Security.ISecurityBLLFactory<Framework.Workflow.BLL.IWorkflowInstanceBLL, Framework.Workflow.Domain.Runtime.WorkflowInstance>
    {
    }
}
