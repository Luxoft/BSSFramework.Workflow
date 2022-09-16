using System.Reflection;

using Framework.Authorization.BLL;
using Framework.Cap;
using Framework.DependencyInjection;

using MediatR;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using WorkflowSampleSystem.BLL;

namespace WorkflowSampleSystem.ServiceEnvironment;

public static class WorkflowSampleSystemApplicationExtensions
{
    public static IServiceCollection RegisterGeneralApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services.AddMediatR(Assembly.GetAssembly(typeof(EmployeeBLL)))
                       .RegisterApplicationServices()
                       .AddLogging()
                       .AddCapBss(configuration.GetConnectionString("DefaultConnection"));
    }

    private static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
        services.AddScopedFromLazyInterfaceImplement<IWorkflowSampleSystemAuthorizationBLLContext, WorkflowSampleSystemAuthorizationBLLContext>();

        services.ReplaceScopedFrom<IAuthorizationBLLContext, IWorkflowSampleSystemAuthorizationBLLContext>();
        services.ReplaceScopedFrom<AuthorizationBLLContext, WorkflowSampleSystemAuthorizationBLLContext>();

        services.AddScoped<IWorkflowApproveProcessor, WorkflowApproveProcessor>();

        return services;
    }
}
