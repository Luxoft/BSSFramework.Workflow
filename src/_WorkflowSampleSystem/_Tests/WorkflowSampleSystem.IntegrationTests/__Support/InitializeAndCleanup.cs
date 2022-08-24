using Microsoft.VisualStudio.TestTools.UnitTesting;

using Automation;
using Automation.Utils;

using WorkflowSampleSystem.IntegrationTests.Support.Utils;
using Automation.Utils.DatabaseUtils;

namespace WorkflowSampleSystem.IntegrationTests.__Support
{
    [TestClass]
    public class InitializeAndCleanup
    {
        public static WorkflowSampleSystemDatabaseUtil DatabaseUtil { get; set; }

        [AssemblyInitialize]
        public static void EnvironmentInitialize(TestContext testContext)
        {
            AppSettings.Initialize(nameof(WorkflowSampleSystem) + "_");
            var databaseContext = new DatabaseContext(AppSettings.Default["ConnectionStrings"]);
            DatabaseUtil = new WorkflowSampleSystemDatabaseUtil(databaseContext);

            AssemblyInitializeAndCleanup.EnvironmentInitialize(DatabaseUtil);
        }

        [AssemblyCleanup]
        public static void EnvironmentCleanup()
        {
            AssemblyInitializeAndCleanup.EnvironmentCleanup(DatabaseUtil);
        }
    }
}
