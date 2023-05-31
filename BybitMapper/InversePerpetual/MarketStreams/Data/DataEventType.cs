using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
    public enum DataEventType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "snapshot"),UsedImplicitly]
        Snapshot,
        [EnumMember(Value = "delta"), UsedImplicitly]
        Delta
    }
}
