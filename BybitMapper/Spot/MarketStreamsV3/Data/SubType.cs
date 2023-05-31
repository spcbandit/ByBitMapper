using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.MarketStreamsV3.Data
{
    public enum SubType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        Unrecognized,
        [EnumMember(Value = "subscribe"), UsedImplicitly]
        Subscribe,
        [EnumMember(Value = "unsubscribe"), UsedImplicitly]
        Unsubscribe
    }
}
