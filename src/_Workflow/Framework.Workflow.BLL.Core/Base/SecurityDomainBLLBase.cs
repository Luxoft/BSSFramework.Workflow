using System;

using Framework.Validation;
using Framework.Workflow.Domain;

namespace Framework.Workflow.BLL
{
    public partial class SecurityDomainBLLBase<TDomainObject, TOperation>
    {
        protected virtual ValidationResult GetValidationResult(TDomainObject domainObject, WorkflowOperationContext context)
        {
            if (domainObject == null) throw new ArgumentNullException(nameof(domainObject));

            return this.Context.Validator.GetValidationResult(domainObject, (int)context);
        }

        protected virtual void Validate(TDomainObject domainObject, WorkflowOperationContext context)
        {
            if (domainObject == null) throw new ArgumentNullException(nameof(domainObject));

            this.GetValidationResult(domainObject, context).TryThrow();
        }

        public override void Save(TDomainObject domainObject)
        {
            if (domainObject == null) throw new ArgumentNullException(nameof(domainObject));

            this.Validate(domainObject, WorkflowOperationContext.Save);

            base.Save(domainObject);
        }
    }
}
