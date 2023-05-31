using BybitMapper.Handlers;
using BybitMapper.Perpetual.UserStreams.Events;

using JetBrains.Annotations;

namespace BybitMapper.Perpetual.UserStreams
{
    /// <summary>
    /// Интерфейс USDT Perpetual WebSocket Private
    /// </summary>
    public interface IUserStreamsPerpetualHandlerFactory
    {
        [NotNull]
        ISingleMessageHandler<ExecutionPerpetualEvent> CreateExecutionPerpetualEvent();
        [NotNull]
        ISingleMessageHandler<OrderPerpetualEvent> CreateOrderPerpetualEvent();
        [NotNull]
        ISingleMessageHandler<PositionPerpetualEvent> CreatePositionPerpetualEvent();
        [NotNull]
        ISingleMessageHandler<StopOrderPerpetualEvent> CreateStopOrderPerpetualEvent();
        [NotNull]
        ISingleMessageHandler<WalletPerpetualEvent> CreateWalletPerpetualEvent();
        
    }
}
