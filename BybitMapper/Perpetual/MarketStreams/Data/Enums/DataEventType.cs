using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.MarketStreams.Data.Enums
{
    public enum DataEventType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "snapshot"), UsedImplicitly]
        Snapshot,
        [EnumMember(Value = "delta"), UsedImplicitly]
        Delta
    }
}
