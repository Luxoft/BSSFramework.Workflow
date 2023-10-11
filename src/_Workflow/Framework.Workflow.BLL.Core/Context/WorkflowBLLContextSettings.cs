using System;
using System.Linq;
using System.Collections.Generic;

using Framework.Core;
using Framework.DomainDriven.Tracking.LegacyValidators;
using Framework.Validation;
using Framework.Workflow.Domain;

using Microsoft.Extensions.DependencyInjection;

namespace Framework.Workflow.BLL;

public class WorkflowBLLContextSettings : IWorkflowBLLContextSettings
{
    public ITypeResolver<string> TypeResolver { get; init; } = TypeSource.FromSample<PersistentDomainObjectBase>().ToDefaultTypeResolver();

    public IValidator AnonymousObjectValidator { get; init; } =

        new Validator(new ValidationMap(new ServiceCollection()
                                        .AddSingleton<IPersistentDomainObjectBaseTypeResolver, PersistentDomainObjectBaseTypeResolver>()
                                        .AddSingleton<IAvailableValues>(AvailableValues.Infinity).BuildServiceProvider()).ToCompileCache());
}


public class PersistentDomainObjectBaseTypeResolver : IPersistentDomainObjectBaseTypeResolver
{
    public Type Resolve(Type identity)
    {
        return identity.GetAllElements(t => t.BaseType).Single(t => t.Name == nameof(PersistentDomainObjectBase));
    }

    public IEnumerable<Type> GetTypes() => throw new NotImplementedException();
}
