using Framework.Core;
using Framework.Validation;

namespace Framework.Workflow.BLL;

public interface IWorkflowBLLContextSettings : ITypeResolverContainer<string>
{
    public IValidator AnonymousObjectValidator { get; }
}
