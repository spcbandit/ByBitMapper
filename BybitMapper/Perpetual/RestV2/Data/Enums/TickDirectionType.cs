using JetBrains.Annotations;
using System.Runtime.Serialization;


namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    public enum TickDirectionType
    {
        [EnumMember(Value = "")]
        Unrecognized,
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
