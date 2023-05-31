using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
    public enum TickDirectionType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "PlusTick"), UsedImplicitly]
        PlusTick,
        [EnumMember(Value = "ZeroPlusTick"), UsedImplicitly]
        ZeroPlusTick,
        [EnumMember(Value = "MinusTick"), UsedImplicitly]
        MinusTick,
        [EnumMember(Value = "ZeroMinusTick"), UsedImplicitly]
        ZeroMinusTick
    }
}
