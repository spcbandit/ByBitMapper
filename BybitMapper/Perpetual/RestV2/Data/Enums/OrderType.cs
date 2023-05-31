using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    /// <summary>
    /// Limit or Market
    /// </summary>
    public enum OrderType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "Limit"), UsedImplicitly]
        Limit,
        [EnumMember(Value = "Market"), UsedImplicitly]
        Market
    }
}
