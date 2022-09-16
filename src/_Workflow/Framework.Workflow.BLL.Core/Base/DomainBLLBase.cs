using System;

using Framework.Validation;
using Framework.Workflow.Domain;

namespace Framework.Workflow.BLL
{
    public partial class DomainBLLBase<TDomainObject, TOperation>
    {
        protected virtual void Validate(TDomainObject domainObject, WorkflowOperationContext context)
        {
            if (domainObject == null) throw new ArgumentNullException(nameof(domainObject));

            this.Context.Validator.Validate(domainObject, (int)context);
        }

        public override void Save(TDomainObject domainObject)
        {
            if (domainObject == null) throw new ArgumentNullException(nameof(domainObject));

            this.Validate(domainObject, WorkflowOperationContext.Save);

            base.Save(domainObject);
        }
    }
}
