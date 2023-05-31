using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    /// <summary>
    /// type LastLiquidityInd
    /// </summary>
    public enum LastLiquidityIndType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "TAKER")]
        Taker,
        [EnumMember(Value = "MAKER")]
        Maker
    }
}
