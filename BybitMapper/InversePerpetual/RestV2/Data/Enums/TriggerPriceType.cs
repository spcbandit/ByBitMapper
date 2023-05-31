using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum TriggerPriceType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "LastPrice"), UsedImplicitly]
        LastPrice,
        [EnumMember(Value = "IndexPrice"), UsedImplicitly]
        IndexPrice,
        [EnumMember(Value = "MarkPrice"), UsedImplicitly]
        MarkPrice
    }
}
