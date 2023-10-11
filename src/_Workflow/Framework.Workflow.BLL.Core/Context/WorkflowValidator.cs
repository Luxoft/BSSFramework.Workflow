using Framework.Validation;
using Microsoft.Extensions.DependencyInjection;

namespace Framework.Workflow.BLL;

public partial class WorkflowValidator : IWorkflowValidator
{
    [ActivatorUtilitiesConstructor]
    public WorkflowValidator(IWorkflowBLLContext context, WorkflowValidatorCompileCache cache) :
            this(context, (ValidatorCompileCache)cache)
    {
    }
}
