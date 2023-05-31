using BybitMapper.Extensions;
using BybitMapper.Requests;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Requests.Market
{
    public class OrderBookRequest : RequestPayload
    {
        public OrderBookRequest([NotNull] string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }

        public string Symbol { get; set; }
        public int? Limit { get; set; } = 100;
       
        internal override string EndPoint => "/spot/quote/v1/depth";

        internal override RequestMethod Method => RequestMethod.GET;

        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddSimpleStructIfNotNull("limit", Limit);
                return res;
            }
        }
    }
}
