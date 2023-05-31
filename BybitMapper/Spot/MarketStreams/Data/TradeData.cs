using BybitMapper.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams.Data
{
    public class TradeData
    {
        [JsonConstructor]
        public TradeData(string transactionId, ulong timestamp, decimal price, decimal quantity, bool? trueIndicates)
        {
            TransactionId = transactionId;
            Timestamp = timestamp;
            Price = price;
            Quantity = quantity;
            TrueIndicates = trueIndicates;
        }

        [JsonProperty("v")]
        public string TransactionId { get; }
        [JsonProperty("t")]
        public ulong Timestamp { get; }
        [JsonProperty("p")]
        public decimal Price { get; }
        [JsonProperty("q")]
        public decimal Quantity { get; }
        [JsonProperty("m")]
        public bool? TrueIndicates { get; }
        public DateTime? Time
        {
            get
            {
                return ((long)Timestamp).ToDateTimeFromUnixTimeMilliseconds();
            }
        }
    }
}
