using System.Collections.Generic;

namespace BybitMapper.Handlers
{
    public interface ISnapshotHandler<out T>
    {
        IReadOnlyList<T> HandleSnapshot(string message);
    }
}