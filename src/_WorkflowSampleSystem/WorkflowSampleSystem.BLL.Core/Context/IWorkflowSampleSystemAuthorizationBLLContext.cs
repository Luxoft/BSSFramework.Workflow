using Framework.Authorization.BLL;
using Framework.Authorization.Domain;
using Framework.SecuritySystem;

namespace WorkflowSampleSystem.BLL;

public interface IWorkflowSampleSystemAuthorizationBLLContext : IAuthorizationBLLContext
{
    ISecurityProvider<Operation> GetOperationSecurityProvider();

    IWorkflowApproveProcessor WorkflowApproveProcessor { get; }
}
