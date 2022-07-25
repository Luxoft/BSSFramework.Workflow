using System;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.Generated.DTO;
using WorkflowSampleSystem.IntegrationTests.__Support.ServiceEnvironment;

namespace WorkflowSampleSystem.IntegrationTests.__Support.TestData.Helpers
{
    public partial class DataHelper : IRootServiceProviderContainer
    {
        public DataHelper(IServiceProvider rootServiceProvider)
        {
            this.RootServiceProvider = rootServiceProvider;
        }

        public IServiceProvider RootServiceProvider { get; }


        public AuthHelper AuthHelper { private get; set; }

        public WorkflowSampleSystemServerPrimitiveDTOMappingService GetMappingService(IWorkflowSampleSystemBLLContext context)
        {
            return new WorkflowSampleSystemServerPrimitiveDTOMappingService(context);
        }

        private Guid GetGuid(Guid? id)
        {
            id = id ?? Guid.NewGuid();
            return (Guid)id;
        }
    }
}
