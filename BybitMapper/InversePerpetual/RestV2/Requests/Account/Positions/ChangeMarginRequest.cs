using BybitMapper.Requests;
using BybitMapper.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Positions
{
    public class ChangeMarginRequest : KeyedRequestPayload
    {
        public ChangeMarginRequest(string symbol, string margin)
        {
            Symbol = symbol;
            Margin = margin;
        }

        public string Symbol { get; }
        public string Margin { get; }
        internal override string EndPoint => "/position/change-position-margin";

        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("margin", Margin);
                return res;
            }
        }
    }
}
