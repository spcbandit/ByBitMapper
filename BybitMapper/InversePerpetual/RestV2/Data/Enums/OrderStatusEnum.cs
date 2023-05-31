using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
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
