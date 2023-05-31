using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.Requests;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Market
{
    public sealed class KlineRequest : RequestPayload
    {
        public KlineRequest([NotNull] string symbol, KlineIntervalType interval, DateTime from,[CanBeNull] int? limit)
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

        public int? Limit { get; }
        private long FromInSeconds { get; set; }

        internal override string EndPoint => "/v2/public/kline/list";

        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get {
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
