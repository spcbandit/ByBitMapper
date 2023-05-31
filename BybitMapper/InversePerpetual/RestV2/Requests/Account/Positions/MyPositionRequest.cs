using BybitMapper.Requests;
using BybitMapper.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Positions
{
    public class MyPositionRequest : KeyedRequestPayload
    {

        public MyPositionRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; }
        internal override string EndPoint => "/v2/private/position/list";
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
