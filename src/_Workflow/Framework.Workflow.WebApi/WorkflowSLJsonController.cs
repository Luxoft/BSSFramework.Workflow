using System;

using Framework.Workflow.BLL;
using Framework.Workflow.Generated.DTO;
using Framework.DomainDriven.ServiceModel.Service;
using Framework.DomainDriven.WebApiNetCore;
using Framework.Graphviz;
using Framework.Graphviz.Dot;
using Framework.WebApi.Utils.SL;

using Microsoft.AspNetCore.Mvc;

namespace Framework.Workflow.WebApi
{
    [SLJsonCompatibilityActionFilter]
    [TypeFilter(typeof(SLJsonCompatibilityResourceFilter))]
    [ApiController]
    [Route("WorkflowSLJsonFacade.svc")]
    [ApiExplorerSettings(IgnoreApi = true)]
    //[Authorize(nameof(AuthenticationSchemes.NTLM))]
    public abstract partial class WorkflowSLJsonController : ApiControllerBase<IWorkflowBLLContext, EvaluatedData<IWorkflowBLLContext, IWorkflowDTOMappingService>>
    {
        private readonly IDotVisualizer<DotGraph> dotVisualizer;

        public WorkflowSLJsonController(IDotVisualizer<DotGraph> dotVisualizer)
        {
            this.dotVisualizer = dotVisualizer ?? throw new ArgumentNullException(nameof(dotVisualizer));
        }
    }
}
