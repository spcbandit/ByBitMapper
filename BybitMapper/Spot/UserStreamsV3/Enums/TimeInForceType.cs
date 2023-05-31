using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.UserStreamsV3.Enums
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
