using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Data.Enums
{
    public enum SpotOrderResultStatusType
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
        [EnumMember(Value = "PENDING_CANCEL"), UsedImplicitly]
        PendingCancel,
        [EnumMember(Value = "PENDING_NEW"), UsedImplicitly]
        PedingNew,
        [EnumMember(Value = "REJECTED"), UsedImplicitly]
        Rejected
    }
}
