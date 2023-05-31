using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.UserStreamsV3.Enums
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
