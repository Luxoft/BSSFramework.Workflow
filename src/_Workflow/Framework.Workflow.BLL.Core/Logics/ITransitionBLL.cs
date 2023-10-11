

namespace Framework.Workflow.BLL
{
    public partial interface ITransitionBLL
    {
        void Recalculate(Domain.Definition.Transition transition);
    }
}
