using Framework.Validation;

namespace Framework.Workflow.BLL;

public class WorkflowValidatorCompileCache : ValidatorCompileCache
{
    public WorkflowValidatorCompileCache(WorkflowValidationMap validationMap)
            : base(validationMap)
    {
    }
}
