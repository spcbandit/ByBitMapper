using JetBrains.Annotations;

using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    
    public enum OrderType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "Limit"), UsedImplicitly]
        Limit,
        [EnumMember(Value = "Market"), UsedImplicitly]
        Market
    }
}