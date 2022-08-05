using Framework.Authorization.BLL;
using Framework.Authorization.Generated.DAL.NHibernate;
using Framework.Authorization.Generated.DTO;
using Framework.Cap;
using Framework.Configuration.BLL;
using Framework.Configuration.Generated.DAL.NHibernate;
using Framework.Configuration.Generated.DTO;
using Framework.Core.Services;
using Framework.DependencyInjection;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.NHibernate;
using Framework.DomainDriven.NHibernate.Audit;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.DomainDriven.ServiceModel.Service;
using Framework.DomainDriven.WebApiNetCore;
using Framework.Exceptions;
using Framework.Workflow.BLL;
using Framework.Workflow.Environment;
using Framework.Workflow.Generated.DAL.NHibernate;
using Framework.Workflow.Generated.DTO;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using nuSpec.Abstraction;
using nuSpec.NHibernate;

using WorkflowSampleSystem.BLL;
using WorkflowSampleSystem.Generated.DAL.NHibernate;
using WorkflowSampleSystem.Generated.DTO;
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

                        .AddScoped<IDBSessionEventListener, DBSessionEventListener>()
                        .AddScoped<IDBSessionEventListener, WorkflowDBSessionEventListener>()
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
            services.AddSingleton<IWebApiExceptionExpander, WebApiExceptionExpander>();

            services.AddSingleton<IContextEvaluator<IAuthorizationBLLContext>, ContextEvaluator<IAuthorizationBLLContext>>();
            services.AddSingleton<IContextEvaluator<IConfigurationBLLContext>, ContextEvaluator<IConfigurationBLLContext>>();
            services.AddSingletonFrom<IContextEvaluator<Framework.DomainDriven.BLL.Configuration.IConfigurationBLLContext>, IContextEvaluator<IConfigurationBLLContext>>();
            services.AddSingleton<IContextEvaluator<IWorkflowSampleSystemBLLContext>, ContextEvaluator<IWorkflowSampleSystemBLLContext>>();

            services.AddScoped<IApiControllerBaseEvaluator<EvaluatedData<IAuthorizationBLLContext, IAuthorizationDTOMappingService>>, ApiControllerBaseSingleCallEvaluator<EvaluatedData<IAuthorizationBLLContext, IAuthorizationDTOMappingService>>>();
            services.AddScoped<IApiControllerBaseEvaluator<EvaluatedData<IConfigurationBLLContext, IConfigurationDTOMappingService>>, ApiControllerBaseSingleCallEvaluator<EvaluatedData<IConfigurationBLLContext, IConfigurationDTOMappingService>>>();
            services.AddScoped<IApiControllerBaseEvaluator<EvaluatedData<IWorkflowBLLContext, IWorkflowDTOMappingService>>, ApiControllerBaseSingleCallEvaluator<EvaluatedData<IWorkflowBLLContext, IWorkflowDTOMappingService>>>();
            services.AddScoped<IApiControllerBaseEvaluator<EvaluatedData<IWorkflowSampleSystemBLLContext, IWorkflowSampleSystemDTOMappingService>>, ApiControllerBaseSingleCallEvaluator<EvaluatedData<IWorkflowSampleSystemBLLContext, IWorkflowSampleSystemDTOMappingService>>>();

            return services;
        }
    }
}
