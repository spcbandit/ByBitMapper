using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum
{
    /// <summary>
    /// PlusTick ZeroPlusTick MinusTick ZeroMinusTick
    /// </summary>
    public enum TickDirectionType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "PlusTick"), UsedImplicitly]
        PlusTick,
        [EnumMember(Value = "ZeroPlusTick"), UsedImplicitly]
        ZeroPlusTick,
        [EnumMember(Value = "MinusTick"), UsedImplicitly]
        MinusTick,
        [EnumMember(Value = "ZeroMinusTick"), UsedImplicitly]
        ZeroMinusTick
    }
}
