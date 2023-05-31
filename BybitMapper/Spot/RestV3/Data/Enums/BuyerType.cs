using System.Runtime.Serialization;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Data.Enums
{
    public enum BuyerType
        {
            [EnumMember(Value = "None")]
            Unrecognized,
            [EnumMember(Value = "0"), UsedImplicitly]
            Buyer,
            [EnumMember(Value = "1"), UsedImplicitly]
            Seller,
        }
    }