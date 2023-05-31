using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.UserStreams.Enums
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
    }
}
