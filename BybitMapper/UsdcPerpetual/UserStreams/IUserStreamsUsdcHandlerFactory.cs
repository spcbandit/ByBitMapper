using BybitMapper.Handlers;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects;

using JetBrains.Annotations;

namespace BybitMapper.UsdcPerpetual.UserStreams
{
    /// <summary>
    /// Интерфейс USDT Perpetual WebSocket Private
    /// </summary>
    public interface IUserStreamsUsdcHandlerFactory
    {
        [NotNull]
        ISingleMessageHandler<ExecutionEvent> CreateExecutionUsdcEvent();
        [NotNull]
        ISingleMessageHandler<OrderEvent> CreateOrderUsdcEvent();
        [NotNull]
        ISingleMessageHandler<PositionEvent> CreatePositionUsdcEvent();
    }
}
