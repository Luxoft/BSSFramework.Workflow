using System;

using Framework.Core;
using Framework.DependencyInjection;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.DomainDriven.ServiceModel.Service;
using Framework.DomainDriven.WebApiNetCore;
using Framework.ExpressionParsers;
using Framework.Graphviz.Dot;
using Framework.Graphviz;
using Framework.QueryableSource;
using Framework.SecuritySystem;
using Framework.SecuritySystem.Rules.Builders;
using Framework.Workflow.BLL;
using Framework.Workflow.Generated.DTO;

using Microsoft.Extensions.DependencyInjection;

namespace Framework.Workflow.ServiceEnvironment
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterWorkflowBLL(this IServiceCollection services)
        {
            return services

                   .AddScoped<IOperationEventSenderContainer<Framework.Workflow.Domain.PersistentDomainObjectBase>, OperationEventSenderContainer<Framework.Workflow.Domain.PersistentDomainObjectBase>>()

                   .AddSingleton<WorkflowValidatorCompileCache>()

                   .AddScoped<IWorkflowValidator>(sp => new WorkflowValidator(sp.GetRequiredService<IWorkflowBLLContext>(), sp.GetRequiredService<WorkflowValidatorCompileCache>()))


                   .AddSingleton(new WorkflowMainFetchService().WithCompress().WithCache().WithLock().Add(FetchService<Framework.Workflow.Domain.PersistentDomainObjectBase>.OData))
                   .AddScoped<IWorkflowSecurityService, WorkflowSecurityService>()
                   .AddScoped<IWorkflowBLLFactoryContainer, WorkflowBLLFactoryContainer>()

                   .AddSingleton(WorkflowAnonymousTypeBuilder.CreateDefault())

                   .AddSingleton(CSharpNativeExpressionParser.Composite)
                   .AddScoped<IExpressionParserFactory, ExpressionParserFactory>()

                   .AddScoped<IWorkflowBLLContextSettings, WorkflowBLLContextSettings>()
                   .AddScopedFromLazyInterfaceImplement<IWorkflowBLLContext, WorkflowBLLContext>()

                   .AddScopedFrom<ISecurityOperationResolver<Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.WorkflowSecurityOperationCode>, IWorkflowBLLContext>()
                   .AddScopedFrom<IDisabledSecurityProviderContainer<Framework.Workflow.Domain.PersistentDomainObjectBase>, IWorkflowSecurityService>()
                   .AddScopedFrom<IWorkflowSecurityPathContainer, IWorkflowSecurityService>()
                   .AddScoped<IQueryableSource<Framework.Workflow.Domain.PersistentDomainObjectBase>, BLLQueryableSource<IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Framework.Workflow.Domain.DomainObjectBase, Guid>>()
                   .AddScoped<ISecurityExpressionBuilderFactory<Framework.Workflow.Domain.PersistentDomainObjectBase, Guid>, Framework.SecuritySystem.Rules.Builders.MaterializedPermissions.SecurityExpressionBuilderFactory<Framework.Workflow.Domain.PersistentDomainObjectBase, Guid>>()
                   .AddScoped<IAccessDeniedExceptionService<Framework.Workflow.Domain.PersistentDomainObjectBase>, AccessDeniedExceptionService<Framework.Workflow.Domain.PersistentDomainObjectBase, Guid>>()

                   .Self(WorkflowSecurityServiceBase.Register)
                   .Self(WorkflowBLLFactoryContainer.RegisterBLLFactory);
        }

        public static IServiceCollection RegisterWorkflowWebApiGenericServices(this IServiceCollection services)
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
    }
}
