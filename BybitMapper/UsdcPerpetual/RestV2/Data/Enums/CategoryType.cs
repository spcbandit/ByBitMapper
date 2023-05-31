using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    /// <summary>
    /// Тип категории
    /// </summary>
    public enum CategoryType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "PERPETUAL")]
        Perpetual,
    }
}
