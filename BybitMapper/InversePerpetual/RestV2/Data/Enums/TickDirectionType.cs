using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data
{
    public enum TickDirectionType
    {
        [EnumMember(Value = "")]
        Unrecognized,
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
