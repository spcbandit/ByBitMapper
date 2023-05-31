using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.Requests;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Market
{
    public class MarkPriceRequest : RequestPayload
    {
        public MarkPriceRequest(string symbol, KlineIntervalType interval, DateTime from, int? limit)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            
            Symbol = symbol;
            Interval = interval;
            From = from;
            Limit = limit;
        }

        public string Symbol { get; }
        public KlineIntervalType Interval { get; }
        public DateTime From
        {
            get => FromInSeconds.ToDateTimeFromUnixTimeSeconds();
            set => FromInSeconds = value.ToUnixTimeSeconds();
        }
        private long FromInSeconds { get; set; }
        public int? Limit { get; }

        internal override string EndPoint => "/v2/public/mark-price-kline";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("interval", Interval);
                res.AddSimpleStruct("from", FromInSeconds);
                res.AddSimpleStructIfNotNull("limit", Limit);

                return res;
            }
        }
    }
}
