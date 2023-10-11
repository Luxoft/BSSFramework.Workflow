using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Framework.Authorization.Domain;



namespace Framework.Authorization.BLL
{
    public interface IWorkflowApproveProcessor
    {
        IEnumerable<string> GetPermissionFromPrincipalPath(Permission permission);

        IEnumerable<string> GetPermissionDefaultPath(Permission permission);

        IEnumerable<string> GetOperationDefaultPath(Operation operation);

        Expression<Func<Principal, IEnumerable<Permission>>> GetPermissionsByPrincipal();

        IEnumerable<ApproveOperationWorkflowObject> GetApproveOperationStartupObjects(Permission permission);

        bool CanAutoApprove(Permission permission, Operation approveOperation);

        void ExecuteApproveCommand(Permission permission, Operation approveOperation, ApproveCommand command);

        bool IsTerminate(Permission permission);

        StartupPermissionWorkflowObject Start(Permission permission);
    }
}
