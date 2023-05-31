using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    public enum SideType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "Buy"), UsedImplicitly]
        Buy,
        [EnumMember(Value = "Sell"), UsedImplicitly]
        Sell
    }
}