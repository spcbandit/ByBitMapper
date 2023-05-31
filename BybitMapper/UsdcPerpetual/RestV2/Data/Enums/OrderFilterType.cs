using System.Runtime.Serialization;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.Enums
{
    /// <summary>
    /// Тип ордеров
    /// </summary>
    public enum OrderFilterType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "Order")]
        Order,
        [EnumMember(Value = "StopOrder")]
        StopOrder,
    }
}
