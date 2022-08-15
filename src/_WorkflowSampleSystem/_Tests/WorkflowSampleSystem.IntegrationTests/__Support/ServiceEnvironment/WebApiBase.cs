﻿using System;

using Framework.DomainDriven.WebApiNetCore;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace WorkflowSampleSystem.IntegrationTests.__Support.ServiceEnvironment;

public abstract class WebApiBase : IRootServiceProviderContainer
{
    private readonly IServiceProvider serviceProvider;

    protected WebApiBase(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public virtual ControllerEvaluator<TController> GetControllerEvaluator<TController>(string principalName = null)
            where TController : ControllerBase
    {
        var controllerEvaluator = this.serviceProvider.GetRequiredService<ControllerEvaluator<TController>>();

        return principalName == null ? controllerEvaluator : controllerEvaluator.WithImpersonate(principalName);
    }

    IServiceProvider IRootServiceProviderContainer.RootServiceProvider => this.serviceProvider;
}
