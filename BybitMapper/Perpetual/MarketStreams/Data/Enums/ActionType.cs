using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.MarketStreams.Data.Enums
{
    public enum ActionType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "action"), UsedImplicitly]
        Action,
        [EnumMember(Value = "update"), UsedImplicitly]
        Update
    }
}
