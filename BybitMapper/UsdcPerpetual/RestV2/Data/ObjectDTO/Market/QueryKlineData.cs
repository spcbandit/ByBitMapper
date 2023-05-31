using BybitMapper.Extensions;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Market
{
    public class QueryKlineData
    {
        [JsonConstructor]
        public QueryKlineData(decimal volume, string symbol, decimal open, long openTime, decimal turnover, string period, decimal low, decimal high, decimal close)
        {
            Volume = volume;
            Symbol = symbol;
            Open = open;
            OpenTime = openTime;
            Turnover = turnover;
            Period = period;
            IntervalType = Period.ToEnum<IntervalType>();
            Low = low;
            High = high;
            Close = close;
        }

        
        [JsonRequired, JsonProperty("volume")] 
        public decimal Volume { get; set; }
        [JsonRequired, JsonProperty("symbol")] 
        public string Symbol { get; set; }
        [JsonRequired, JsonProperty("open")] 
        public decimal Open { get; set; }
        [JsonRequired, JsonProperty("openTime")] 
        public long OpenTime { get; set; }
        [JsonRequired, JsonProperty("turnover")] 
        public decimal Turnover { get; set; }
        [JsonRequired, JsonProperty("period")] 
        public string Period { get; set; }
        public IntervalType IntervalType { get; set; }
        [JsonRequired, JsonProperty("low")] 
        public decimal Low { get; set; }
        [JsonRequired, JsonProperty("high")] 
        public decimal High { get; set; }
        [JsonRequired, JsonProperty("close")] 
        public decimal Close { get; set; }
        public DateTime? Time
        {
            get
            {
                return OpenTime.ToDateTimeFromUnixTimeSeconds();
            }
        }
    }
}