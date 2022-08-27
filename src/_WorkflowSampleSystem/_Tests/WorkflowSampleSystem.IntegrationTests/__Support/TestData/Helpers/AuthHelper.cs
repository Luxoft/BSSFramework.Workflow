using System;

using Automation.ServiceEnvironment;
using Automation.Utils;

using Framework.Workflow.BLL;

namespace WorkflowSampleSystem.IntegrationTests.__Support.TestData.Helpers
{
    public class AuthHelper : AuthHelperBase<IWorkflowBLLContext>
    {
        public AuthHelper(IServiceProvider rootServiceProvider) : base(rootServiceProvider)
        {
        }
    }
}
