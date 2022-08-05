using System;
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

            return new ServiceCollection()
                                  .RegisterLegacyBLLContext()
                                  .RegisterControllers()
                                  .AddControllerEnvironment()

                                  .AddSingleton<IWebApiExceptionExpander, WebApiDebugExceptionExpander>()

                                  .AddMediatR(Assembly.GetAssembly(typeof(EmployeeBLL)))

                                  .AddSingleton<IntegrationTestDefaultUserAuthenticationService>()
                                  .AddSingletonFrom<IDefaultUserAuthenticationService, IntegrationTestDefaultUserAuthenticationService>()
                                  .AddSingletonFrom<IAuditRevisionUserAuthenticationService, IntegrationTestDefaultUserAuthenticationService>()

                                  .AddScoped<WorkflowSampleSystemUserAuthenticationService>()
                                  .AddScopedFrom<IUserAuthenticationService, WorkflowSampleSystemUserAuthenticationService>()
                                  .AddScopedFrom<IImpersonateService, WorkflowSampleSystemUserAuthenticationService>()

                                  .AddSingleton<IDateTimeService, IntegrationTestDateTimeService>()
                                  .AddDatabaseSettings(InitializeAndCleanup.DatabaseUtil.ConnectionSettings.ConnectionString)
                                  .AddSingleton<ISpecificationEvaluator, NhSpecificationEvaluator>()
                                  .AddSingleton<ICapTransactionManager, TestCapTransactionManager>()
                                  .AddSingleton<IIntegrationEventBus, TestIntegrationEventBus>()

                                  .AddScoped<IWorkflowApproveProcessor, WorkflowApproveProcessor>()

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
