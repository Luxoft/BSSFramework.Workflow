using System;

using Automation;
using Automation.Utils.DatabaseUtils;
using Automation.Utils.DatabaseUtils.Interfaces;

using WorkflowSampleSystem.IntegrationTests.__Support;
using WorkflowSampleSystem.IntegrationTests.Support.Utils;

namespace WorkflowSampleSystem.IntegrationTests;

public class WorkflowSampleSystemTestEnvironment : TestEnvironment
{
    private WorkflowSampleSystemTestEnvironment()
    {
    }

    protected override string EnvironmentPrefix => $"{nameof(WorkflowSampleSystem)}_";

    protected override ServiceProviderPool BuildServiceProvidePool()
    {
        return new WorkflowSampleSystemServiceProviderPool(this.RootConfiguration, this.ConfigUtil);
    }

    protected override TestDatabaseGenerator GetDatabaseGenerator(IServiceProvider serviceProvider, IDatabaseContext databaseContext)
    {
        return new WorkflowSampleSystemTestDatabaseGenerator(databaseContext, this.ConfigUtil ,serviceProvider);
    }

    public static readonly WorkflowSampleSystemTestEnvironment Current = new WorkflowSampleSystemTestEnvironment();
}
