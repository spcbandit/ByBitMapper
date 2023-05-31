using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum TimeInForceType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "GoodTillCancel"), UsedImplicitly]
        GoodTillCancel,
        [EnumMember(Value = "ImmediateOrCancel"), UsedImplicitly]
        ImmediateOrCancel,
        [EnumMember(Value = "FillOrKill"), UsedImplicitly]
        FillOrKill,
        [EnumMember(Value = "PostOnly"), UsedImplicitly]
        PostOnly
    }
}
