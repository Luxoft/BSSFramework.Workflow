using System;
using System.Threading.Tasks;

using Framework.DomainDriven.WebApiNetCore;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

using WorkflowSampleSystem.IntegrationTests.__Support.TestData;

namespace WorkflowSampleSystem.IntegrationTests.__Support.ServiceEnvironment;

public class ControllerEvaluator<TController>
        where TController : ControllerBase, IApiControllerBase
{
    private readonly IServiceProvider rootServiceProvider;

    private readonly string customPrincipalName;

    public ControllerEvaluator([NotNull] IServiceProvider rootServiceProvider)
            : this(rootServiceProvider, null)
    {
    }

    private ControllerEvaluator([NotNull] IServiceProvider rootServiceProvider, string customPrincipalName)
    {
        this.rootServiceProvider = rootServiceProvider ?? throw new ArgumentNullException(nameof(rootServiceProvider));
        this.customPrincipalName = customPrincipalName;
    }

    public T Evaluate<T>(Func<TController, T> func)
    {
        return this.EvaluateAsync(async c => func(c)).Result;
    }

    public async Task<T> EvaluateAsync<T>(Func<TController, Task<T>> func)
    {
        using var scope = this.rootServiceProvider.CreateScope();

        var controller = scope.ServiceProvider.GetRequiredService<TController>();

        controller.ServiceProvider = scope.ServiceProvider;

        if (this.customPrincipalName == null)
        {
            return await func(controller);
        }
        else
        {
            return await scope.ServiceProvider.GetRequiredService<IntegrationTestsUserAuthenticationService>().ImpersonateAsync(this.customPrincipalName, async () => await func(controller));
        }
    }

    public async Task EvaluateAsync(Func<TController, Task> action)
    {
        await this.EvaluateAsync<object>(async c =>
        {
            await action(c);
            return default;
        });
    }

    public void Evaluate(Action<TController> action)
    {
        this.Evaluate(c =>
        {
            action(c);
            return default(object);
        });
    }

    public ControllerEvaluator<TController> WithImpersonate([CanBeNull] string customPrincipalName)
    {
        return new ControllerEvaluator<TController>(this.rootServiceProvider, customPrincipalName);
    }

    public ControllerEvaluator<TController> WithIntegrationImpersonate()
    {
        return this.WithImpersonate(DefaultConstants.INTEGRATION_USER);
    }
}
