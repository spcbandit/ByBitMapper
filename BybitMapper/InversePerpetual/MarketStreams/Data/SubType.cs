using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
    public enum SubType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        Unrecognized,
        [EnumMember(Value = "auth"), UsedImplicitly]
        Auth,
        [EnumMember(Value = "subscribed"), UsedImplicitly]
        Subscribed,
        [EnumMember(Value = "subscribe"), UsedImplicitly]
        Subscribe,
        [EnumMember(Value = "unsubscribed"), UsedImplicitly]
        Unsubscribed,
        [EnumMember(Value = "unsubscribe"), UsedImplicitly]
        Unsubscribe,
        [EnumMember(Value = "update"), UsedImplicitly]
        Update,
        [EnumMember(Value = "partial"), UsedImplicitly]
        Partial

    }
}
