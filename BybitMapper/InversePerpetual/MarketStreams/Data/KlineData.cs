using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
    public sealed class KlineData
    {
        [JsonConstructor]
        public KlineData(long start, long end, decimal open, decimal close, decimal high, decimal low, decimal volume, double turnOver, bool confirm, decimal crossSeq, long timestamp)
        {
            Start = start;
            End = end;
            Open = open;
            Close = close;
            High = high;
            Low = low;
            Volume = volume;
            TurnOver = turnOver;
            Confirm = confirm;
            CrossSeq = crossSeq;
            Timestamp = timestamp;
        }

        [JsonRequired, JsonProperty("start")]
        public long Start { get; }
        [JsonRequired, JsonProperty("end")]
        public long End { get; }
        [JsonRequired, JsonProperty("open")]
        public decimal Open { get; }
        [JsonRequired, JsonProperty("close")]
        public decimal Close { get; }
        [JsonRequired, JsonProperty("high")]
        public decimal High { get; }
        [JsonRequired, JsonProperty("low")]
        public decimal Low { get; }
        [JsonRequired, JsonProperty("volume")]
        public decimal Volume { get; }
        [JsonRequired, JsonProperty("turnover")]
        public double TurnOver { get; }
        [JsonRequired, JsonProperty("confirm")]
        public bool Confirm { get; }
        [JsonRequired, JsonProperty("cross_seq")]
        public decimal CrossSeq { get; }
        [JsonRequired, JsonProperty("timestamp")]
        public long Timestamp { get; }

    }
}
