using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Data.Enums
{
    public enum OrderListTypeType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "LIMIT"), UsedImplicitly]
        Limit,
        [EnumMember(Value = "MARKET"), UsedImplicitly]
        Market,
        [EnumMember(Value = "LIMIT_MAKER"), UsedImplicitly]
        LimitMaker,
    }
}
