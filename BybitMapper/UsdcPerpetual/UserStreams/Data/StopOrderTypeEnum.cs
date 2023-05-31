using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.UserStreams.Data
{
    public enum StopOrderTypeEnum
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "Stop")]
        Stop,
        [EnumMember(Value = "TakeProfit")]
        TakeProfit,
        [EnumMember(Value = "StopLoss")]
        StopLoss,
        [EnumMember(Value = "TrailingStop")]
        TrailingStop,
        [EnumMember(Value = "TrailingProfit")]
        TrailingProfit,
        [EnumMember(Value = "PartialTakeProfit")]
        PartialTakeProfit,
        [EnumMember(Value = "PartialStopLoss")]
        PartialStopLoss
    }
}