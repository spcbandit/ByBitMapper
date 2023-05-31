using BybitMapper.Handlers;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects;
using BybitMapper.UsdcPerpetual.MarketStreams.Events;

using JetBrains.Annotations;

namespace BybitMapper.UsdcPerpetual.MarketStreams
{
    /// <summary>
    /// Интерфейс MarketStreams Perpetual
    /// </summary>
    public interface IMarketStreamsUsdcPerpetualHandlerFactory
    {
        [NotNull]
        ISingleMessageHandler<PDefaultEvent> CreateDefaultEvent();
        [NotNull]
        ISingleMessageHandler<OrderBookL2Event> CreateOrderBookL2Event();
        [NotNull]
        ISingleMessageHandler<TradeEvent> CreateTradeEvent();
        [NotNull]
        ISingleMessageHandler<InstrumentInfoEvent> CreateInstrumentInfoEvent();
    }
}
