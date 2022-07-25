using Framework.Graphviz;
using Framework.Graphviz.Dot;

using JetBrains.Annotations;

namespace WorkflowSampleSystem.WebApiCore.Controllers
{
    public class WorkflowSLJsonController : Framework.Workflow.WebApi.WorkflowSLJsonController
    {
        public WorkflowSLJsonController([NotNull] IDotVisualizer<DotGraph> dotVisualizer)
                : base(dotVisualizer)
        {
        }
    }
}
