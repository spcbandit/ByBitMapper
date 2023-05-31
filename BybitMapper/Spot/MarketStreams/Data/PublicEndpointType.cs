using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Spot.MarketStreams.Data
{
    /// <summary>
    /// Название подписки
    /// </summary>
    public enum PublicEndpointType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "realtimes"), UsedImplicitly]
        Realtimes,
        [EnumMember(Value = "diffDepth"), UsedImplicitly]
        Depth,
        [EnumMember(Value = "trade"), UsedImplicitly]
        Trade
    }
}
