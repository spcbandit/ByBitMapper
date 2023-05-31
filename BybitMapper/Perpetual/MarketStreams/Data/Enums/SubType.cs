using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.MarketStreams.Data.Enums
{
    public enum SubType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        Unrecognized,
        [EnumMember(Value = "auth"), UsedImplicitly]
        Auth,
        [EnumMember(Value = "subscribed"), UsedImplicitly]
        Subscribed,
        [EnumMember(Value = "subscribe"), UsedImplicitly]
        Subscribe,
        [EnumMember(Value = "unsubscribed"), UsedImplicitly]
        Unsubscribed,
        [EnumMember(Value = "unsubscribe"), UsedImplicitly]
        Unsubscribe,
        [EnumMember(Value = "update"), UsedImplicitly]
        Update,
        [EnumMember(Value = "partial"), UsedImplicitly]
        Partial

    }
}
