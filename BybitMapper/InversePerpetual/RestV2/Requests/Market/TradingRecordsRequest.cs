using BybitMapper.Extensions;
using BybitMapper.Requests;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Market
{
    public sealed class TradingRecordsRequest : RequestPayload
    {

        public TradingRecordsRequest([NotNull] string symbol,[CanBeNull] int? from,[CanBeNull] int? limit)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
            From = from;
            Limit = limit;
        }

        public string Symbol { get; }
        public int? From { get; }
        public int? Limit { get; }
        internal override string EndPoint => "/v2/public/trading-records";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var result = new Dictionary<string, string>();
                result.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                result.AddSimpleStructIfNotNull("from", From);
                result.AddSimpleStructIfNotNull("limit", Limit);
                return result;
            }
        }
    }
}
