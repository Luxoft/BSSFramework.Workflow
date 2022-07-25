using Framework.Authorization.BLL;
using Framework.Authorization.Generated.DAL.NHibernate;
using Framework.Cap;
using Framework.Configuration.Generated.DAL.NHibernate;
using Framework.Core.Services;
using Framework.DependencyInjection;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.NHibernate;
using Framework.DomainDriven.NHibernate.Audit;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.DomainDriven.WebApiNetCore;
using Framework.Exceptions;
using Framework.Workflow.Generated.DAL.NHibernate;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using nuSpec.Abstraction;
using nuSpec.NHibernate;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.Generated.DAL.NHibernate;
using WorkflowSampleSystem.WebApiCore.Env;
using WorkflowSampleSystem.WebApiCore.Env.Database;

namespace WorkflowSampleSystem.WebApiCore
{
    public static class EnvironmentExtensions
    {
        public static IServiceCollection AddEnvironment(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddHttpContextAccessor();

            services.AddDatabaseSettings(connectionString);
            services.AddCapBss(connectionString);

            // Notifications
            services.RegisterMessageSenderDependencies<IWorkflowSampleSystemBLLContext>(configuration);
            services.RegisterRewriteReceiversDependencies(configuration);

            // Others
            services.AddSingleton<IDateTimeService>(DateTimeService.Default);

            services.AddSingleton<WorkflowSampleSystemDefaultUserAuthenticationService>();
            services.AddSingletonFrom<IDefaultUserAuthenticationService, WorkflowSampleSystemDefaultUserAuthenticationService>();
            services.AddSingletonFrom<IAuditRevisionUserAuthenticationService, WorkflowSampleSystemDefaultUserAuthenticationService>();

            services.AddScoped<WorkflowSampleSystemUserAuthenticationService>();
            services.AddScopedFrom<IUserAuthenticationService, WorkflowSampleSystemUserAuthenticationService>();
            services.AddScopedFrom<IUserAuthenticationService, WorkflowSampleSystemUserAuthenticationService>();

            services.AddSingleton<ISpecificationEvaluator, NhSpecificationEvaluator>();

            return services.AddControllerEnvironment();
        }

        public static IServiceCollection AddDatabaseSettings(this IServiceCollection services, string connectionString) =>
                services.AddScoped<INHibSessionSetup, NHibSessionSettings>()

                        .AddScoped<IDBSessionEventListener, WorkflowSampleSystemDBSessionEventListener>()
                        .AddScopedFromLazy<IDBSession, NHibSession>()

                        .AddSingleton<INHibSessionEnvironmentSettings, NHibSessionEnvironmentSettings>()
                        .AddSingleton<NHibConnectionSettings>()
                        .AddSingleton<NHibSessionEnvironment, WorkflowSampleSystemNHibSessionEnvironment>()

                        .AddSingleton<IMappingSettings>(AuthorizationMappingSettings.CreateDefaultAudit(string.Empty))
                        .AddSingleton<IMappingSettings>(ConfigurationMappingSettings.CreateDefaultAudit(string.Empty))
                        .AddSingleton<IMappingSettings>(WorkflowMappingSettings.CreateWithoutAudit(string.Empty))
                        .AddSingleton<IMappingSettings>(
                                                        new WorkflowSampleSystemMappingSettings(
                                                         new DatabaseName(string.Empty, "app"),
                                                         connectionString));

        public static IServiceCollection AddControllerEnvironment(this IServiceCollection services)
        {
            services.AddSingleton<IExceptionProcessor, ApiControllerExceptionService<IWorkflowSampleSystemBLLContext>>();
            services.AddSingleton<IContextEvaluator<IAuthorizationBLLContext>, ContextEvaluator<IAuthorizationBLLContext>>();
            services.AddSingleton<IContextEvaluator<IWorkflowSampleSystemBLLContext>, ContextEvaluator<IWorkflowSampleSystemBLLContext>>();

            return services;
        }
    }
}
