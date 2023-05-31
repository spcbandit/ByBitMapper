using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class QueryMarkPriceKlineData
    {
        [JsonConstructor]
        public QueryMarkPriceKlineData(decimal id, string symbol, string period, long startTime, decimal open, decimal high, decimal low, decimal close)
        {
            Id = id;
            Symbol = symbol;
            Period = period;
            KlinePeriod = Period.ToEnum<IntervalType>();
            StartTime = startTime;
            Open = open;
            High = high;
            Low = low;
            Close = close;
        }

        [JsonProperty("id")]
        public decimal Id { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("period")]
        public string Period { get; }
        public IntervalType KlinePeriod { get; }
        [JsonProperty("start_at")]
        public long StartTime { get; }
        [JsonProperty("open")]
        public decimal Open { get; }
        [JsonProperty("high")]
        public decimal High { get; }
        [JsonProperty("low")]
        public decimal Low { get; }
        [JsonProperty("close")]
        public decimal Close { get; }
    }
}
