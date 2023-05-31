using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.UserStreams.Data
{
    public enum ActionType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "action"), UsedImplicitly]
        Action,
        [EnumMember(Value = "update"), UsedImplicitly]
        Update
    }
}
