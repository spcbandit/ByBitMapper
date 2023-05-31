using BybitMapper.Handlers;
using BybitMapper.Spot.MarketStreams.Events;

namespace BybitMapper.Spot.MarketStreams
{
    public class MarketStreamsHandlerFactory : IMarketStreamsHandlerFactory
    {
        public ISingleMessageHandler<DepthEvent> CreateDepthEvent() => new BaseJsonHandler<DepthEvent>();
        public ISingleMessageHandler<TradeEvent> CreateTradeEvent() => new BaseJsonHandler<TradeEvent>();
        public ISingleMessageHandler<DefaultEvent> CreateDefaultEvent() => new BaseJsonHandler<DefaultEvent>();
        public ISingleMessageHandler<InstrumentInfoEvent> CreateInstrumentInfoEvent() => new BaseJsonHandler<InstrumentInfoEvent>();
    }
}
