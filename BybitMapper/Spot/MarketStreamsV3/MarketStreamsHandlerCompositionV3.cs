using System;
using BybitMapper.Handlers;
using BybitMapper.Spot.MarketStreamsV3.Events;
using JetBrains.Annotations;

namespace BybitMapper.Spot.MarketStreamsV3
{
    public class MarketStreamsHandlerCompositionV3
    {
        [NotNull]
        private readonly IMarketStreamsHandlerFactoryV3 _factory;
        [NotNull]
        private readonly ISingleMessageHandler<DepthEvent> _depthEvent;
        [NotNull]
        private readonly ISingleMessageHandler<TradeEvent> _tradeEvent;
        [NotNull]
        private readonly ISingleMessageHandler<DefaultEvent> _defaultEvent;
        [NotNull]
        private readonly ISingleMessageHandler<TickerInfoEvent> _tickerInfoEvent;

        public MarketStreamsHandlerCompositionV3([NotNull] IMarketStreamsHandlerFactoryV3 factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _depthEvent = factory.CreateDepthEvent();
            _tradeEvent = factory.CreateTradeEvent();
            _defaultEvent = factory.CreateDefaultEvent();
            _tickerInfoEvent = factory.CreateTickerInfoEvent();
        }

        public DepthEvent HandleDepthEvent(string message) => _depthEvent.HandleSingle(message);
        public TradeEvent HandleTradeEvent(string message) => _tradeEvent.HandleSingle(message);
        public DefaultEvent HandleDefaultEvent(string message) => _defaultEvent.HandleSingle(message);
        public TickerInfoEvent HandleTickerInfoEvent(string message) => _tickerInfoEvent.HandleSingle(message);
    }
}
