using BybitMapper.Handlers;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects;
using BybitMapper.UsdcPerpetual.MarketStreams.Events;

using JetBrains.Annotations;

namespace BybitMapper.UsdcPerpetual.MarketStreams
{
    public class MarketStreamsUsdcPerpetualHandlerComposition
    {
        [NotNull]
        private readonly ISingleMessageHandler<PDefaultEvent> _defaultEvent;
        [NotNull]
        private readonly ISingleMessageHandler<OrderBookL2Event> _orderBookL2Event;
        [NotNull]
        private readonly ISingleMessageHandler<TradeEvent> _tradeEvent;
        [NotNull]
        private readonly ISingleMessageHandler<InstrumentInfoEvent> _instrumentInfoEvent;
        public MarketStreamsUsdcPerpetualHandlerComposition([NotNull] IMarketStreamsUsdcPerpetualHandlerFactory factory)
        {
            _defaultEvent = factory.CreateDefaultEvent();
            _orderBookL2Event = factory.CreateOrderBookL2Event();
            _tradeEvent = factory.CreateTradeEvent();
            _instrumentInfoEvent = factory.CreateInstrumentInfoEvent();
        }

        /// <summary>
        /// полный ответ на запрос
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public PDefaultEvent HandleDefaultEvent(string message) => _defaultEvent.HandleSingle(message);
        public OrderBookL2Event HandleOrderBookL2Event(string message) => _orderBookL2Event.HandleSingle(message);
        public TradeEvent HandleTradeEvent(string message) => _tradeEvent.HandleSingle(message);
        public InstrumentInfoEvent HandleInstrumentInfoEvent(string message) => _instrumentInfoEvent.HandleSingle(message);
    }
}
