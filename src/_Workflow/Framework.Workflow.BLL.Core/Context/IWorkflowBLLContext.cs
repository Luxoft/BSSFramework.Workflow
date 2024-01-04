using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Framework.Core;
using Framework.DomainDriven.BLL.Configuration;

using Framework.Authorization.BLL;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL.Security;
using Framework.DomainDriven.Tracking;
using Framework.SecuritySystem;
using Framework.Validation;
using Framework.Workflow.Domain;
using Framework.Workflow.Domain.Definition;
using Framework.Workflow.Domain.Runtime;

namespace Framework.Workflow.BLL
{
    public partial interface IWorkflowBLLContext :

        ISecurityBLLContext<IAuthorizationBLLContext, PersistentDomainObjectBase, Guid>,

        ITrackingServiceContainer<PersistentDomainObjectBase>,

        IIAnonymousTypeBuilderContainer<TypeMap<ParameterizedTypeMapMember>>,

        ITypeResolverContainer<string>,

        IConfigurationBLLContextContainer<IConfigurationBLLContext>
    {
        IExpressionParserFactory ExpressionParsers { get; }

        IValidator AnonymousObjectValidator { get; }

        TimeProvider TimeProvider { get; }


        ITargetSystemService GetTargetSystemService(Type domainType, bool throwOnNotFound);

        ITargetSystemService GetTargetSystemService(TargetSystem targetSystem);

        ITargetSystemService GetTargetSystemService(string targetSystemName);


        IEnumerable<ITargetSystemService> GetTargetSystemServices();



        StateBase GetNestedStateBase(StateBase stateBase);

        Event GetNestedEvent(Event @event);

        DomainType GetDomainType(Type type);

        ISecurityProvider<TDomainObject> GetWatcherSecurityProvider<TDomainObject>(Expression<Func<TDomainObject, WorkflowInstance>> path)
                where TDomainObject : PersistentDomainObjectBase;
    }
}
