using Framework.Graphviz;
using Framework.Graphviz.Dot;



namespace WorkflowSampleSystem.WebApiCore.Controllers
{
    public class WorkflowSLJsonController : Framework.Workflow.WebApi.WorkflowSLJsonController
    {
        public WorkflowSLJsonController(IDotVisualizer<DotGraph> dotVisualizer)
                : base(dotVisualizer)
        {
        }
    }
}
