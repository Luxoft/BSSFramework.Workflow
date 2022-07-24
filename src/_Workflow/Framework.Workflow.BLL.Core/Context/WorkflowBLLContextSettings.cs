using System;

using Framework.Core;
using Framework.Validation;
using Framework.Workflow.Domain;

namespace Framework.Workflow.BLL;

public class WorkflowBLLContextSettings : IWorkflowBLLContextSettings
{
    public ITypeResolver<string> TypeResolver { get; init; } = TypeSource.FromSample<PersistentDomainObjectBase>().ToDefaultTypeResolver();

    public IValidator AnonymousObjectValidator { get; init; } = new Validator(new ValidationMap(ValidationExtendedData.Infinity).ToCompileCache());
}
