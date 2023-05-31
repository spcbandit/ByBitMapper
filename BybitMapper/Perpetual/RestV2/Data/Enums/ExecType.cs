using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    /// <summary>
    /// Trade || AdlTrade || Funding || BustTrade
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
