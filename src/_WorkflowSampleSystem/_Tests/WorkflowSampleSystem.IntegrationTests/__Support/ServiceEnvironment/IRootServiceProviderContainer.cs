using System;

namespace WorkflowSampleSystem.IntegrationTests.__Support.ServiceEnvironment;

public interface IRootServiceProviderContainer
{
    IServiceProvider RootServiceProvider { get; }
}
