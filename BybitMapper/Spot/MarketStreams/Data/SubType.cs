using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams.Data
{
    public enum SubType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        Unrecognized,
        [EnumMember(Value = "sub"), UsedImplicitly]
        Subscribe,
        [EnumMember(Value = "cancel"), UsedImplicitly]
        Unsubscribe
    }
}
