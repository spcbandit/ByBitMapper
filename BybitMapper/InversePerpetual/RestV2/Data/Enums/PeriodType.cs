using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    /// <summary>
    /// Not a Candle period
    /// </summary>
    public enum PeriodType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "5min"), UsedImplicitly]
        FiveMinute,
        [EnumMember(Value = "15min"), UsedImplicitly]
        FifteenMinute,
        [EnumMember(Value = "30min"), UsedImplicitly]
        ThirteenMinute,
        [EnumMember(Value = "1h"), UsedImplicitly]
        OneHour,
        [EnumMember(Value = "4h"), UsedImplicitly]
        FourHour,
        [EnumMember(Value = "1d"), UsedImplicitly]
        OneDay
    }
}
