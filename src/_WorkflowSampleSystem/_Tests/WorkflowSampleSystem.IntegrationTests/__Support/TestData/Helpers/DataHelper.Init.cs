using System;

using Automation.ServiceEnvironment;

using Microsoft.Extensions.DependencyInjection;

using WorkflowSampleSystem.BLL;

namespace WorkflowSampleSystem.IntegrationTests.__Support.TestData.Helpers
{
    public partial class DataHelper : RootServiceProviderContainer<IWorkflowSampleSystemBLLContext>
    {
        public DataHelper(IServiceProvider rootServiceProvider)
                : base(rootServiceProvider)
        {
        }

        public AuthHelper AuthHelper => this.RootServiceProvider.GetRequiredService<AuthHelper>();

        private Guid GetGuid(Guid? id)
        {
            id = id ?? Guid.NewGuid();
            return (Guid)id;
        }
    }
}
