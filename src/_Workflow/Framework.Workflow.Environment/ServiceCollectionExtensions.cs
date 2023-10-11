using System;

using Framework.Authorization.SecuritySystem;
using Framework.Core;
using Framework.DependencyInjection;
using Framework.DomainDriven;
using Framework.DomainDriven.ServiceModel.Service;
using Framework.DomainDriven.WebApiNetCore;
using Framework.ExpressionParsers;
using Framework.Graphviz.Dot;
using Framework.Graphviz;
using Framework.SecuritySystem.DependencyInjection;
using Framework.Workflow.BLL;
using Framework.Workflow.Domain.Definition;
using Framework.Workflow.Generated.DTO;
using Framework.SecuritySystem.DependencyInjection.DomainSecurityServiceBuilder;

using Microsoft.Extensions.DependencyInjection;
using Framework.Workflow.Domain.Runtime;

namespace Framework.Workflow.ServiceEnvironment
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterLegacyWorkflow(this IServiceCollection services)
        {
            return services.AddSingleton(new SecurityOperationTypeInfo(typeof(WorkflowSecurityOperation)))
                           .RegisterWorkflowBLL()
                           .RegisterWorkflowDomainSecurityServices()
                           .RegisterWorkflowWebApiGenericServices();
        }

        private static IServiceCollection RegisterWorkflowBLL(this IServiceCollection services)
        {
            return services

                   .AddSingleton<WorkflowValidationMap>()
                   .AddSingleton<WorkflowValidatorCompileCache>()
                   .AddScoped<IWorkflowValidator, WorkflowValidator>()

                   .AddSingleton(new WorkflowMainFetchService().WithCompress().WithCache().WithLock().Add(FetchService<Framework.Workflow.Domain.PersistentDomainObjectBase>.OData))
                   .AddScoped<IWorkflowBLLFactoryContainer, WorkflowBLLFactoryContainer>()
                   .AddScoped<IWorkflowBLLContextSettings, WorkflowBLLContextSettings>()

                   .AddScopedFromLazyInterfaceImplement<IWorkflowBLLContext, WorkflowBLLContext>()

                   .Self(WorkflowBLLFactoryContainer.RegisterBLLFactory)

                   .AddSingleton(WorkflowAnonymousTypeBuilder.CreateDefault())
                   .AddSingleton(CSharpNativeExpressionParser.Composite)
                   .AddScoped<IExpressionParserFactory, ExpressionParserFactory>();
        }

        private static IServiceCollection RegisterWorkflowDomainSecurityServices(this IServiceCollection services)
        {
            return services.RegisterDomainSecurityServices<Guid>(

                rb =>
                        rb.AddWorkflow<Command>()
                          .AddWorkflow<StartWorkflowDomainObjectCondition>()
                          .AddWorkflow<WorkflowLambda>()
                          .AddWorkflow<StateBase>()
                          .AddWorkflow<TargetSystem>()
                          .AddWorkflow<Task>()
                          .AddWorkflow<Transition>()
                          .AddWorkflow<TransitionAction>()
                          .AddWorkflow<Domain.Definition.Workflow>()
                          .AddWorkflow<WorkflowSource>()

                          .AddWorkflow<TaskInstance>(b => b.SetCustomService<WorkflowTaskInstanceSecurityService>())
                          .AddWorkflow<WorkflowInstance>(b => b.SetCustomService<WorkflowWorkflowInstanceSecurityService>())
                          .AddWorkflow<StateInstance>()
                          .AddWorkflow<TransitionInstance>()
                          .AddWorkflow<DomainType>()
                          .AddWorkflow<ParallelStateStartItem>()
                          .AddWorkflow<Role>()
                          .AddWorkflow<Event>());
        }

        private static IServiceCollection RegisterWorkflowWebApiGenericServices(this IServiceCollection services)
        {
            services.AddSingleton(LazyInterfaceImplementHelper.CreateNotImplemented<IDotVisualizer<DotGraph>>());

            services.RegisterWorkflowContextEvaluator();

            return services;
        }



        private static IServiceCollection RegisterWorkflowContextEvaluator(this IServiceCollection services)
        {
            services.AddSingleton<IContextEvaluator<IWorkflowBLLContext>, ContextEvaluator<IWorkflowBLLContext>>();
            services.AddScoped<IApiControllerBaseEvaluator<EvaluatedData<IWorkflowBLLContext, IWorkflowDTOMappingService>>, ApiControllerBaseSingleCallEvaluator<EvaluatedData<IWorkflowBLLContext, IWorkflowDTOMappingService>>>();

            return services;
        }

        private static IDomainSecurityServiceRootBuilder AddWorkflow<TDomainObject>(this IDomainSecurityServiceRootBuilder rootBuilder, Action<IDomainSecurityServiceBuilder<TDomainObject>> setup = null)
        {
            return rootBuilder.Add<TDomainObject>(
                                                  b =>
                                                  {
                                                      b.SetView(WorkflowSecurityOperation.WorkflowView)
                                                       .SetEdit(WorkflowSecurityOperation.WorkflowEdit);

                                                      setup?.Invoke(b);
                                                  });
        }
    }
}
