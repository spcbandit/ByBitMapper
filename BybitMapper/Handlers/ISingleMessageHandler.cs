namespace BybitMapper.Handlers
{
    public interface ISingleMessageHandler<out T>
    {
        T HandleSingle(string message);
    }
}