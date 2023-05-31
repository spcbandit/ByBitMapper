using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Data.Enums
{
    public enum CandlestickType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "1m"), UsedImplicitly]
        OneMinute,
        [EnumMember(Value = "3m"), UsedImplicitly]
        ThreeMinute,
        [EnumMember(Value = "5m"), UsedImplicitly]
        FiveMinute,
        [EnumMember(Value = "15m"), UsedImplicitly]
        FifteenMinute,
        [EnumMember(Value = "30m"), UsedImplicitly]
        ThirtyMinute,
        [EnumMember(Value = "1h"), UsedImplicitly]
        OneHour,
        [EnumMember(Value = "2h"), UsedImplicitly]
        TwoHour,
        [EnumMember(Value = "4h"), UsedImplicitly]
        FourHour,
        [EnumMember(Value = "6h"), UsedImplicitly]
        SixHour,
        [EnumMember(Value = "12h"), UsedImplicitly]
        TwelveHours,
        [EnumMember(Value = "1d"), UsedImplicitly]
        OneDay,
        [EnumMember(Value = "1w"), UsedImplicitly]
        OneWeek,
        [EnumMember(Value = "1M"), UsedImplicitly]
        OneMonth
    }
}
