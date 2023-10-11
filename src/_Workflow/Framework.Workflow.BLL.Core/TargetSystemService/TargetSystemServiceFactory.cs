using System;
using System.Collections.Generic;
using System.Linq;

using Framework.Authorization.BLL;
using Framework.Core;
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

    public ITargetSystemService Create<TBLLContext, TPersistentDomainObjectBase>(string name, IEnumerable<Type> workflowSourceTypes)
            where TBLLContext : class, ISecurityServiceContainer<IRootSecurityService<TPersistentDomainObjectBase>>,
                                       ISecurityBLLContext<IAuthorizationBLLContext, TPersistentDomainObjectBase, Guid>,
                                       ITypeResolverContainer<string>

            where TPersistentDomainObjectBase : class, IIdentityObject<Guid>
    {
        return this.Create<TBLLContext, TPersistentDomainObjectBase>(tss => tss.Name == name, workflowSourceTypes);
    }

    public ITargetSystemService Create<TBLLContext, TPersistentDomainObjectBase>(Func<TargetSystem, bool> filter, IEnumerable<Type> workflowSourceTypes)

            where TBLLContext : class, ISecurityServiceContainer<IRootSecurityService<TPersistentDomainObjectBase>>,
                                       ISecurityBLLContext<IAuthorizationBLLContext, TPersistentDomainObjectBase, Guid>,
                                       ITypeResolverContainer<string>

            where TPersistentDomainObjectBase : class, IIdentityObject<Guid>
    {
        return LazyInterfaceImplementHelper<ITargetSystemService>.CreateProxy(() =>
        {
            var targetSystem = this.lazyTargetSystems.Value.Single(filter);

            return ActivatorUtilities.CreateInstance<TargetSystemService<TBLLContext, TPersistentDomainObjectBase>>(this.serviceProvider, targetSystem, workflowSourceTypes);
        });
    }
}
