using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Data.Enums
{
    public enum SpotOrderResultTypeType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "LIMIT"), UsedImplicitly]
        Limit,
        [EnumMember(Value = "MARKET"), UsedImplicitly]
        Market,
        [EnumMember(Value = "LIMIT_MAKER"), UsedImplicitly]
        LimitMaker,
    }
}
