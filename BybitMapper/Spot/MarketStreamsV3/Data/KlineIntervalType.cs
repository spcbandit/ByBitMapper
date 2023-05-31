using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.MarketStreamsV3.Data
{
    public enum KlineIntervalType
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
        [EnumMember(Value = "3h"), UsedImplicitly]
        FourHour,
        [EnumMember(Value = "4h"), UsedImplicitly]
        SixHour,
        [EnumMember(Value = "6h"), UsedImplicitly]
        TwelveHours,
        [EnumMember(Value = "1d"), UsedImplicitly]
        OneDay,
        [EnumMember(Value = "1w"), UsedImplicitly]
        OneWeek,
        [EnumMember(Value = "1M"), UsedImplicitly]
        OneMonth,
    }
}
