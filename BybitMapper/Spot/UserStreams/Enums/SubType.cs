using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.UserStreams.Enums
{
    public enum SubType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        Unrecognized,
        [EnumMember(Value = "auth"), UsedImplicitly]
        Auth
    }
}
