using Automation;
using Automation.ServiceEnvironment;
using Automation.ServiceEnvironment.Services;

using Framework.Cap.Abstractions;
using Framework.DependencyInjection;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using WorkflowSampleSystem.IntegrationTests.__Support.TestData.Helpers;
using WorkflowSampleSystem.IntegrationTests.Support.Utils;
using WorkflowSampleSystem.ServiceEnvironment;
using WorkflowSampleSystem.WebApiCore.Controllers.Main;

namespace WorkflowSampleSystem.IntegrationTests.__Support
{
    [TestClass]
    public class InitializeAndCleanup
    {
        public static readonly TestEnvironment TestEnvironment = new TestEnvironmentBuilder()
                                                                 .WithDefaultConfiguration($"{nameof(WorkflowSampleSystem)}_")
                                                                 .WithDatabaseGenerator<WorkflowSampleSystemTestDatabaseGenerator>()
                                                                 .WithServiceProviderBuildFunc(GetServices)
                                                                 .Build();

        [AssemblyInitialize]
        public static void EnvironmentInitialize(TestContext testContext)
        {
            TestEnvironment.AssemblyInitializeAndCleanup.EnvironmentInitialize();
        }

        [AssemblyCleanup]
        public static void EnvironmentCleanup()
        {
            TestEnvironment.AssemblyInitializeAndCleanup.EnvironmentCleanup();
        }

        private static IServiceCollection GetServices(IConfiguration configuration, IServiceCollection services)
        {
            return services
                   .RegisterGeneralDependencyInjection(configuration)

                   .ApplyIntegrationTestServices()

                   .ReplaceSingleton<IIntegrationEventBus, IntegrationTestIntegrationEventBus>()
                   .ReplaceScoped<ICapTransactionManager, IntegrationTestCapTransactionManager>()

                   .AddSingleton<WorkflowSampleSystemInitializer>()

                   .RegisterControllers(new[] { typeof(EmployeeController).Assembly })

                   .AddSingleton<DataHelper>()
                   .AddSingleton<AuthHelper>()
                   .ValidateDuplicateDeclaration();
        }
    }
}
