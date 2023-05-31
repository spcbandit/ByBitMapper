
namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum
{
    /// <summary>
    /// Публичные и приватные свойства параметра topic WebSocket
    /// </summary>
    public enum EventPerpetualType
    {
        None,
        #region [Public Topics]
        OrderBook25,
        OrderBook200,
        Trade,
        InstrumentInfo,
        #endregion
        #region [Private Topics]
        Positions,
        Execution,
        Order
        #endregion
    }
}
