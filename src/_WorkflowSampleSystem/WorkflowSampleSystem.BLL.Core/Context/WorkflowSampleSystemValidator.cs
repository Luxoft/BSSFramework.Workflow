using Framework.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace WorkflowSampleSystem.BLL;

public partial class WorkflowSampleSystemValidator : IWorkflowSampleSystemValidator
{
    [ActivatorUtilitiesConstructor]
    public WorkflowSampleSystemValidator(IWorkflowSampleSystemBLLContext context, WorkflowSampleSystemValidatorCompileCache cache) :
            this(context, (ValidatorCompileCache)cache)
    {
    }
}
