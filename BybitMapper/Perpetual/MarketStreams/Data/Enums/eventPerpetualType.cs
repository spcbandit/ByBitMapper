using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Perpetual.MarketStreams.Data.Enums
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
        Kline,
        Liquidation,
        #endregion
        #region [Private Topics]
        Position,
        Execution,
        Order,
        StopOrder,
        Wallet
        #endregion
    }
}
