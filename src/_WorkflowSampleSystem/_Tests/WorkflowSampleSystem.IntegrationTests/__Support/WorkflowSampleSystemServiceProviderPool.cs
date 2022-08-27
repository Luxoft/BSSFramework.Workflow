using System;

using Automation;
using Automation.Utils;
using Automation.Utils.DatabaseUtils.Interfaces;

using Microsoft.Extensions.Configuration;

namespace WorkflowSampleSystem.IntegrationTests.__Support;

public class WorkflowSampleSystemServiceProviderPool : ServiceProviderPool
{
    public WorkflowSampleSystemServiceProviderPool(IConfiguration rootRootConfiguration, ConfigUtil configUtil) : base(rootRootConfiguration, configUtil)
    {
    }

    protected override IServiceProvider Build(IDatabaseContext databaseContext)
    {
        return WorkflowSampleSystemTestRootServiceProvider.Create(this.RootConfiguration, databaseContext, this.ConfigUtil);
    }
}
