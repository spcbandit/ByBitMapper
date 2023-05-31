using BybitMapper.Handlers;
using BybitMapper.Perpetual.MarketStreams.Events;

using JetBrains.Annotations;

using System;

namespace BybitMapper.Perpetual.MarketStreams
{
    public class MarketStreamsPerpetualHandlerComposition
    {
        [NotNull]
        private readonly IMarketStreamsPerpetualHandlerFactory _factory;

        [NotNull]
        private readonly ISingleMessageHandler<PDefaultEvent> _defaultEvent;
        [NotNull]
        private readonly ISingleMessageHandler<InstrumentInfoEvent> _instrumentInfoEvent;
        [NotNull]
        private readonly ISingleMessageHandler<KlineEvent> _klineEvent;
        [NotNull]
        private readonly ISingleMessageHandler<LiquidationEvent> _liquidationEvent;
        [NotNull]
        private readonly ISingleMessageHandler<OrderBookL2Event> _orderBookL2Event;
        [NotNull]
        private readonly ISingleMessageHandler<TradeEvent> _tradeEvent;
        public MarketStreamsPerpetualHandlerComposition([NotNull] IMarketStreamsPerpetualHandlerFactory factory)
        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));

            _defaultEvent = factory.CreateDefaultEvent();
            _instrumentInfoEvent = factory.CreateInstrumentInfoEvent();
            _klineEvent = factory.CreateKlineEvent();
            _liquidationEvent = factory.CreateLiquidationEvent();
            _orderBookL2Event = factory.CreateOrderBookL2Event();
            _tradeEvent = factory.CreateTradeEvent();
        }

        /// <summary>
        /// полный ответ на запрос
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public PDefaultEvent HandleDefaultEvent(string message) => _defaultEvent.HandleSingle(message);
        public InstrumentInfoEvent HandleInstrumentInfoEvent(string message) => _instrumentInfoEvent.HandleSingle(message);
        public KlineEvent HandleKlineEvent(string message) => _klineEvent.HandleSingle(message);
        public LiquidationEvent HandleLiquidationEvent(string message) => _liquidationEvent.HandleSingle(message);
        public OrderBookL2Event HandleOrderBookL2Event(string message) => _orderBookL2Event.HandleSingle(message);
        public TradeEvent HandleTradeEvent(string message) => _tradeEvent.HandleSingle(message);
    }
}
