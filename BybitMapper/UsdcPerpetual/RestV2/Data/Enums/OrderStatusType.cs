using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    public enum OrderStatusType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "Created"), UsedImplicitly]
        Created,
        [EnumMember(Value = "Rejected"), UsedImplicitly]
        Rejected,
        [EnumMember(Value = "New"), UsedImplicitly]
        New,
        [EnumMember(Value = "PartiallyFilled"), UsedImplicitly]
        PartiallyFilled,
        [EnumMember(Value = "Filled"), UsedImplicitly]
        Filled,
        [EnumMember(Value = "Cancelled"), UsedImplicitly]
        Cancelled,
        [EnumMember(Value = "PendingCancel"), UsedImplicitly]
        PendingCancel
    }
}