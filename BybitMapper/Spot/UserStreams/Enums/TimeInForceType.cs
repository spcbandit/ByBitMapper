using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.UserStreams.Enums
{
    public enum TimeInForceType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "GTC"), UsedImplicitly]
        Gtc,
        [EnumMember(Value = "FOK"), UsedImplicitly]
        Fok,
        [EnumMember(Value = "IOC"), UsedImplicitly]
        Ioc,
    }
}
