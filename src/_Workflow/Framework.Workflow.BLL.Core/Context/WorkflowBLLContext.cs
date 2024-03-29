﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Framework.Authorization.BLL;
using Framework.Core;
using Framework.DomainDriven;
using Framework.DomainDriven.BLL;
using Framework.DomainDriven.BLL.Configuration;
using Framework.DomainDriven.BLL.Security;
using Framework.DomainDriven.Tracking;
using Framework.Exceptions;
using Framework.HierarchicalExpand;
using Framework.QueryLanguage;
using Framework.SecuritySystem;
using Framework.Validation;
using Framework.Workflow.Domain;
using Framework.Workflow.Domain.Definition;
using Framework.Workflow.Domain.Runtime;

namespace Framework.Workflow.BLL
{
    public partial class WorkflowBLLContext
    {
        private readonly Lazy<Dictionary<TargetSystem, ITargetSystemService>> lazyTargetSystemServiceCache;

        private readonly IDictionaryCache<StateBase, StateBase> stateBaseCache;

        private readonly IDictionaryCache<Event, Event> eventCache;

        private readonly IDictionaryCache<Type, DomainType> domainTypeCache;

        public WorkflowBLLContext(
            IServiceProvider serviceProvider,
            IOperationEventSenderContainer<PersistentDomainObjectBase> operationSenders,
            ITrackingService<PersistentDomainObjectBase> trackingServices,
            IAccessDeniedExceptionService accessDeniedExceptionService,
            IStandartExpressionBuilder standartExpressionBuilder,
            IWorkflowValidator validator,
            IHierarchicalObjectExpanderFactory<Guid> hierarchicalObjectExpanderFactory,
            IFetchService<PersistentDomainObjectBase, FetchBuildRule> fetchService,
            IConfigurationBLLContext configuration,
            IAuthorizationBLLContext authorization,
            IRootSecurityService<PersistentDomainObjectBase> securityService,
            IWorkflowBLLFactoryContainer logics,
            IExpressionParserFactory expressionParsers,
            IAnonymousTypeBuilder<TypeMap<ParameterizedTypeMapMember>> anonymousTypeBuilder,
            IEnumerable<ITargetSystemService> targetSystemServices,
            TimeProvider timeProvider,
            IWorkflowBLLContextSettings settings)

            : base(serviceProvider, operationSenders, trackingServices, accessDeniedExceptionService, standartExpressionBuilder, validator, hierarchicalObjectExpanderFactory, fetchService)
        {
            this.Logics = logics ?? throw new ArgumentNullException(nameof(logics));
            this.SecurityService = securityService ?? throw new ArgumentNullException(nameof(securityService));

            this.Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            this.Authorization = authorization ?? throw new ArgumentNullException(nameof(authorization));

            this.ExpressionParsers = expressionParsers ?? throw new ArgumentNullException(nameof(expressionParsers));

            this.AnonymousTypeBuilder = anonymousTypeBuilder ?? throw new ArgumentNullException(nameof(anonymousTypeBuilder));
            this.TimeProvider = timeProvider ?? throw new ArgumentNullException(nameof(timeProvider));
            this.lazyTargetSystemServiceCache = LazyHelper.Create(() => targetSystemServices.ToDictionary(s => s.TargetSystem, s => s));

            this.stateBaseCache = new WorkflowNestedCache<StateBase>(this).WithLock();
            this.eventCache = new WorkflowNestedCache<Event>(this).WithLock();
            this.domainTypeCache = new DictionaryCache<Type, DomainType>(domainObjectType => this.Logics.DomainType.GetByType(domainObjectType)).WithLock();

            this.AnonymousObjectValidator = settings.AnonymousObjectValidator;
        }


        public ITypeResolver<string> TypeResolver { get; } = TypeSource.FromSample<PersistentDomainObjectBase>().ToDefaultTypeResolver();


        public IAnonymousTypeBuilder<TypeMap<ParameterizedTypeMapMember>> AnonymousTypeBuilder { get; }

        public TimeProvider TimeProvider { get; }

        public IRootSecurityService<PersistentDomainObjectBase> SecurityService { get; }

        public IConfigurationBLLContext Configuration { get; }


        public IEnumerable<ITargetSystemService> GetTargetSystemServices()
        {
            return this.lazyTargetSystemServiceCache.Value.Values;
        }

        public StateBase GetNestedStateBase(StateBase stateBase)
        {
            if (stateBase == null) throw new ArgumentNullException(nameof(stateBase));

            return this.stateBaseCache[stateBase];
        }

        public Event GetNestedEvent(Event @event)
        {
            if (@event == null) throw new ArgumentNullException(nameof(@event));

            return this.eventCache[@event];
        }

        public DomainType GetDomainType(Type type)
        {
            return this.domainTypeCache[type];
        }

        public IValidator AnonymousObjectValidator { get; }



        public override IWorkflowBLLFactoryContainer Logics { get; }

        public IAuthorizationBLLContext Authorization { get; }

        public IExpressionParserFactory ExpressionParsers { get; }


        public ITargetSystemService GetTargetSystemService(TargetSystem targetSystem)
        {
            if (targetSystem == null) throw new ArgumentNullException(nameof(targetSystem));

            return this.lazyTargetSystemServiceCache.Value[targetSystem];
        }

        public ITargetSystemService GetTargetSystemService(string targetSystemName)
        {
            return this.lazyTargetSystemServiceCache.Value.Values.Single(service => service.TargetSystem.Name.Equals(targetSystemName, StringComparison.CurrentCultureIgnoreCase),
                () => new BusinessLogicException($"Target System with name {targetSystemName} not found"),
                () => new BusinessLogicException($"To many Target Systems with name {targetSystemName}"));
        }

        public ITargetSystemService GetTargetSystemService(Type domainType, bool throwOnNotFound)
        {
            if (domainType == null) throw new ArgumentNullException(nameof(domainType));

            if (throwOnNotFound)
            {
                return this.lazyTargetSystemServiceCache.Value.Values.Single(service => service.PersistentDomainObjectBaseType.IsAssignableFrom(domainType),
                    () => new BusinessLogicException($"Target System for type {domainType.Name} not found"),
                    () => new BusinessLogicException($"To many Target Systems for type {domainType.Name}"));
            }
            else
            {
                return this.lazyTargetSystemServiceCache.Value.Values.SingleOrDefault(service => service.PersistentDomainObjectBaseType.IsAssignableFrom(domainType),
                    () => new BusinessLogicException($"Target System for type {domainType.Name} not found"));
            }
        }

        public ISecurityProvider<TDomainObject> GetWatcherSecurityProvider<TDomainObject>(Expression<Func<TDomainObject, WorkflowInstance>> path)
                where TDomainObject : PersistentDomainObjectBase
        {
            if (path == null) throw new ArgumentNullException(nameof(path));

            return new WorkflowInstanceWatcherSecurityProvider<TDomainObject>(this.Authorization.ActualPrincipalSource, path);
        }
    }
}
