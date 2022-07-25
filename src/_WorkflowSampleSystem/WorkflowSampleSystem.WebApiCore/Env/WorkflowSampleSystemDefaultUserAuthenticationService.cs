using Framework.Core.Services;
using Framework.DomainDriven.NHibernate.Audit;

using Microsoft.AspNetCore.Http;

namespace WorkflowSampleSystem.WebApiCore.Env
{
    public class WorkflowSampleSystemDefaultUserAuthenticationService : DomainDefaultUserAuthenticationService, IAuditRevisionUserAuthenticationService
    {

        private readonly IHttpContextAccessor httpContextAccessor;

        public WorkflowSampleSystemDefaultUserAuthenticationService(IHttpContextAccessor httpContextAccessor) => this.httpContextAccessor = httpContextAccessor;

        public override string GetUserName() => this.httpContextAccessor.HttpContext?.User?.Identity?.Name ?? base.GetUserName();
    }
}
