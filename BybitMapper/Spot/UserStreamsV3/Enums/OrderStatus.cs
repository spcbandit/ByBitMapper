using System.Runtime.Serialization;

namespace BybitMapper.Spot.UserStreamsV3.Enums
{
    public enum OrderStatus
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "CANCELED")]
        Canceled,
        [EnumMember(Value = "NEW")]
        New,
        [EnumMember(Value = "PARTIALLY_FILLED")]
        PartiallyFilled,
        [EnumMember(Value = "FILLED")]
        Filled,
        [EnumMember(Value = "PENDING_CANCEL")]
        PendingCancel,
        [EnumMember(Value = "PENDING_NEW")]
        PendingNew,
        [EnumMember(Value = "REJECTED")]
        Rejected,
        [EnumMember(Value = "PARTIALLY_FILLED_CANCELLED")]
        PartiallyFilledCanceled,
        /// <summary>
        /// Статус для стопов
        /// </summary>
        [EnumMember(Value = "ORDER_NEW")]
        OrderNew,
        /// <summary>
        /// Статус для стопов
        /// </summary>
        [EnumMember(Value = "ORDER_FILLED")]
        OrderFilled,
        /// <summary>
        /// Статус для стопов
        /// </summary>
        [EnumMember(Value = "ORDER_PARTIALLY_FILLED")]
        OrderPartialyFilled,
        /// <summary>
        /// Статус для стопов
        /// </summary>
        [EnumMember(Value = "ORDER_CANCELED")]
        OrderCanceled,
        /// <summary>
        /// Статус для стопов
        /// </summary>
        [EnumMember(Value = "ORDER_FAILED")]
        OrderFailed,
    }
}
