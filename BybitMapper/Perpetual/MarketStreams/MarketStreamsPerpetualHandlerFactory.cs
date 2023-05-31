using BybitMapper.Handlers;
using BybitMapper.Perpetual.MarketStreams.Events;

namespace BybitMapper.Perpetual.MarketStreams
{
    /// <summary>
    /// Фабрика MarketStreams Perpetual
    /// </summary>
    public class MarketStreamsPerpetualHandlerFactory : IMarketStreamsPerpetualHandlerFactory
    {
        public ISingleMessageHandler<PDefaultEvent> CreateDefaultEvent() => new BaseJsonHandler<PDefaultEvent>();

        public ISingleMessageHandler<InstrumentInfoEvent> CreateInstrumentInfoEvent() => new BaseJsonHandler<InstrumentInfoEvent>();

        public ISingleMessageHandler<KlineEvent> CreateKlineEvent() => new BaseJsonHandler<KlineEvent>();

        public ISingleMessageHandler<LiquidationEvent> CreateLiquidationEvent() => new BaseJsonHandler<LiquidationEvent>();

        public ISingleMessageHandler<OrderBookL2Event> CreateOrderBookL2Event() => new BaseJsonHandler<OrderBookL2Event>();

        public ISingleMessageHandler<TradeEvent> CreateTradeEvent() => new BaseJsonHandler<TradeEvent>();

    }
}
