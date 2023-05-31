using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.UserStreams.Data
{
    public enum UserEventType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "position")]
        Position,
        [EnumMember(Value = "execution")]
        Execution,
        [EnumMember(Value = "order")]
        Order,
        [EnumMember(Value = "stop_order")]
        StopOrder
    }
}
