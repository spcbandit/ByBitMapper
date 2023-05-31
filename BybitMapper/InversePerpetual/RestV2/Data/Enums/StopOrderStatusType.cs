using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum StopOrderStatusType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "Active"), UsedImplicitly]
        Active,
        [EnumMember(Value = "Untriggered"), UsedImplicitly]
        Untriggered,
        [EnumMember(Value = "Triggered"), UsedImplicitly]
        Triggered,
        [EnumMember(Value = "Cancelled"), UsedImplicitly]
        Cancelled,
        [EnumMember(Value = "Rejected"), UsedImplicitly]
        Rejected,
        [EnumMember(Value = "Deactivated"), UsedImplicitly]
        Deactivated
    }
}
