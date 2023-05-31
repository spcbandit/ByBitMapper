using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    /// <summary>
    /// Интервал свечей
    /// </summary>
    public enum IntervalType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "1")]
        OneMinute,
        [EnumMember(Value = "3")]
        ThreeMinute,
        [EnumMember(Value = "5")]
        FiveMinute,
        [EnumMember(Value = "15")]
        FifteenMinute,
        [EnumMember(Value = "30")]
        ThirtyMinute,
        [EnumMember(Value = "60")]
        OneHour,
        [EnumMember(Value = "120")]
        TwoHour,
        [EnumMember(Value = "240")]
        FourHour,
        [EnumMember(Value = "360")]
        SixHour,
        [EnumMember(Value = "720")]
        TwelveHours,
        [EnumMember(Value = "D")]
        OneDay,
        [EnumMember(Value = "M")]
        OneM,
        [EnumMember(Value = "W")]
        OneW,
    }
}
