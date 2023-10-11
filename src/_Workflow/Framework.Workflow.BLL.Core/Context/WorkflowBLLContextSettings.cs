using Framework.Core;
using Framework.Validation;
using Framework.Workflow.Domain;

using Microsoft.Extensions.DependencyInjection;

namespace Framework.Workflow.BLL;

public class WorkflowBLLContextSettings : IWorkflowBLLContextSettings
{
    public ITypeResolver<string> TypeResolver { get; init; } = TypeSource.FromSample<PersistentDomainObjectBase>().ToDefaultTypeResolver();

    public IValidator AnonymousObjectValidator { get; init; } = new Validator(new ValidationMap(new ServiceCollection().BuildServiceProvider()).ToCompileCache());
}
