using Automation.ServiceEnvironment;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.IntegrationTests.__Support.TestData.Helpers;
using WorkflowSampleSystem.WebApiCore.Controllers;

namespace WorkflowSampleSystem.IntegrationTests.__Support.TestData
{
    [TestClass]
    public class TestBase : IntegrationTestBase<IWorkflowSampleSystemBLLContext>
    {
        protected TestBase()
                : base(InitializeAndCleanup.TestEnvironment.ServiceProviderPool)
        {
            // Workaround for System.Drawing.Common problem https://chowdera.com/2021/12/202112240234238356.html
            System.AppContext.SetSwitch("System.Drawing.EnableUnixSupport", true);
        }

        protected DataHelper DataHelper => this.RootServiceProvider.GetService<DataHelper>();

        protected AuthHelper AuthHelper => this.RootServiceProvider.GetService<AuthHelper>();

        [TestInitialize]
        public void TestBaseInitialize()
        {
            base.Initialize();
        }

        [TestCleanup]
        public void BaseTestCleanup()
        {
            base.Cleanup();
        }

        protected ControllerEvaluator<AuthSLJsonController> GetAuthControllerEvaluator(string principalName = null)
        {
            return this.GetControllerEvaluator<AuthSLJsonController>(principalName);
        }

        protected ControllerEvaluator<ConfigSLJsonController> GetConfigurationControllerEvaluator(string principalName = null)
        {
            return this.GetControllerEvaluator<ConfigSLJsonController>(principalName);
        }

        protected ControllerEvaluator<WorkflowSLJsonController> GetWorkflowControllerEvaluator(string principalName = null)
        {
            return this.GetControllerEvaluator<WorkflowSLJsonController>(principalName);
        }
    }
}
