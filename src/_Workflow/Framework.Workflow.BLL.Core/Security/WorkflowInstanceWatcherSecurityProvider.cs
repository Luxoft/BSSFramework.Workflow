using System;
using System.Linq;
using System.Linq.Expressions;

using Framework.Authorization.SecuritySystem;
using Framework.Core;
using Framework.SecuritySystem;
using Framework.Workflow.Domain;
using Framework.Workflow.Domain.Runtime;

namespace Framework.Workflow.BLL
{
    public class WorkflowInstanceWatcherSecurityProvider<TDomainObject> : SecurityProvider<TDomainObject>
        where TDomainObject : PersistentDomainObjectBase
    {
        private readonly IActualPrincipalSource actualPrincipalSource;

        private readonly Expression<Func<TDomainObject, WorkflowInstance>> path;


        public WorkflowInstanceWatcherSecurityProvider(IActualPrincipalSource actualPrincipalSource, Expression<Func<TDomainObject, WorkflowInstance>> path)
        {
            this.actualPrincipalSource = actualPrincipalSource;
            this.path = path ?? throw new ArgumentNullException(nameof(path));
        }

        public override Expression<Func<TDomainObject, bool>> SecurityFilter
        {
            get
            {
                return from workflowInstance in this.path

                       select workflowInstance.Watchers.Any(watcher => watcher.Login == this.actualPrincipalSource.ActualPrincipal.Name);
            }
        }


        public override UnboundedList<string> GetAccessors(TDomainObject domainObject)
        {
            var workflowInstance = this.path.Eval(domainObject, this.CompileCache);

            return workflowInstance.Watchers.Select(watcher => watcher.Login).ToUnboundedList();
        }
    }
}
