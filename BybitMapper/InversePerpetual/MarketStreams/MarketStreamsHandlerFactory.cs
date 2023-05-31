using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.MarketStreams.Events;


namespace BybitMapper.InversePerpetual.MarketStreams
{
    public class MarketStreamsHandlerFactory : IMarketStreamsHandlerFactory
    {
        public ISingleMessageHandler<InsuranceEvent> CreateInsuranceEvent() => new BaseJsonHandler<InsuranceEvent>();
        public ISingleMessageHandler<KlineEvent> CreateKlineEvent() => new BaseJsonHandler<KlineEvent>();
        public ISingleMessageHandler<OrderBookL2Event> CreateOrderBookEvent() => new BaseJsonHandler<OrderBookL2Event>();
        public ISingleMessageHandler<TradeEvent> CreateTradeEvent() => new BaseJsonHandler<TradeEvent>();
        public ISingleMessageHandler<DefaultEvent> CreateDefaultEvent() => new BaseJsonHandler<DefaultEvent>();
        public ISingleMessageHandler<InstrumentInfoEvent> CreateInstrumentInfoEvent() => new BaseJsonHandler<InstrumentInfoEvent>();
    }
}
