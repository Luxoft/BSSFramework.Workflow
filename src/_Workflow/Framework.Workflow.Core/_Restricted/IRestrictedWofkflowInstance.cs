using Framework.Workflow.Core;

namespace Framework.Workflow
{
    public interface IRestrictedWofkflowInstance
    {
        bool IsFinished { get; }

        bool IsAborted { get; }


        string Name { get; }

        IRestrictedStateInstance CurrentState { get; }

        INamedCollection<string> Parameters { get; }
    }
}
