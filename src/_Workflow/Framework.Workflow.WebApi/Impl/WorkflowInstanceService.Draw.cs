﻿using System.IO;

using Framework.DomainDriven;
using Framework.SecuritySystem;
using Framework.Workflow.Core.Extensions;
using Framework.Workflow.Generated.DTO;
using Framework.Workflow.Graphviz;

using Microsoft.AspNetCore.Mvc;

namespace Framework.Workflow.WebApi
{
    public partial class WorkflowSLJsonController
    {
        [Microsoft.AspNetCore.Mvc.HttpPost(nameof(DrawWorkflowInstance))]
        public Stream DrawWorkflowInstance([FromForm] DrawWorkflowInstanceRequest request)
        {
            return this.DrawWorkflowInstanceInternal(request).ToMemoryStream();
        }

        private byte[] DrawWorkflowInstanceInternal([FromForm] DrawWorkflowInstanceRequest request)
        {
            return this.EvaluateC(DBSessionMode.Read, context =>
            {
                var workflowInstance = context.Logics.WorkflowInstanceFactory.Create(BLLSecurityMode.View).GetById(request.WorkflowInstance.Id);

                var graph = workflowInstance.GetDotGraph(request.Dpi);

                return this.dotVisualizer.Render(graph, request.Format);
            });
        }
    }
}
