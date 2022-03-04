﻿using System;
using System.Runtime.Serialization;
using Framework.DomainDriven.ServiceModel.IAD;
using Framework.Graphviz;

namespace Framework.Workflow.Generated.DTO
{
    [AutoRequest]
    [DataContract(Namespace = "Workflow")]
    public class DrawWorkflowInstanceRequest
    {
        [DataMember]
        [AutoRequestProperty(OrderIndex = 0)]
        public WorkflowInstanceIdentityDTO WorkflowInstance { get; set; }

        [DataMember]
        [AutoRequestProperty(OrderIndex = 1)]
        public GraphvizFormat Format { get; set; }

        [DataMember]
        [AutoRequestProperty(OrderIndex = 2)]
        public int? Dpi { get; set; }
    }
}
