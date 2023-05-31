using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Data.Enums
{
    public enum CreateSpotOrderSideType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "Buy"), UsedImplicitly]
        Buy,
        [EnumMember(Value = "Sell"), UsedImplicitly]
        Sell
    }
}
