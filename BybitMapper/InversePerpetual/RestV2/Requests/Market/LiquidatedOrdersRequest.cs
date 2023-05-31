using BybitMapper.Requests;
using BybitMapper.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Market
{
    public class LiquidatedOrdersRequest : RequestPayload
    {
        public LiquidatedOrdersRequest(string symbol, decimal? from, int? limit, DateTime? startTime, DateTime? endTime)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
            From = from;
            Limit = limit;
            StartTime = startTime;
            EndTime = endTime;
        }

        public string Symbol { get; }
        public decimal? From { get; }
        public int? Limit { get; }
        public DateTime? StartTime
        {
            get => StartInMilliseconds?.ToDateTimeFromUnixTimeMilliseconds();
            set => StartInMilliseconds = value?.ToUnixTimeMilliseconds();
        }
        public DateTime? EndTime
        {
            get => EndInMilliseconds?.ToDateTimeFromUnixTimeMilliseconds();
            set => EndInMilliseconds = value?.ToUnixTimeMilliseconds();
        }

        private long? StartInMilliseconds { get; set; }
        private long? EndInMilliseconds { get; set; }

        internal override string EndPoint => "/v2/public/liq-records";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddDecimalIfNotNull("from", From);
                res.AddSimpleStructIfNotNull("limit", Limit);
                res.AddSimpleStructIfNotNull("start_time", StartTime);
                res.AddSimpleStructIfNotNull("end_time", EndTime);
                return res;
            }
        }
    }
}
