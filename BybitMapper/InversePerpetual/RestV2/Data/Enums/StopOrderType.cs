using System.Runtime.Serialization;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum StopOrderType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "TakeProfit")]
        TakeProfit,
        [EnumMember(Value = "StopLoss")]
        StopLoss,
        [EnumMember(Value = "TrailingStop")]
        TrailingStop,
        [EnumMember(Value = "Stop")]
        Stop
    }
}