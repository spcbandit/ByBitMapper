using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{

    public enum PublicEndpointType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "trade"), UsedImplicitly]
        Trade,
        [EnumMember(Value = "orderBookL2_25"), UsedImplicitly]
        OrderBookL2_25,
        [EnumMember(Value = "orderBook_200"), UsedImplicitly]
        OrderBook200,
        [EnumMember(Value = "insurance"), UsedImplicitly]
        Insurance,
        [EnumMember(Value = "instrument_info"), UsedImplicitly]
        InstrumentInfo,
        [EnumMember(Value = "klineV2"), UsedImplicitly]
        KlineV2
    }

}
