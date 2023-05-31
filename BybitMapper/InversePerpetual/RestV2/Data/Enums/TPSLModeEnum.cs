using System.Runtime.Serialization;

namespace BybitMapper.InversePerpetual.RestV2.Data.Enums
{
    public enum TPSLModeType
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "Full")]
        Full,
        [EnumMember(Value = "Partial")]
        Partial
    }
}