using System.Diagnostics.CodeAnalysis;

using Framework.Authorization.BLL;
using Framework.Authorization.Notification;
using Framework.Cap;
using Framework.DependencyInjection;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using WorkflowSampleSystem.BLL;

namespace WorkflowSampleSystem.ServiceEnvironment;

public static class WorkflowSampleSystemApplicationExtensions
{
    [SuppressMessage("SonarQube","S4792",Justification = "reviewed")]
    public static IServiceCollection RegisterGeneralApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services.RegisterApplicationServices()
                       .AddLogging()
                       .AddCapBss(configuration.GetConnectionString("DefaultConnection"));
    }

    private static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<INotificationPrincipalExtractor, LegacyNotificationPrincipalExtractor>();

        services.AddScopedFromLazyInterfaceImplement<IWorkflowSampleSystemAuthorizationBLLContext, WorkflowSampleSystemAuthorizationBLLContext>();

        services.ReplaceScopedFrom<IAuthorizationBLLContext, IWorkflowSampleSystemAuthorizationBLLContext>();
        services.ReplaceScopedFrom<AuthorizationBLLContext, WorkflowSampleSystemAuthorizationBLLContext>();

        services.AddScoped<IWorkflowApproveProcessor, WorkflowApproveProcessor>();

        return services;
    }
}
