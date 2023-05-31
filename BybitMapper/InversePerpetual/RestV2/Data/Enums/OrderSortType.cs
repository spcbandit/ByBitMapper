using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum OrderSortType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "Desc"), UsedImplicitly]
        Desc,
        [EnumMember(Value = "Asc"), UsedImplicitly]
        Asc
    }
}
