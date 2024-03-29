﻿using Framework.DomainDriven.ServiceModel.Service;
using Framework.Graphviz;
using Framework.Workflow.BLL;

namespace Framework.DomainDriven.ServiceModel.IAD
{
    public interface IWorkflowServiceEnvironment : IServiceEnvironment<IWorkflowBLLContext>
    {
        IDotVisualizer<Graphviz.Dot.DotGraph> DotVisualizer { get; }
    }
}