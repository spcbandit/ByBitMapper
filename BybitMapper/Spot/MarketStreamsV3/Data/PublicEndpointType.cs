using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace BybitMapper.Spot.MarketStreamsV3.Data
{
    /// <summary>
    /// Название подписки
    /// </summary>
    public enum PublicEndpointType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "tickers"), UsedImplicitly]
        Tickers,
        [EnumMember(Value = "orderbook.80"), UsedImplicitly]
        Depth,
        [EnumMember(Value = "trade"), UsedImplicitly]
        Trade,
        [EnumMember(Value = "kline"), UsedImplicitly]
        Kline,
        [EnumMember(Value = "bookTicker"), UsedImplicitly]
        BookTicker
    }
}
