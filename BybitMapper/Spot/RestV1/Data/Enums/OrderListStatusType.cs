using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Data.Enums
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
        [EnumMember(Value = "PENDING_CANCEL"), UsedImplicitly]
        PendingCancel,
        [EnumMember(Value = "PENDING_NEW"), UsedImplicitly]
        PedingNew,
        [EnumMember(Value = "REJECTED"), UsedImplicitly]
        Rejected
    }
}
