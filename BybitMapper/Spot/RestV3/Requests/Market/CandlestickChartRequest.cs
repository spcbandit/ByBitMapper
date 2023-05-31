using System;
using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.Spot.RestV3.Data.Enums;

namespace BybitMapper.Spot.RestV3.Requests.Market
{
    public class CandlestickChartRequest : RequestPayload
    {
        public CandlestickChartRequest(string symbol, CandlestickType interval)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);

            Symbol = symbol;
            Interval = interval;
        }
        /// <summary>
        /// Инструмент
        /// </summary>
        public string Symbol { get; }
        /// <summary>
        /// Таймфрейм
        /// </summary>
        public CandlestickType Interval { get; }
        /// <summary>
        /// Лимит свечей, значение по умолчанию – 1000, максимальное значение – 1000.
        /// </summary>
        public int? Limit { get; set; } = 1000;
        /// <summary>
        /// Время начала, единица в миллисекундах
        /// </summary>
        public DateTime? StartTime
        {
            get => StartTimeInSeconds?.ToDateTimeFromUnixTimeMilliseconds();
            set
            {
                if (value != null)
                    StartTimeInSeconds = value.Value.ToUnixTimeMilliseconds();
            }
        }
        /// <summary>
        /// Время конца, единица в миллисекундах
        /// </summary>
        public DateTime? EndTime
        {
            get => EndTimeInSeconds?.ToDateTimeFromUnixTimeMilliseconds();
            set
            {
                if (value != null)
                    EndTimeInSeconds = value.Value.ToUnixTimeMilliseconds();
            }
        }
        private long? StartTimeInSeconds { get; set; }
        private long? EndTimeInSeconds { get; set; }


        internal override string EndPoint => "/spot/v3/public/quote/kline";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("interval", Interval);
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddSimpleStructIfNotNull("startTime", StartTimeInSeconds);
                res.AddSimpleStructIfNotNull("endTime", EndTimeInSeconds);

                return res;
            }
        }
    }
}
