using System;

using Framework.SecuritySystem;

namespace Framework.Workflow
{
    public static class WorkflowSecurityOperation
    {
        public static DisabledSecurityOperation Disabled { get; } = SecurityOperation.Disabled;

        public static SecurityOperation<Guid> WorkflowOpenModule { get; } = new(nameof(WorkflowOpenModule), new Guid("f0cce81f-d710-4456-a7ed-c8b181ba3443")) { Description = "Can open Workflow module", IsClient = true };

        public static SecurityOperation<Guid> WorkflowView { get; } = new(nameof(WorkflowView), new Guid("10ce7edf-45c3-4285-81fb-4399a5907890")) { Description = "Can view Workflow" };

        public static SecurityOperation<Guid> WorkflowEdit { get; } = new(nameof(WorkflowEdit), new Guid("3c84b2b4-40ce-4f37-9cd7-d4cc38e8c9c0")) { Description = "Can edit Workflow" };
    }
}
