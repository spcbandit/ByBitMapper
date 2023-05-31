using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum
{
    public enum PublicEndpointType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "trade")]
        Trade,
        [EnumMember(Value = "orderBookL2_25")]
        OrderBookL2_25,
        [EnumMember(Value = "orderBook_200")]
        OrderBook200,
        [EnumMember(Value = "instrument_info")]
        InstrumentInfo
    }
}
