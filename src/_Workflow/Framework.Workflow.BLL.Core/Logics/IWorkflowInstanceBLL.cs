using System;
using System.Collections.Generic;

using Framework.Core;
using Framework.Workflow.Domain;
using Framework.Workflow.Domain.Definition;
using Framework.Workflow.Domain.Runtime;

namespace Framework.Workflow.BLL
{
    public partial interface IWorkflowInstanceBLL
    {
        WorkflowInstance Start(StartWorkflowRequest request);

        WorkflowProcessResult ExecuteCommands(MassExecuteCommandRequest massRequest);

        WorkflowProcessResult ExecuteCommand(ExecuteCommandRequest singleRequest);

        WorkflowProcessResult TryExecuteCommands(Guid domainObjectId, Command command, Dictionary<string, string> parameters);

        void Abort(WorkflowInstance workflowInstance);

        ITryResult<WorkflowProcessResult>[] CheckTimeouts();
    }
}
