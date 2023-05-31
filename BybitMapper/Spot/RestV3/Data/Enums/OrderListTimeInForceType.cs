using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Data.Enums
{
    public enum OrderListTimeInForceType
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
