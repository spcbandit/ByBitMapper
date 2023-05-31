using JetBrains.Annotations;
using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    /// <summary>
    /// Тип exec
    /// </summary>
    public enum ExecType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "Trade"), UsedImplicitly]
        Trade,
        [EnumMember(Value = "AdlTrade"), UsedImplicitly]
        AdlTrade,
        [EnumMember(Value = "Funding"), UsedImplicitly]
        Funding,
        [EnumMember(Value = "BustTrade"), UsedImplicitly]
        BustTrade
    }
}
