using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    public enum OrderStatusType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "Created")]
        Created,
        [EnumMember(Value = "Rejected")]
        Rejected,
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "PartiallyFilled")]
        PartiallyFilled,
        [EnumMember(Value = "Filled")]
        Filled,
        [EnumMember(Value = "Cancelled")]
        Cancelled,
        [EnumMember(Value = "PendingCancel")]
        PendingCancel,
        [EnumMember(Value = "Untriggered")]
        Untriggered,
        [EnumMember(Value = "Deactivated")]
        Deactivated ,
        [EnumMember(Value = "Triggered")]
        Triggered ,
        [EnumMember(Value = "Active")]
        Active ,
    }
}
