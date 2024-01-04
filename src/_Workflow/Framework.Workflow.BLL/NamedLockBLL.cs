using System;
using System.Linq;
using Framework.Core;
using Framework.DomainDriven;
using Framework.Workflow.Domain;

namespace Framework.Workflow.BLL
{
    public partial class NamedLockBLL
    {
        public void CheckInit()
        {
            var actualValues = Enum.GetValues(typeof(NamedLockOperation)).Cast<NamedLockOperation>();
            var expectedValues = this.GetFullList();

            var mergeResult = expectedValues.GetMergeResult(actualValues, z => (int)z.LockOperation, z => (int)z);

            mergeResult.AddingItems.Select(z => new NamedLock() { LockOperation = z }).Foreach(this.Save);
            mergeResult.RemovingItems.Foreach(this.Remove);
        }

        public void Lock(NamedLockOperation lockOperation)
        {
            var namedLock = this.GetObjectBy(z => z.LockOperation == lockOperation);

            base.Lock(namedLock, LockRole.Update);
        }
    }
}
