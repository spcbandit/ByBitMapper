using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using BybitMapper.Extensions;

using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Market
{
    public class OrderBookData
    {
        [JsonConstructor]
        public OrderBookData(decimal price, decimal size, string side)
        {
            Price = price;
            Size = size;
            Side = side;
            SideType = Side.ToEnum<SideType>();
        }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("size")]
        public decimal Size { get; set; }
        [JsonProperty("side")]
        public string Side { get; set; }
        public SideType SideType { get; set; }
    }
}