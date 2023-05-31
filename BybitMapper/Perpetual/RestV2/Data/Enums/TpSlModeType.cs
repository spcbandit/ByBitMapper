using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    public enum TpSlModeType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "Full"), UsedImplicitly]
        Full,
        [EnumMember(Value = "Partial"), UsedImplicitly]
        Partial
    }
}
