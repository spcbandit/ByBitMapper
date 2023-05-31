using JetBrains.Annotations;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.MarketStreams.Data.Object
{
    /// <summary>
    /// Коллекция объектов KlineDate
    /// </summary>
    public sealed class KlineDate
    {
        [JsonConstructor]
        public KlineDate(long start, long end, decimal open, decimal close, decimal high, decimal low, decimal volume, 
            decimal turnover, string confirm, long crossSeq, long timestamp)
        {
            Start = start;
            End = end;
            Open = open;
            Close = close;
            High = high;
            Low = low;
            Volume = volume;
            Turnover = turnover;
            Confirm = confirm;
            CrossSeq = crossSeq;
            Timestamp = timestamp;
        }

        [CanBeNull, JsonProperty("start")]
        public long Start { get; }
        [CanBeNull, JsonProperty("end")]
        public long End { get; }
        [CanBeNull, JsonProperty("open")]
        public decimal Open { get; }
        [CanBeNull, JsonProperty("close")]
        public decimal Close { get; }
        [CanBeNull, JsonProperty("high")]
        public decimal High { get; }
        [CanBeNull, JsonProperty("low")]
        public decimal Low { get; }
        [CanBeNull, JsonProperty("volume")]
        public decimal Volume { get; }
        [CanBeNull, JsonProperty("turnover")]
        public decimal Turnover { get; }
        [CanBeNull, JsonProperty("confirm")]
        public string Confirm { get; }
        [CanBeNull, JsonProperty("cross_seq")]
        public long CrossSeq { get; }
        [CanBeNull, JsonProperty("timestamp")]
        public long Timestamp { get; }
    }
}
