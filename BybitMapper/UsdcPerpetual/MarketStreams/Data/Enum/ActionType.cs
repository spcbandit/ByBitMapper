using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum
{
    public enum ActionType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "action")]
        Action,
        [EnumMember(Value = "update")]
        Update
    }
}
