using BybitMapper.Handlers;
using BybitMapper.Spot.MarketStreams.Events;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams
{
    public class MarketStreamsHandlerComposition
    {
        [NotNull]
        private readonly IMarketStreamsHandlerFactory _factory;
        [NotNull]
        private readonly ISingleMessageHandler<DepthEvent> _depthEvent;
        [NotNull]
        private readonly ISingleMessageHandler<TradeEvent> _tradeEvent;
        [NotNull]
        private readonly ISingleMessageHandler<DefaultEvent> _defaultEvent;
        [NotNull]
        private readonly ISingleMessageHandler<InstrumentInfoEvent> _instrumentInfoEvent;

        public MarketStreamsHandlerComposition([NotNull] IMarketStreamsHandlerFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _depthEvent = factory.CreateDepthEvent();
            _tradeEvent = factory.CreateTradeEvent();
            _defaultEvent = factory.CreateDefaultEvent();
            _instrumentInfoEvent = factory.CreateInstrumentInfoEvent();
        }

        public DepthEvent HandleDepthEvent(string message) => _depthEvent.HandleSingle(message);
        public TradeEvent HandleTradeEvent(string message) => _tradeEvent.HandleSingle(message);
        public DefaultEvent HandleDefaultEvent(string message) => _defaultEvent.HandleSingle(message);
        public InstrumentInfoEvent HandleInstrumentInfoEvent(string message) => _instrumentInfoEvent.HandleSingle(message);
    }
}
