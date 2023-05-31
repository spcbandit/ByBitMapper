using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum
{
    /// <summary>
    /// События
    /// </summary>
    public enum UserEventType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "position")]
        Position,
        [EnumMember(Value = "trade")]
        Execution,
        [EnumMember(Value = "order")]
        Order
    }
}
