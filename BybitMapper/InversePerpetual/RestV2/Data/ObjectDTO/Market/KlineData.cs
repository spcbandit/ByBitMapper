using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BybitMapper.Extensions;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class KlineData
    {
        [JsonConstructor]
        public KlineData(string symbol, string type, long openTime, decimal open, decimal high, decimal low, decimal close, decimal volume, double turnOver)
        {
            Symbol = symbol;
            Type = type;
            KlineType = Type.ToEnum<KlineIntervalType>();
            OpenTime = openTime;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Volume = volume;
            TurnOver = turnOver;
        }

        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("interval")]
        public string Type { get; }
        public KlineIntervalType KlineType { get; }
        [JsonRequired, JsonProperty("open_time")]
        public long OpenTime{ get; }
        [JsonRequired, JsonProperty("open")]
        public decimal Open { get; }
        [JsonRequired, JsonProperty("high")]
        public decimal High { get; }
        [JsonRequired, JsonProperty("low")]
        public decimal Low { get; }
        [JsonRequired, JsonProperty("close")]
        public decimal Close { get; }
        [JsonRequired, JsonProperty("volume")]
        public decimal Volume { get; }
        [JsonRequired, JsonProperty("turnover")]
        public double TurnOver { get; }

        public DateTime? Time
        {
            get
            {
                //DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                //DateTime date = start.AddSeconds(OpenTime);
                return OpenTime.ToDateTimeFromUnixTimeSeconds();
            }
        }

    }
}
