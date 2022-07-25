using System;
using System.Collections.Generic;
using System.Linq;

using Framework.Authorization.BLL;
using Framework.Workflow.Domain;
using Framework.Core;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.BLL.Security;
using Framework.Persistent;
using Framework.Workflow.Domain.Definition;

using Microsoft.Extensions.DependencyInjection;

namespace Framework.Workflow.BLL;

public class TargetSystemServiceFactory
{
    private readonly IServiceProvider serviceProvider;

    private readonly Lazy<List<TargetSystem>> lazyTargetSystems;

    public TargetSystemServiceFactory(IServiceProvider serviceProvider, IWorkflowBLLContext context)
    {
        this.serviceProvider = serviceProvider;

        this.lazyTargetSystems = LazyHelper.Create(() => context.Logics.TargetSystem.GetFullList());
    }

    public ITargetSystemService Create<TBLLContext, TPersistentDomainObjectBase, TSecurityOperationCode>(string name)
            where TBLLContext : class, ITypeResolverContainer<string>, ISecurityServiceContainer<IRootSecurityService<TBLLContext, TPersistentDomainObjectBase>>, IBLLOperationEventContext<TPersistentDomainObjectBase>, ISecurityServiceContainer<ISecurityProviderSource<TPersistentDomainObjectBase, TSecurityOperationCode>>, ISecurityBLLContext<IAuthorizationBLLContext, TPersistentDomainObjectBase, Guid>, IAccessDeniedExceptionServiceContainer<TPersistentDomainObjectBase>
            where TPersistentDomainObjectBase : class, IIdentityObject<Guid>
            where TSecurityOperationCode : struct, Enum
    {
        return this.Create<TBLLContext, TPersistentDomainObjectBase, TSecurityOperationCode>(tss => tss.Name == name);
    }

    public ITargetSystemService Create<TBLLContext, TPersistentDomainObjectBase, TSecurityOperationCode>(Func<TargetSystem, bool> filter)
            where TBLLContext : class, ITypeResolverContainer<string>, ISecurityServiceContainer<IRootSecurityService<TBLLContext, TPersistentDomainObjectBase>>, IBLLOperationEventContext<TPersistentDomainObjectBase>, ISecurityServiceContainer<ISecurityProviderSource<TPersistentDomainObjectBase, TSecurityOperationCode>>, ISecurityBLLContext<IAuthorizationBLLContext, TPersistentDomainObjectBase, Guid>, IAccessDeniedExceptionServiceContainer<TPersistentDomainObjectBase>
            where TPersistentDomainObjectBase : class, IIdentityObject<Guid>
            where TSecurityOperationCode : struct, Enum
    {
        return LazyInterfaceImplementHelper<ITargetSystemService>.CreateProxy(() =>
        {
            var targetSystem = this.lazyTargetSystems.Value.Single(filter);

            return ActivatorUtilities.CreateInstance<TargetSystemService<TBLLContext, TPersistentDomainObjectBase, TSecurityOperationCode>>(this.serviceProvider, targetSystem);
        });
    }
}
