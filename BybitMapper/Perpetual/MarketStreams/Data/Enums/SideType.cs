using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.MarketStreams.Data.Enums
{
    /// <summary>
    /// Buy / Sell
    /// </summary>
    public enum SideType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "Buy"), UsedImplicitly]
        Buy,
        [EnumMember(Value = "Sell"), UsedImplicitly]
        Sell
    }
}
