using System;
using BybitMapper.Extensions;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Data.ObjectDTO.Market
{

    public class Candle
    {
        public Candle(long timestamp, string name, double? openPrice, double? highestPrice,
            double? lowestPrice, double? closePrice, decimal? volume, string alias)
        {
            Timestamp = timestamp;
            Name = name;
            OpenPrice = openPrice;
            HighestPrice = highestPrice;
            LowestPrice = lowestPrice;
            ClosePrice = closePrice;
            Volume = volume;
            Alias = alias;
        }
        [JsonProperty("t")]
        public long Timestamp { get; }
        [JsonProperty("s")]
        public string Name { get; }
        [JsonProperty("sn")]
        public string Alias { get; }
        [JsonProperty("o")]
        public double? OpenPrice { get; }
        [JsonProperty("h")]
        public double? HighestPrice { get; }
        [JsonProperty("l")]
        public double? LowestPrice { get; }
        [JsonProperty("c")]
        public double? ClosePrice { get; }
        [JsonProperty("v")]
        public decimal? Volume { get; }

        public DateTime? Time
        {
            get
            {
                return Timestamp.ToDateTimeFromUnixTimeMilliseconds();
            }
        }
    }
}
