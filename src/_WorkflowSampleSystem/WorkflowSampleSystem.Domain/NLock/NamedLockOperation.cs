using Framework.DomainDriven.Lock;

namespace WorkflowSampleSystem.Domain
{
    public enum NamedLockOperation
    {
        [GlobalLock(typeof(BusinessUnitAncestorLink))]
        BusinessUnitAncestorLock,
    }
}
