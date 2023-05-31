using BybitMapper.Extensions;

using Newtonsoft.Json;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class MarkPriceKlineData
    {
        [JsonConstructor]
        public MarkPriceKlineData(decimal id, string symbol, string period, long startTime, decimal open, decimal high, decimal low, decimal close)
        {
            Id = id;
            Symbol = symbol;
            Period = period;
            KlinePeriod = Period.ToEnum<KlineIntervalType>();
            StartTime = startTime;
            Open = open;
            High = high;
            Low = low;
            Close = close;
        }

        [JsonRequired, JsonProperty("id")]
        public decimal Id { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("period")]
        public string Period { get; }
        public KlineIntervalType KlinePeriod { get; }
        [JsonRequired, JsonProperty("start_at")]
        public long StartTime { get; }
        [JsonRequired, JsonProperty("open")]
        public decimal Open { get; }
        [JsonRequired, JsonProperty("high")]
        public decimal High { get; }
        [JsonRequired, JsonProperty("low")]
        public decimal Low { get; }
        [JsonRequired, JsonProperty("close")]
        public decimal Close { get; }
    }
}
