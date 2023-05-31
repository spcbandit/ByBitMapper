using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum ExecType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "Trade"), UsedImplicitly]
        Trade,
        [EnumMember(Value = "AdlTrade"), UsedImplicitly]
        AdlTrade,
        [EnumMember(Value = "Funding"), UsedImplicitly]
        Funding,
        [EnumMember(Value = "BustTrade"), UsedImplicitly]
        BustTrade
    }
}
