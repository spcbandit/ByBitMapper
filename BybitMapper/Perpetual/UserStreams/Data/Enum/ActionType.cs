using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.UserStreams.Data.Enum
{
    public enum ActionType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "action"), UsedImplicitly]
        Action,
        [EnumMember(Value = "update"), UsedImplicitly]
        Update
    }
}
