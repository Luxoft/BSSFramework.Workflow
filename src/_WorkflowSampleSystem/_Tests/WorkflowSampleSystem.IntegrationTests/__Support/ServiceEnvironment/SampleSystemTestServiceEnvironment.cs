using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

using Framework.Authorization.BLL;
using Framework.Cap.Abstractions;
using Framework.Core.Services;
using Framework.DomainDriven;
using Framework.DomainDriven.NHibernate.Audit;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.DomainDriven.WebApiNetCore;
using Framework.Exceptions;

using MediatR;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using nuSpec.Abstraction;
using nuSpec.NHibernate;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.IntegrationTests.__Support.ServiceEnvironment.IntegrationTests;
using WorkflowSampleSystem.IntegrationTests.__Support.TestData.Helpers;
using WorkflowSampleSystem.ServiceEnvironment;
using WorkflowSampleSystem.WebApiCore;
using WorkflowSampleSystem.WebApiCore.Env;

namespace WorkflowSampleSystem.IntegrationTests.__Support.ServiceEnvironment
{
    public static class WorkflowSampleSystemTestRootServiceProvider
    {
        public static readonly IServiceProvider Default = CreateDefault();

        private static IServiceProvider CreateDefault()
        {
            var serviceProvider = BuildServiceProvider();

            return serviceProvider;
        }


        private static IServiceProvider BuildServiceProvider()
        {
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", false, true)
                                .AddEnvironmentVariables(nameof(WorkflowSampleSystem) + "_")
                                .AddInMemoryCollection(new Dictionary<string, string>
                                 {
                                         {
                                                 "ConnectionStrings:DefaultConnection",
                                                 InitializeAndCleanup.DatabaseUtil.ConnectionSettings.ConnectionString
                                         },
                                 })
                                .Build();

            return new ServiceCollection()

                                  .AddEnvironment(configuration)

                                  .RegisterLegacyBLLContext()
                                  .AddControllerEnvironment()

                                  .AddMediatR(Assembly.GetAssembly(typeof(EmployeeBLL)))

                                  .RegisterControllers()

                                  .AddScoped<IntegrationTestsWebApiCurrentMethodResolver>()
                                  .ReplaceScopedFrom<IWebApiCurrentMethodResolver, IntegrationTestsWebApiCurrentMethodResolver>()

                                  .ReplaceSingleton<IWebApiExceptionExpander, WebApiDebugExceptionExpander>()

                                  .AddSingleton<IntegrationTestDefaultUserAuthenticationService>()
                                  .ReplaceSingletonFrom<IDefaultUserAuthenticationService, IntegrationTestDefaultUserAuthenticationService>()
                                  .ReplaceSingletonFrom<IAuditRevisionUserAuthenticationService, IntegrationTestDefaultUserAuthenticationService>()

                                  .ReplaceSingleton<IDateTimeService, IntegrationTestDateTimeService>()

                                  .AddSingleton<ICapTransactionManager, TestCapTransactionManager>()
                                  .AddSingleton<IIntegrationEventBus, TestIntegrationEventBus>()


                                  .AddSingleton<WorkflowSampleSystemInitializer>()

                                  .BuildServiceProvider(new ServiceProviderOptions { ValidateOnBuild = true, ValidateScopes = true });
        }


        private class TestCapTransactionManager : ICapTransactionManager
        {
            public void Enlist(IDbTransaction dbTransaction)
            {
            }
        }

        private class TestIntegrationEventBus : IIntegrationEventBus
        {
            public Task PublishAsync(IntegrationEvent @event, CancellationToken cancellationToken) => Task.CompletedTask;

            public void Publish(IntegrationEvent @event)
            {
            }
        }
    }
}
