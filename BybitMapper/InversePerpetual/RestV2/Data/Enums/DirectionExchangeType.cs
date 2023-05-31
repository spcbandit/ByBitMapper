using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum DirectionExchangeType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "Prev")]
        Prev,
        [EnumMember(Value = "Next")]
        Next
    }
}
