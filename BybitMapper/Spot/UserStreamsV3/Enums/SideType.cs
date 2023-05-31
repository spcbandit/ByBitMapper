using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.UserStreamsV3.Enums
{
    public enum SideType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "BUY"), UsedImplicitly]
        Buy,
        [EnumMember(Value = "SELL"), UsedImplicitly]
        Sell,
    }
}
