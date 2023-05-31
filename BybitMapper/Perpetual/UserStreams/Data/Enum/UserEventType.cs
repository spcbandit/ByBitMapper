using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.UserStreams.Data.Enum
{
    public enum UserEventType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "position")]
        Position,
        [EnumMember(Value = "execution")]
        Execution,
        [EnumMember(Value = "order")]
        Order,
        [EnumMember(Value = "stop_order")]
        StopOrder,
        [EnumMember(Value = "wallet")]
        Wallet
    }
}
