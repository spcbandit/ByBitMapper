using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum PositionStatusType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember( Value = "normal"), UsedImplicitly]
        Normal,
        [EnumMember( Value = "Normal"), UsedImplicitly]
        normal,
        [EnumMember(Value = "Liq"), UsedImplicitly]
        Liq,
        [EnumMember(Value = "Adl"), UsedImplicitly]
        Adl
    }
}
