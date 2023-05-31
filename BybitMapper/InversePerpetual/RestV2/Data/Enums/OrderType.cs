using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum OrderType
    {
        [EnumMember(Value = ""), UsedImplicitly]
        None,
        [EnumMember(Value = "Limit"), UsedImplicitly]
        Limit,
        [EnumMember(Value = "Market"), UsedImplicitly]
        Market
    }
}
