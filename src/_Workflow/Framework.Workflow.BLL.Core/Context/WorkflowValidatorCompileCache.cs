using System;

using Framework.Core;
using Framework.Validation;

using Framework.DomainDriven.BLL;

namespace Framework.Workflow.BLL;

public class WorkflowValidatorCompileCache : ValidatorCompileCache
{
    public WorkflowValidatorCompileCache(IAvailableValues availableValues) :
            base(availableValues
                 .ToBLLContextValidationExtendedData<IWorkflowBLLContext, Framework.Workflow.Domain.PersistentDomainObjectBase, Guid>()
                 .Pipe(extendedValidationData => new WorkflowValidationMap(extendedValidationData)))
    {
    }
}
