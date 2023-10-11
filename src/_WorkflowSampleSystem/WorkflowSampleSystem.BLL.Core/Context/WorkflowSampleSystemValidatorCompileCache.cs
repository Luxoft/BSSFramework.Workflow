using Framework.Validation;

namespace WorkflowSampleSystem.BLL;

public class WorkflowSampleSystemValidatorCompileCache : ValidatorCompileCache
{
    public WorkflowSampleSystemValidatorCompileCache(WorkflowSampleSystemValidationMap validationMap)
            : base(validationMap)
    {
    }
}
