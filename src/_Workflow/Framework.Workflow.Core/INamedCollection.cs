using System.Collections.Generic;

namespace Framework.Workflow.Core;

public interface INamedCollection<out T> : IEnumerable<T>
{
    T this[string name] { get; }
}
