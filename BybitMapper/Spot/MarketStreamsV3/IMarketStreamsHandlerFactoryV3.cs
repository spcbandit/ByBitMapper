using BybitMapper.Handlers;
using BybitMapper.Spot.MarketStreamsV3.Events;
using JetBrains.Annotations;

namespace BybitMapper.Spot.MarketStreamsV3
{
    public interface IMarketStreamsHandlerFactoryV3
    {
        [NotNull]
        ISingleMessageHandler<DepthEvent> CreateDepthEvent();
        [NotNull]
        ISingleMessageHandler<TradeEvent> CreateTradeEvent();
        [NotNull]
        ISingleMessageHandler<DefaultEvent> CreateDefaultEvent();
        [NotNull]
        ISingleMessageHandler<TickerInfoEvent> CreateTickerInfoEvent();
    }
}
