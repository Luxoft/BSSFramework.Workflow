﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using WorkflowSampleSystem.Security;

namespace WorkflowSampleSystem.ServiceEnvironment;

public static class WorkflowSampleSystemGeneralDependencyInjectionExtensions
{
    public static IServiceCollection RegisterGeneralDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        return services
               .RegisterGeneralBssFramework()
               .RegisterGeneralDatabaseSettings(configuration)
               .RegisterGeneralApplicationServices(configuration)
               .RegisterGeneralSecurityServices();
    }
}
