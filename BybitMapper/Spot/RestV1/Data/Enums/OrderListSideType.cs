using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Data.Enums
{
    public enum OrderListSideType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "BUY"), UsedImplicitly]
        Buy,
        [EnumMember(Value = "SELL"), UsedImplicitly]
        Sell,
    }
}
