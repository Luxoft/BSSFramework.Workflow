using System;
using System.Collections.Generic;

using Framework.Core;
using Framework.Workflow.Domain.Definition;
using Framework.Workflow.Domain.Runtime;



namespace Framework.Workflow.BLL
{
    public interface IWorkflowMachine
    {
        WorkflowInstance WorkflowInstance
        {
            get;
        }


        WorkflowProcessResult ProcessTransition(Transition transition, WorkflowProcessSettings processSettings);

        WorkflowProcessResult ProcessCurrentState(WorkflowProcessSettings processSettings);

        WorkflowProcessResult ProcessCurrentStateEvent(WorkflowProcessSettings processSettings);

        WorkflowProcessResult ProcessEvent(Event @event, WorkflowProcessSettings processSettings);


        WorkflowProcessResult TryFinishParallel();


        StateInstance SwitchState(StateBase newState);

        Event GetCurrentStateEvent();


        void Save();

        void Abort();



        void ExecuteCommandAction(ExecutedCommand executedCommand);




        bool GetConditionResult(ConditionState conditionState);

        bool GetParallelStateFinalEventResult(ParallelStateFinalEvent parallelStateFinalEvent);


        bool IsTimeout(StateTimeoutEvent stateTimeoutEvent, DateTime checkDate);

        bool IsEvaluated(StateDomainObjectEvent stateDomainObjectEvent);



        bool HasAccess(Task task);

        bool HasAccess(Command command);


        UnboundedList<string> GetAccessors(Task task);

        UnboundedList<string> GetAccessors(Command command);


        bool TryChangeActive();


        IEnumerable<string> GetReversePath(WorkflowSource workflowSource);
    }
}
