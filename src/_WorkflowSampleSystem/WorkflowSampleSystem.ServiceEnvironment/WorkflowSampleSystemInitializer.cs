﻿using System;
using System.Collections.Generic;

using Framework.Authorization.SecuritySystem.OperationInitializer;
using Framework.DomainDriven;
using Framework.DomainDriven.ServiceModel.IAD;

using WorkflowSampleSystem.BLL;

using Framework.Workflow.BLL;

using Microsoft.Extensions.DependencyInjection;

namespace WorkflowSampleSystem.ServiceEnvironment;

public class WorkflowSampleSystemInitializer
{
    private readonly IContextEvaluator<IWorkflowSampleSystemBLLContext> contextEvaluator;

    private readonly IInitializeManager initializeManager;

    public WorkflowSampleSystemInitializer(IContextEvaluator<IWorkflowSampleSystemBLLContext> contextEvaluator, IInitializeManager initializeManager)
    {
        this.contextEvaluator = contextEvaluator;
        this.initializeManager = initializeManager;
    }

    public void Initialize()
    {
        this.initializeManager.InitializeOperation(this.InternalInitialize);
    }

    private void InternalInitialize()
    {
        this.contextEvaluator.Evaluate(
                DBSessionMode.Write,
                context =>
                {
                    context.Configuration.Logics.NamedLock.CheckInit();
                });

        this.contextEvaluator.Evaluate(
            DBSessionMode.Write,
            context =>
            {
                context.Logics.NamedLock.CheckInit();
            });

        this.contextEvaluator.Evaluate(
                                  DBSessionMode.Write,
                                  context =>
                                  {
                                      context.Workflow.Logics.NamedLock.CheckInit();
                                  });

        this.contextEvaluator.Evaluate(
            DBSessionMode.Write,
            context =>
            {
                context.ServiceProvider
                       .GetRequiredService<IAuthorizationOperationInitializer>()
                       .InitSecurityOperations(UnexpectedAuthOperationMode.Remove)
                       .GetAwaiter()
                       .GetResult();

                context.Configuration.Logics.TargetSystem.RegisterBase();
                context.Configuration.Logics.TargetSystem.Register<WorkflowSampleSystem.Domain.PersistentDomainObjectBase>(true, true);

                var extTypes = new Dictionary<Guid, Type>
                               {
                                       { new Guid("{79AF1049-3EC0-46A7-A769-62A24AD4F74E}"), typeof(Framework.Configuration.Domain.Sequence) }
                               };

                context.Configuration.Logics.TargetSystem.Register<Framework.Configuration.Domain.PersistentDomainObjectBase>(false, true, extTypes: extTypes);
                context.Configuration.Logics.TargetSystem.Register<Framework.Authorization.Domain.PersistentDomainObjectBase>(false, true);

                context.Workflow.Logics.TargetSystem.RegisterBase();
                context.Workflow.Logics.TargetSystem.Register<WorkflowSampleSystem.Domain.PersistentDomainObjectBase>(true);
                context.Workflow.Logics.TargetSystem.Register<Framework.Authorization.Domain.PersistentDomainObjectBase>(false);
            });

        this.contextEvaluator.Evaluate(
            DBSessionMode.Write,
            context =>
            {
                context.Configuration.Logics.SystemConstant.Initialize(typeof(WorkflowSampleSystemSystemConstant));
            });
    }
}
