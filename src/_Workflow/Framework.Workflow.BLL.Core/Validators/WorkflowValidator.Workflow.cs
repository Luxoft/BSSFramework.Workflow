using System;

using Framework.Validation;
using Framework.Workflow.Domain;



namespace Framework.Workflow.BLL
{
    public partial class WorkflowValidator
    {
        protected override ValidationResult GetWorkflowValidationResult(Domain.Definition.Workflow source, WorkflowOperationContext operationContext, IValidationState ownerState)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            return base.GetWorkflowValidationResult(source, operationContext, ownerState);
        }
    }
}
