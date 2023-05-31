using System.Runtime.Serialization;

using JetBrains.Annotations;

namespace BybitMapper.Perpetual.RestV2.Data.Enums
{
    public enum OrderSideType
    {
        [EnumMember(Value = "")]
        Unrecognized,
        [EnumMember(Value = "None"), UsedImplicitly]
        None,
        [EnumMember(Value = "Buy"), UsedImplicitly]
        Buy,
        [EnumMember(Value = "Sell"), UsedImplicitly]
        Sell
    }
}
