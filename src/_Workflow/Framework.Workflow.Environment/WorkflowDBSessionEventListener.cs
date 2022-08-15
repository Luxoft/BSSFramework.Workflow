using System.Collections.Generic;
using System.Linq;

using Framework.Core;
using Framework.DomainDriven;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.Workflow.BLL;

namespace Framework.Workflow.Environment;

public class WorkflowDBSessionEventListener : IDBSessionEventListener
{
    private readonly IInitializeManager initializeManager;

    private readonly IWorkflowBLLContext workflowBllContext;

    public WorkflowDBSessionEventListener(IInitializeManager initializeManager, IWorkflowBLLContext workflowBLLContext)
    {
        this.initializeManager = initializeManager;
        this.workflowBllContext = workflowBLLContext;
    }

    public void OnFlushed(DALChangesEventArgs eventArgs)
    {
        if (this.initializeManager.IsInitialize)
        {
            return;
        }

        this.GetWorkflowDALListeners().Foreach(listener => listener.Process(eventArgs));
    }

    public void OnBeforeTransactionCompleted(DALChangesEventArgs eventArgs)
    {
    }

    public void OnAfterTransactionCompleted(DALChangesEventArgs eventArgs)
    {
    }

    private IEnumerable<IFlushedDALListener> GetWorkflowDALListeners()
    {
        return from targetSystemService in this.workflowBllContext.GetTargetSystemServices()

               select new WorkflowDALListener(targetSystemService);
    }
}
