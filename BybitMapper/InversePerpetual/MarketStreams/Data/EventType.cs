
namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
    /// <summary>
    /// Тип эвента
    /// </summary>
    public enum EventType
    {
        None,
        InstrumentInfo,
        Insurance,
        Kline,
        OrderBook25,
        OrderBook200,
        Trade,
        Position,
        Execution,
        Order,
        StopOrder
    }
}
