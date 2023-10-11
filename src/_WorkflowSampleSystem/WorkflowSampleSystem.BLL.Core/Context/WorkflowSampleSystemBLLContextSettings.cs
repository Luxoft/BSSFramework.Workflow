using Framework.Core;

using WorkflowSampleSystem.Domain;

namespace WorkflowSampleSystem.BLL;

public class WorkflowSampleSystemBLLContextSettings : IWorkflowSampleSystemBLLContextSettings
{
    public ITypeResolver<string> TypeResolver { get; init; } = TypeSource.FromSample<PersistentDomainObjectBase>().ToDefaultTypeResolver();
}
