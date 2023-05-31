using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Data.Enums
{
    public enum OrderListSideType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "BUY"), UsedImplicitly]
        Buy,
        [EnumMember(Value = "SELL"), UsedImplicitly]
        Sell,
    }
}
