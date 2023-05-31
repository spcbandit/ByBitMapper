using JetBrains.Annotations;
using System.Runtime.Serialization;


namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    /// <summary>
    /// 1-720
    /// </summary>
    public enum IntervalType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "1"), UsedImplicitly]
        OneMinute,
        [EnumMember(Value = "3"), UsedImplicitly]
        ThreeMinute,
        [EnumMember(Value = "5"), UsedImplicitly]
        FiveMinute,
        [EnumMember(Value = "15"), UsedImplicitly]
        FifteenMinute,
        [EnumMember(Value = "30"), UsedImplicitly]
        ThirtyMinute,
        [EnumMember(Value = "60"), UsedImplicitly]
        OneHour,
        [EnumMember(Value = "120"), UsedImplicitly]
        TwoHour,
        [EnumMember(Value = "240"), UsedImplicitly]
        FourHour,
        [EnumMember(Value = "360"), UsedImplicitly]
        SixHour,
        [EnumMember(Value = "720"), UsedImplicitly]
        TwelveHours,
        [EnumMember(Value = "D"), UsedImplicitly]
        OneDay,
        [EnumMember(Value = "M"), UsedImplicitly]
        OneM,
        [EnumMember(Value = "W"), UsedImplicitly]
        OneW,
    }
}
