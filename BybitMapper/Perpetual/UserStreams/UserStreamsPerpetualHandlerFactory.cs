using BybitMapper.Handlers;
using BybitMapper.Perpetual.UserStreams.Events;

namespace BybitMapper.Perpetual.UserStreams
{
    public sealed class UserStreamsPerpetualHandlerFactory : IUserStreamsPerpetualHandlerFactory
    {
        public ISingleMessageHandler<ExecutionPerpetualEvent> CreateExecutionPerpetualEvent() => new BaseJsonHandler<ExecutionPerpetualEvent>();
        public ISingleMessageHandler<OrderPerpetualEvent> CreateOrderPerpetualEvent() => new BaseJsonHandler<OrderPerpetualEvent>();
        public ISingleMessageHandler<PositionPerpetualEvent> CreatePositionPerpetualEvent() => new BaseJsonHandler<PositionPerpetualEvent>();
        public ISingleMessageHandler<StopOrderPerpetualEvent> CreateStopOrderPerpetualEvent() => new BaseJsonHandler<StopOrderPerpetualEvent>();
        public ISingleMessageHandler<WalletPerpetualEvent> CreateWalletPerpetualEvent() => new BaseJsonHandler<WalletPerpetualEvent>();
    }
}
