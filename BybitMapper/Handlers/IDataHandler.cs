namespace BybitMapper.Handlers
{
    public interface IDataHandler<out T> : ISingleMessageHandler<T>, ISnapshotHandler<T>
    {
    }
}