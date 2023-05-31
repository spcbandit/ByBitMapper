using JetBrains.Annotations;
using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    public enum SortOrdersType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "desc"), UsedImplicitly]
        Desc,
        [EnumMember(Value = "asc"), UsedImplicitly]
        Asc
    }
}
