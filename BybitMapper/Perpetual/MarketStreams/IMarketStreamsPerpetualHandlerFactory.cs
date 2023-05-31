using BybitMapper.Handlers;
using BybitMapper.Perpetual.MarketStreams.Events;

using JetBrains.Annotations;

namespace BybitMapper.Perpetual.MarketStreams
{
    /// <summary>
    /// Интерфейс MarketStreams Perpetual
    /// </summary>
    public interface IMarketStreamsPerpetualHandlerFactory
    {
        [NotNull]
        ISingleMessageHandler<PDefaultEvent> CreateDefaultEvent();
        [NotNull]
        ISingleMessageHandler<InstrumentInfoEvent> CreateInstrumentInfoEvent();
        [NotNull]
        ISingleMessageHandler<KlineEvent> CreateKlineEvent();
        [NotNull]
        ISingleMessageHandler<LiquidationEvent> CreateLiquidationEvent();
        [NotNull]
        ISingleMessageHandler<OrderBookL2Event> CreateOrderBookL2Event();
        [NotNull]
        ISingleMessageHandler<TradeEvent> CreateTradeEvent();
    }
}
