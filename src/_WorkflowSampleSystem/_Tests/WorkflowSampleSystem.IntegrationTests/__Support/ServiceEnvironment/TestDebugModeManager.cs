using Framework.DomainDriven.ServiceModel.Service;

namespace WorkflowSampleSystem.IntegrationTests.__Support.ServiceEnvironment;

public class TestDebugModeManager : IDebugModeManager
{
    public bool IsDebugMode { get; set; } = true;
}
