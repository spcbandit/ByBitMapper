using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    /// <summary>
    /// MarkPrice type
    /// </summary>
    public enum TriggerByType
    {
        [EnumMember(Value = "")]
        Unrecognized, 
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,
        [EnumMember(Value = "MarkPrice")]
        MarkPrice,
        [EnumMember(Value = "LastPrice")]
        LastPrice,
    }
}
