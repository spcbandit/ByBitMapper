using BybitMapper.Extensions;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Market
{
    public class TradingRecordsData
    {
        [JsonConstructor]
        public TradingRecordsData(int id, string symbol, decimal price, decimal qty, string side, DateTime? time)
        {
            Id = id;
            Symbol = symbol;
            Price = price;
            Qty = qty;
            Side = side;
            OrderSide = Side.ToEnum<OrderSideType>();
            Time = time;
        }

        [JsonRequired, JsonProperty("id")]
        public int Id { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("price")]
        public decimal Price { get; }
        [JsonRequired, JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side  { get; }
        public OrderSideType OrderSide  { get; }
        [CanBeNull, JsonProperty("time")]
        public DateTime? Time { get; }
    }
}
