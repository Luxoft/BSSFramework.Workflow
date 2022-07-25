using System;

using Framework.Core;
using Framework.Validation;

using Framework.DomainDriven.BLL;

namespace WorkflowSampleSystem.BLL;

public class WorkflowSampleSystemValidatorCompileCache : ValidatorCompileCache
{
    public WorkflowSampleSystemValidatorCompileCache(IAvailableValues availableValues) :
            base(availableValues
                 .ToBLLContextValidationExtendedData<IWorkflowSampleSystemBLLContext, WorkflowSampleSystem.Domain.PersistentDomainObjectBase, Guid>()
                 .Pipe(extendedValidationData => new WorkflowSampleSystemValidationMap(extendedValidationData)))
    {
    }
}
