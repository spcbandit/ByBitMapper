using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.MarketStreams.Events;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams
{
    public class MarketStreamsHandlerComposition
    {
        [NotNull]
        private readonly IMarketStreamsHandlerFactory _factory;

        [NotNull]
        private readonly ISingleMessageHandler<InsuranceEvent> _insuranceEvent;
        [NotNull]
        private readonly ISingleMessageHandler<KlineEvent> _klineEvent;
        [NotNull]
        private readonly ISingleMessageHandler<OrderBookL2Event> _orderbookEvent;
        [NotNull]
        private readonly ISingleMessageHandler<TradeEvent> _tradeEvent;
        [NotNull]
        private readonly ISingleMessageHandler<DefaultEvent> _defaultEvent;
        [NotNull]
        private readonly ISingleMessageHandler<InstrumentInfoEvent> _instrumentInfoEvent;
        public MarketStreamsHandlerComposition([NotNull] IMarketStreamsHandlerFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _insuranceEvent = factory.CreateInsuranceEvent();
            _klineEvent = factory.CreateKlineEvent();
            _orderbookEvent = factory.CreateOrderBookEvent();
            _tradeEvent = factory.CreateTradeEvent();
            _defaultEvent = factory.CreateDefaultEvent();
            _instrumentInfoEvent = factory.CreateInstrumentInfoEvent();
        }

        public InsuranceEvent HandleInsuranceEvent(string message) => _insuranceEvent.HandleSingle(message);
        public KlineEvent HandleKlineEvent(string message) => _klineEvent.HandleSingle(message);
        public OrderBookL2Event HandleOrderBookEvent(string message) => _orderbookEvent.HandleSingle(message);
        public TradeEvent HandleTradeEvent(string message) => _tradeEvent.HandleSingle(message);
        public DefaultEvent HandleDefaultEvent(string message) => _defaultEvent.HandleSingle(message);
        public InstrumentInfoEvent HandleInstrumentInfoEvent(string message) => _instrumentInfoEvent.HandleSingle(message);
    }
}
