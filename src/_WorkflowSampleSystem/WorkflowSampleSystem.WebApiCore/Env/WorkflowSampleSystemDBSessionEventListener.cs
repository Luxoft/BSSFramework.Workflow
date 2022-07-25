using System.Collections.Generic;
using System.Linq;

using Framework.Configuration.BLL;
using Framework.Core;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.Workflow.BLL;
using Framework.Workflow.Environment;

namespace WorkflowSampleSystem.WebApiCore;

public class WorkflowSampleSystemDBSessionEventListener : DBSessionEventListener, IDBSessionEventListener
{
    private readonly IInitializeManager initializeManager;

    private readonly IWorkflowBLLContext workflowBllContext;

    public WorkflowSampleSystemDBSessionEventListener(
            IInitializeManager initializeManager,
            IEnumerable<IFlushedDALListener> flushedDalListener,
            IEnumerable<IBeforeTransactionCompletedDALListener> beforeTransactionCompletedDalListener,
            IEnumerable<IAfterTransactionCompletedDALListener> afterTransactionCompletedDalListener,
            IConfigurationBLLContext configurationBLLContext,
            IWorkflowBLLContext workflowBLLContext,
            IStandardSubscriptionService subscriptionService)
            : base(initializeManager, flushedDalListener, beforeTransactionCompletedDalListener, afterTransactionCompletedDalListener, configurationBLLContext, subscriptionService)
    {
        this.initializeManager = initializeManager;
        this.workflowBllContext = workflowBLLContext;
    }

    public new void OnFlushed(DALChangesEventArgs eventArgs)
    {
        if (this.initializeManager.IsInitialize)
        {
            return;
        }

        base.OnFlushed(eventArgs);

        this.GetWorkflowDALListeners().Foreach(listener => listener.Process(eventArgs));
    }

    private IEnumerable<IFlushedDALListener> GetWorkflowDALListeners()
    {
        return from targetSystemService in this.workflowBllContext.GetTargetSystemServices()

               select new WorkflowDALListener(targetSystemService);
    }
}
