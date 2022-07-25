using System;

using Framework.Core;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.ExpressionParsers;
using Framework.QueryableSource;
using Framework.SecuritySystem;
using Framework.SecuritySystem.Rules.Builders;
using Framework.Workflow.BLL;

using Microsoft.Extensions.DependencyInjection;

namespace Framework.Workflow.ServiceEnvironment
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterWorkflowBLL(this IServiceCollection services)
        {
            return services

                   .AddScoped(sp => sp.GetRequiredService<IDBSession>().GetDALFactory<Framework.Workflow.Domain.PersistentDomainObjectBase, Guid>())

                   .AddScoped<IOperationEventSenderContainer<Framework.Workflow.Domain.PersistentDomainObjectBase>, OperationEventSenderContainer<Framework.Workflow.Domain.PersistentDomainObjectBase>>()

                   .AddScoped<BLLSourceEventListenerContainer<Framework.Workflow.Domain.PersistentDomainObjectBase>>()

                   .AddSingleton<WorkflowValidatorCompileCache>()

                   .AddScoped<IWorkflowValidator>(sp =>
                                                          new WorkflowValidator(sp.GetRequiredService<IWorkflowBLLContext>(), sp.GetRequiredService<WorkflowValidatorCompileCache>()))


                   .AddSingleton(new WorkflowMainFetchService().WithCompress().WithCache().WithLock().Add(FetchService<Framework.Workflow.Domain.PersistentDomainObjectBase>.OData))
                   .AddScoped<IWorkflowSecurityService, WorkflowSecurityService>()
                   .AddScoped<IWorkflowBLLFactoryContainer, WorkflowBLLFactoryContainer>()

                   .AddScopedFrom<ICurrentRevisionService, IDBSession>()

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
    }
}
