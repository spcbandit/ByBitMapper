using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Data.Enums
{
    public enum OrderCategoryType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "0"), UsedImplicitly]
        Normal,
        [EnumMember(Value = "1"), UsedImplicitly]
        Tpsl,
    }
}