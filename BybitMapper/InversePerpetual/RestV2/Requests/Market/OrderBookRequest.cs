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
    public sealed class OrderBookRequest : RequestPayload
    {
        public string Symbol { get; }
        public OrderBookRequest([NotNull] string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);

            this.Symbol = symbol;
        }
        internal override string EndPoint => "/spot/quote/v1/depth";

        internal override RequestMethod Method => RequestMethod.GET;

        internal override IDictionary<string, string> Properties
        {
            get {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                return res;
            }
        }
    }
}
