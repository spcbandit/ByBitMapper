using BybitMapper.Handlers;
using BybitMapper.Spot.MarketStreamsV3.Events;

namespace BybitMapper.Spot.MarketStreamsV3
{
    public class MarketStreamsHandlerFactoryV3 : IMarketStreamsHandlerFactoryV3
    {
        public ISingleMessageHandler<DepthEvent> CreateDepthEvent() => new BaseJsonHandler<DepthEvent>();
        public ISingleMessageHandler<TradeEvent> CreateTradeEvent() => new BaseJsonHandler<TradeEvent>();
        public ISingleMessageHandler<DefaultEvent> CreateDefaultEvent() => new BaseJsonHandler<DefaultEvent>();
        public ISingleMessageHandler<TickerInfoEvent> CreateTickerInfoEvent() => new BaseJsonHandler<TickerInfoEvent>();
    }
}
