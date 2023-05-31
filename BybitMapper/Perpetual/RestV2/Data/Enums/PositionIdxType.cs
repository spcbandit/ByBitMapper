using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    public enum PositionIdxType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "0"), UsedImplicitly]
        One,
        [EnumMember(Value = "1"), UsedImplicitly]
        Buy,
        [EnumMember(Value = "2"), UsedImplicitly]
        Sell
    }
}
