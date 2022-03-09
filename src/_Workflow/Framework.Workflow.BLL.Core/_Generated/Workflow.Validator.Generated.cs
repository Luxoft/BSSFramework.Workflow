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
    
    
    public partial class WorkflowValidatorBase : Framework.DomainDriven.BLL.BLLContextHandlerValidator<Framework.Workflow.BLL.IWorkflowBLLContext, Framework.Workflow.Domain.WorkflowOperationContext>
    {
        
        public WorkflowValidatorBase(Framework.Workflow.BLL.IWorkflowBLLContext context, Framework.Validation.ValidatorCompileCache cache) : 
                base(context, cache)
        {
            base.RegisterHandler<Framework.Workflow.Domain.AvailableCommandFilterModel>(this.GetAvailableCommandFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.AvailableTaskInstanceGroup>(this.GetAvailableTaskInstanceGroupValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.AvailableTaskInstanceGroupItem>(this.GetAvailableTaskInstanceGroupItemValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.AvailableTaskInstanceMainFilterModel>(this.GetAvailableTaskInstanceMainFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.AvailableTaskInstanceUntypedMainFilterModel>(this.GetAvailableTaskInstanceUntypedMainFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.AvailableTaskInstanceWorkflowGroup>(this.GetAvailableTaskInstanceWorkflowGroupValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.CommandEventRootFilterModel>(this.GetCommandEventRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.CommandRootFilterModel>(this.GetCommandRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.ConditionStateRootFilterModel>(this.GetConditionStateRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.Command>(this.GetCommandValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.CommandEvent>(this.GetCommandEventValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.CommandMetadata>(this.GetCommandMetadataValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.CommandParameter>(this.GetCommandParameterValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.CommandRoleAccess>(this.GetCommandRoleAccessValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.ConditionState>(this.GetConditionStateValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.ConditionStateEvent>(this.GetConditionStateEventValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.DomainType>(this.GetDomainTypeValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.Event>(this.GetEventValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.ParallelState>(this.GetParallelStateValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.ParallelStateFinalEvent>(this.GetParallelStateFinalEventValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.ParallelStateStartItem>(this.GetParallelStateStartItemValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.Role>(this.GetRoleValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.StartWorkflowDomainObjectCondition>(this.GetStartWorkflowDomainObjectConditionValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.State>(this.GetStateValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.StateBase>(this.GetStateBaseValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.StateDomainObjectEvent>(this.GetStateDomainObjectEventValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.StateTimeoutEvent>(this.GetStateTimeoutEventValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.TargetSystem>(this.GetTargetSystemValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.Task>(this.GetTaskValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.TaskMetadata>(this.GetTaskMetadataValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.Transition>(this.GetTransitionValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.TransitionAction>(this.GetTransitionActionValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.Workflow>(this.GetWorkflowValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.WorkflowLambda>(this.GetWorkflowLambdaValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.WorkflowMetadata>(this.GetWorkflowMetadataValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.WorkflowParameter>(this.GetWorkflowParameterValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Definition.WorkflowSource>(this.GetWorkflowSourceValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.DomainTypeRootFilterModel>(this.GetDomainTypeRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.EventRootFilterModel>(this.GetEventRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.ExecuteCommandRequest>(this.GetExecuteCommandRequestValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.ExecuteCommandRequestParameter>(this.GetExecuteCommandRequestParameterValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.GroupExecuteCommandRequest>(this.GetGroupExecuteCommandRequestValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.MassExecuteCommandRequest>(this.GetMassExecuteCommandRequestValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.NamedLock>(this.GetNamedLockValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.ParallelStateRootFilterModel>(this.GetParallelStateRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.RoleRootFilterModel>(this.GetRoleRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Runtime.ExecutedCommand>(this.GetExecutedCommandValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Runtime.ExecutedCommandParameter>(this.GetExecutedCommandParameterValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Runtime.StateInstance>(this.GetStateInstanceValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Runtime.TaskInstance>(this.GetTaskInstanceValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Runtime.TransitionInstance>(this.GetTransitionInstanceValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Runtime.WorkflowInstance>(this.GetWorkflowInstanceValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Runtime.WorkflowInstanceParameter>(this.GetWorkflowInstanceParameterValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.Runtime.WorkflowInstanceWatcher>(this.GetWorkflowInstanceWatcherValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.StartWorkflowDomainObjectConditionRootFilterModel>(this.GetStartWorkflowDomainObjectConditionRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.StartWorkflowRequest>(this.GetStartWorkflowRequestValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.StartWorkflowRequest.CustomStateStartWorkflowRequest>(this.GetCustomStateStartWorkflowRequestValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.StartWorkflowRequest.StartSubWorkflowRequest>(this.GetStartSubWorkflowRequestValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.StartWorkflowRequestParameter>(this.GetStartWorkflowRequestParameterValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.StateBaseRootFilterModel>(this.GetStateBaseRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.StateRootFilterModel>(this.GetStateRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.TaskInstanceRootFilterModel>(this.GetTaskInstanceRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.TaskRootFilterModel>(this.GetTaskRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.TransitionRootFilterModel>(this.GetTransitionRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.WorkflowCreateModel>(this.GetWorkflowCreateModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.WorkflowInstanceRootFilterModel>(this.GetWorkflowInstanceRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.WorkflowLambdaRootFilterModel>(this.GetWorkflowLambdaRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.WorkflowRootFilterModel>(this.GetWorkflowRootFilterModelValidationResult);
            base.RegisterHandler<Framework.Workflow.Domain.WorkflowSourceRootFilterModel>(this.GetWorkflowSourceRootFilterModelValidationResult);
        }
        
        protected virtual Framework.Validation.ValidationResult GetAvailableCommandFilterModelValidationResult(Framework.Workflow.Domain.AvailableCommandFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetAvailableTaskInstanceGroupItemValidationResult(Framework.Workflow.Domain.AvailableTaskInstanceGroupItem source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetAvailableTaskInstanceGroupValidationResult(Framework.Workflow.Domain.AvailableTaskInstanceGroup source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetAvailableTaskInstanceMainFilterModelValidationResult(Framework.Workflow.Domain.AvailableTaskInstanceMainFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetAvailableTaskInstanceUntypedMainFilterModelValidationResult(Framework.Workflow.Domain.AvailableTaskInstanceUntypedMainFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetAvailableTaskInstanceWorkflowGroupValidationResult(Framework.Workflow.Domain.AvailableTaskInstanceWorkflowGroup source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetCommandEventRootFilterModelValidationResult(Framework.Workflow.Domain.CommandEventRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetCommandEventValidationResult(Framework.Workflow.Domain.Definition.CommandEvent source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetCommandMetadataValidationResult(Framework.Workflow.Domain.Definition.CommandMetadata source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetCommandParameterValidationResult(Framework.Workflow.Domain.Definition.CommandParameter source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetCommandRoleAccessValidationResult(Framework.Workflow.Domain.Definition.CommandRoleAccess source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetCommandRootFilterModelValidationResult(Framework.Workflow.Domain.CommandRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetCommandValidationResult(Framework.Workflow.Domain.Definition.Command source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetConditionStateEventValidationResult(Framework.Workflow.Domain.Definition.ConditionStateEvent source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetConditionStateRootFilterModelValidationResult(Framework.Workflow.Domain.ConditionStateRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetConditionStateValidationResult(Framework.Workflow.Domain.Definition.ConditionState source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetCustomStateStartWorkflowRequestValidationResult(Framework.Workflow.Domain.StartWorkflowRequest.CustomStateStartWorkflowRequest source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetDomainTypeRootFilterModelValidationResult(Framework.Workflow.Domain.DomainTypeRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetDomainTypeValidationResult(Framework.Workflow.Domain.Definition.DomainType source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetEventRootFilterModelValidationResult(Framework.Workflow.Domain.EventRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetEventValidationResult(Framework.Workflow.Domain.Definition.Event source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetExecuteCommandRequestParameterValidationResult(Framework.Workflow.Domain.ExecuteCommandRequestParameter source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetExecuteCommandRequestValidationResult(Framework.Workflow.Domain.ExecuteCommandRequest source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetExecutedCommandParameterValidationResult(Framework.Workflow.Domain.Runtime.ExecutedCommandParameter source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetExecutedCommandValidationResult(Framework.Workflow.Domain.Runtime.ExecutedCommand source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetGroupExecuteCommandRequestValidationResult(Framework.Workflow.Domain.GroupExecuteCommandRequest source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetMassExecuteCommandRequestValidationResult(Framework.Workflow.Domain.MassExecuteCommandRequest source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetNamedLockValidationResult(Framework.Workflow.Domain.NamedLock source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetParallelStateFinalEventValidationResult(Framework.Workflow.Domain.Definition.ParallelStateFinalEvent source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetParallelStateRootFilterModelValidationResult(Framework.Workflow.Domain.ParallelStateRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetParallelStateStartItemValidationResult(Framework.Workflow.Domain.Definition.ParallelStateStartItem source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetParallelStateValidationResult(Framework.Workflow.Domain.Definition.ParallelState source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetRoleRootFilterModelValidationResult(Framework.Workflow.Domain.RoleRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetRoleValidationResult(Framework.Workflow.Domain.Definition.Role source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStartSubWorkflowRequestValidationResult(Framework.Workflow.Domain.StartWorkflowRequest.StartSubWorkflowRequest source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStartWorkflowDomainObjectConditionRootFilterModelValidationResult(Framework.Workflow.Domain.StartWorkflowDomainObjectConditionRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStartWorkflowDomainObjectConditionValidationResult(Framework.Workflow.Domain.Definition.StartWorkflowDomainObjectCondition source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStartWorkflowRequestParameterValidationResult(Framework.Workflow.Domain.StartWorkflowRequestParameter source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStartWorkflowRequestValidationResult(Framework.Workflow.Domain.StartWorkflowRequest source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStateBaseRootFilterModelValidationResult(Framework.Workflow.Domain.StateBaseRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStateBaseValidationResult(Framework.Workflow.Domain.Definition.StateBase source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStateDomainObjectEventValidationResult(Framework.Workflow.Domain.Definition.StateDomainObjectEvent source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStateInstanceValidationResult(Framework.Workflow.Domain.Runtime.StateInstance source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStateRootFilterModelValidationResult(Framework.Workflow.Domain.StateRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStateTimeoutEventValidationResult(Framework.Workflow.Domain.Definition.StateTimeoutEvent source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetStateValidationResult(Framework.Workflow.Domain.Definition.State source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTargetSystemValidationResult(Framework.Workflow.Domain.Definition.TargetSystem source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTaskInstanceRootFilterModelValidationResult(Framework.Workflow.Domain.TaskInstanceRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTaskInstanceValidationResult(Framework.Workflow.Domain.Runtime.TaskInstance source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTaskMetadataValidationResult(Framework.Workflow.Domain.Definition.TaskMetadata source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTaskRootFilterModelValidationResult(Framework.Workflow.Domain.TaskRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTaskValidationResult(Framework.Workflow.Domain.Definition.Task source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTransitionActionValidationResult(Framework.Workflow.Domain.Definition.TransitionAction source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTransitionInstanceValidationResult(Framework.Workflow.Domain.Runtime.TransitionInstance source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTransitionRootFilterModelValidationResult(Framework.Workflow.Domain.TransitionRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetTransitionValidationResult(Framework.Workflow.Domain.Definition.Transition source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowCreateModelValidationResult(Framework.Workflow.Domain.WorkflowCreateModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowInstanceParameterValidationResult(Framework.Workflow.Domain.Runtime.WorkflowInstanceParameter source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowInstanceRootFilterModelValidationResult(Framework.Workflow.Domain.WorkflowInstanceRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowInstanceValidationResult(Framework.Workflow.Domain.Runtime.WorkflowInstance source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowInstanceWatcherValidationResult(Framework.Workflow.Domain.Runtime.WorkflowInstanceWatcher source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowLambdaRootFilterModelValidationResult(Framework.Workflow.Domain.WorkflowLambdaRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowLambdaValidationResult(Framework.Workflow.Domain.Definition.WorkflowLambda source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowMetadataValidationResult(Framework.Workflow.Domain.Definition.WorkflowMetadata source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowParameterValidationResult(Framework.Workflow.Domain.Definition.WorkflowParameter source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowRootFilterModelValidationResult(Framework.Workflow.Domain.WorkflowRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowSourceRootFilterModelValidationResult(Framework.Workflow.Domain.WorkflowSourceRootFilterModel source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowSourceValidationResult(Framework.Workflow.Domain.Definition.WorkflowSource source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
        
        protected virtual Framework.Validation.ValidationResult GetWorkflowValidationResult(Framework.Workflow.Domain.Definition.Workflow source, Framework.Workflow.Domain.WorkflowOperationContext operationContext, Framework.Validation.IValidationState ownerState)
        {
            return base.GetValidationResult(source, operationContext, ownerState, false);
        }
    }
    
    public partial class WorkflowValidator : Framework.Workflow.BLL.WorkflowValidatorBase
    {
        
        public WorkflowValidator(Framework.Workflow.BLL.IWorkflowBLLContext context, Framework.Validation.ValidatorCompileCache cache) : 
                base(context, cache)
        {
        }
    }
}