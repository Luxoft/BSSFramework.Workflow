#nullable enable

using System.Collections.Generic;
using System.Data;

using Framework.Cap.Abstractions;
using Framework.DomainDriven.NHibernate;
using Framework.DomainDriven.NHibernate.Audit;

namespace WorkflowSampleSystem.WebApiCore.Env.Database;

public class WorkflowSampleSystemNHibSessionEnvironment : NHibSessionEnvironment
{
    private readonly ICapTransactionManager manager;

    public WorkflowSampleSystemNHibSessionEnvironment(
            NHibConnectionSettings connectionSettings,
            IEnumerable<IMappingSettings> mappingSettings,
            IAuditRevisionUserAuthenticationService auditRevisionUserAuthenticationService,
            ICapTransactionManager manager,
            INHibSessionEnvironmentSettings settings)
            : base(connectionSettings, mappingSettings, auditRevisionUserAuthenticationService, settings) =>
            this.manager = manager;

    public override void ProcessTransaction(IDbTransaction dbTransaction)
    {
        base.ProcessTransaction(dbTransaction);
        this.manager.Enlist(dbTransaction);
    }
}
