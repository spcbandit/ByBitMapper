using BybitMapper.Handlers;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects;
using BybitMapper.UsdcPerpetual.MarketStreams.Events;

namespace BybitMapper.UsdcPerpetual.MarketStreams
{
    /// <summary>
    /// Фабрика MarketStreams Perpetual
    /// </summary>
    public class MarketStreamsUsdcPerpetualHandlerFactory : IMarketStreamsUsdcPerpetualHandlerFactory
    {
        public ISingleMessageHandler<PDefaultEvent> CreateDefaultEvent() => new BaseJsonHandler<PDefaultEvent>();

        public ISingleMessageHandler<OrderBookL2Event> CreateOrderBookL2Event() => new BaseJsonHandler<OrderBookL2Event>();

        public ISingleMessageHandler<TradeEvent> CreateTradeEvent() => new BaseJsonHandler<TradeEvent>();
        public ISingleMessageHandler<InstrumentInfoEvent> CreateInstrumentInfoEvent() => new BaseJsonHandler<InstrumentInfoEvent>();
    }
}
