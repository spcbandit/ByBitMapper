using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum LiquidityType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = ""), UsedImplicitly]
        None, //None
        [EnumMember(Value = "AddedLiquidity"), UsedImplicitly]
        AddedLiquidity, //Maker
        [EnumMember(Value = "RemovedLiquidity"), UsedImplicitly]
        RemovedLiquidity //Taker
    }
}
