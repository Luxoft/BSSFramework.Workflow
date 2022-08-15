using System;
using System.Threading.Tasks;

using Framework.Core.Services;
using Framework.DomainDriven;

using WorkflowSampleSystem.WebApiCore.Env;

namespace WorkflowSampleSystem.WebApiCore;

public class WorkflowSampleSystemUserAuthenticationService : IUserAuthenticationService, IImpersonateService
{
    private readonly IDefaultUserAuthenticationService defaultAuthenticationService;

    public WorkflowSampleSystemUserAuthenticationService(IDefaultUserAuthenticationService defaultAuthenticationService)
    {
        this.defaultAuthenticationService = defaultAuthenticationService;
    }

    public string GetUserName() => this.CustomUserName ?? this.defaultAuthenticationService.GetUserName();

    public string CustomUserName { get; private set; }

    public async Task<T> WithImpersonateAsync<T>(string customUserName, Func<Task<T>> func)
    {
        var prev = this.CustomUserName;

        this.CustomUserName = customUserName;

        try
        {
            return await func();
        }
        finally
        {
            this.CustomUserName = prev;
        }
    }
}
