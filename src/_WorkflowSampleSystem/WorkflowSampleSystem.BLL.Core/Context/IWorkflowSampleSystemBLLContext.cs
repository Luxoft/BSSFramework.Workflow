﻿using System;

using Framework.Authorization.BLL;
using Framework.Core;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.BLL.Security;
using Framework.DomainDriven.BLL.Tracking;
using Framework.Workflow.BLL;

using WorkflowSampleSystem.Domain;

namespace WorkflowSampleSystem.BLL
{
    public partial interface IWorkflowSampleSystemBLLContext :

        ISecurityBLLContext<IAuthorizationBLLContext, PersistentDomainObjectBase, DomainObjectBase, Guid>,

        IWorkflowBLLContextContainer,

        ITrackingServiceContainer<PersistentDomainObjectBase>,

        ITypeResolverContainer<string>,

        Framework.DomainDriven.BLL.Configuration.IConfigurationBLLContextContainer<Framework.Configuration.BLL.IConfigurationBLLContext>,

        IDefaultHierarchicalBLLContext<PersistentDomainObjectBase, Guid>,

        ISecurityTypeResolverContainer
    {
    }
}
