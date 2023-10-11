using System;

using Framework.Authorization.Generated.DAL.NHibernate;
using Framework.Configuration.Generated.DAL.NHibernate;
using Framework.DomainDriven;
using Framework.DomainDriven.NHibernate;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.Workflow.Environment;
using Framework.Workflow.Generated.DAL.NHibernate;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using nuSpec.Abstraction;
using nuSpec.NHibernate;

using WorkflowSampleSystem.Domain;
using WorkflowSampleSystem.Generated.DAL.NHibernate;

namespace WorkflowSampleSystem.ServiceEnvironment;

public static class WorkflowSampleSystemFrameworkDatabaseExtensions
{
    public static IServiceCollection RegisterGeneralDatabaseSettings(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        return services.AddDatabaseSettings(connectionString)
                       .AddLegacyDatabaseSettings()
                       .RegistryGenericDatabaseVisitors()
                       .RegistryDatabaseVisitors()
                       .RegisterSpecificationEvaluator();
    }

    private static IServiceCollection RegisterSpecificationEvaluator(this IServiceCollection services)
    {
        return services.AddSingleton<ISpecificationEvaluator, NhSpecificationEvaluator>();
    }

    public static IServiceCollection AddDatabaseSettings(this IServiceCollection services, string connectionString)
    {
        return services.AddDatabaseSettings(setupObj => setupObj.AddEventListener<DefaultDBSessionEventListener>()
                                                                .AddEventListener<WorkflowDBSessionEventListener>()

                                                                .AddMapping(AuthorizationMappingSettings.CreateDefaultAudit(string.Empty))
                                                                .AddMapping(ConfigurationMappingSettings.CreateDefaultAudit(string.Empty))
                                                                .AddMapping(WorkflowMappingSettings.CreateWithoutAudit(string.Empty))
                                                                .AddMapping(new WorkflowSampleSystemMappingSettings(new DatabaseName(string.Empty, "app"), connectionString)));
    }

    private static IServiceCollection RegistryDatabaseVisitors(this IServiceCollection services)
    {
        services.AddSingleton<IExpressionVisitorContainerItem, ExpressionVisitorContainerDomainIdentItem<PersistentDomainObjectBase, Guid>>();

        return services;
    }
}
