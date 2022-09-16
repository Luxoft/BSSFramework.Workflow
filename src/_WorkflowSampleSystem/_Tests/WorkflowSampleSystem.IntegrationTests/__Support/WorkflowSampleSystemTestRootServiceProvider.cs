using System;
using System.Reflection;

using Framework.Cap.Abstractions;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.IntegrationTests.__Support.TestData.Helpers;
using WorkflowSampleSystem.ServiceEnvironment;
using WorkflowSampleSystem.WebApiCore;

using Microsoft.Extensions.Configuration;

using System.Collections.Generic;

using WorkflowSampleSystem.WebApiCore.Controllers.Main;

using Automation.ServiceEnvironment;
using Automation.ServiceEnvironment.Services;
using Automation.Utils;
using Automation.Utils.DatabaseUtils.Interfaces;

using Framework.DependencyInjection;

namespace WorkflowSampleSystem.IntegrationTests.__Support
{
    public static class WorkflowSampleSystemTestRootServiceProvider
    {
        public static IServiceProvider Create(IConfiguration configurationBase, IDatabaseContext databaseContext, ConfigUtil configUtil)
        {
            var configuration = new ConfigurationBuilder()
                                .AddConfiguration(configurationBase)
                                .AddInMemoryCollection(new Dictionary<string, string>
                                                       {
                                                               { "ConnectionStrings:DefaultConnection", databaseContext.Main.ConnectionString }
                                                       }).Build();


            return new ServiceCollection()

                   .RegisterGeneralDependencyInjection(configuration)

                   .ApplyIntegrationTestServices()

                   .ReplaceSingleton<IIntegrationEventBus, IntegrationTestIntegrationEventBus>()
                   .ReplaceScoped<ICapTransactionManager, IntegrationTestCapTransactionManager>()

                   .AddSingleton<WorkflowSampleSystemInitializer>()

                   .RegisterControllers(new[] { typeof(EmployeeController).Assembly })

                   .AddSingleton(databaseContext)
                   .AddSingleton<DataHelper>()
                   .AddSingleton<AuthHelper>()
                   .AddSingleton(configUtil)
                   .ValidateDuplicateDeclaration()
                   .BuildServiceProvider(new ServiceProviderOptions { ValidateOnBuild = true, ValidateScopes = true });
        }
    }
}
