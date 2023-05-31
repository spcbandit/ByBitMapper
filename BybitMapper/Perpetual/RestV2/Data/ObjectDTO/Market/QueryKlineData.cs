using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;


namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class QueryKlineData
    {
        [JsonConstructor]
        public QueryKlineData(long id, string symbol, string period, long startAt, decimal volume, decimal open, decimal high, decimal low, decimal close, string interval, long openTime, decimal turnOver)
        {
            Id = id;
            Symbol = symbol;
            Period = period;
            PeriodType = Period.ToEnum<PeriodType>();
            StartAt = startAt;
            Volume = volume;
            Open = open;
            High = high;
            Low = low;
            Close = close;
            Interval = interval;
            IntervalType = Interval.ToEnum<IntervalType>();
            OpenTime = openTime;
            TurnOver = turnOver;
        }

        [JsonProperty("id")]
        public long Id { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("period")]
        public string Period { get; }
        public PeriodType PeriodType { get; }
        [JsonProperty("start_at")]
        public long StartAt { get; }
        [JsonProperty("volume")]
        public decimal Volume { get; }
        [JsonProperty("open")]
        public decimal Open { get; }
        [JsonProperty("high")]
        public decimal High { get; }
        [JsonProperty("low")]
        public decimal Low { get; }
        [JsonProperty("close")]
        public decimal Close { get; }
        [JsonProperty("interval")]
        public string Interval { get; }
        public IntervalType IntervalType { get; }
        [JsonProperty("open_time")]
        public long OpenTime { get; }
        [JsonProperty("turnover")]
        public decimal TurnOver { get; }
        public DateTime? Time
        {
            get
            {
                return OpenTime.ToDateTimeFromUnixTimeSeconds();
            }
        }
    }
}
