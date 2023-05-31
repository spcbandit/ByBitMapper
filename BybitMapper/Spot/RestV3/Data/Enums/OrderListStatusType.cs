using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Data.Enums
{
    public enum OrderListStatusType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "NEW"), UsedImplicitly]
        New,
        [EnumMember(Value = "PARTIALLY_FILLED"), UsedImplicitly]
        PartiallyFilled,
        [EnumMember(Value = "FILLED"), UsedImplicitly]
        Filled,
        [EnumMember(Value = "CANCELED"), UsedImplicitly]
        Canceled,
        [EnumMember(Value = "ORDER_NEW"), UsedImplicitly]
        OrderNew,
        [EnumMember(Value = "ORDER_PARTIALLY_FILLED"), UsedImplicitly]
        OrderPartiallyFilled,
        [EnumMember(Value = "ORDER_FILLED"), UsedImplicitly]
        OrderFilled,
        [EnumMember(Value = "ORDER_CANCELED"), UsedImplicitly]
        OrderCanceled,
        [EnumMember(Value = "PENDING_CANCEL"), UsedImplicitly]
        PendingCancel,
        [EnumMember(Value = "PENDING_NEW"), UsedImplicitly]
        PedingNew,
        [EnumMember(Value = "REJECTED"), UsedImplicitly]
        Rejected
    }
}
