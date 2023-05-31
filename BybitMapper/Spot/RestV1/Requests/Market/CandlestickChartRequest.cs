using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.Spot.RestV1.Data.Enums;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Requests.Market
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

        public string Symbol { get; }
        public CandlestickType Interval { get; }
        public int? Limit { get; set; } = 1000;
        public DateTime? StartTime
        {
            get => StartTimeInSeconds?.ToDateTimeFromUnixTimeMilliseconds();
            set
            {
                if (value != null)
                    StartTimeInSeconds = value.Value.ToUnixTimeMilliseconds();
            }
        }
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


        internal override string EndPoint => "/spot/quote/v1/kline";
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
