using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.UserStreamsV3.Enums
{
    public enum OrderType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "LIMIT"), UsedImplicitly]
        Limit,
        [EnumMember(Value = "MARKET"), UsedImplicitly]
        Market,
        [EnumMember(Value = "LIMIT_MAKER"), UsedImplicitly]
        LimitMaker
    }
}
