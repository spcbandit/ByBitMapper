using BybitMapper.Requests;
using BybitMapper.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Positions
{
    public class SetLeverageRequest : KeyedRequestPayload
    {
        
        public SetLeverageRequest(string symbol, int leverage)
        {
            Symbol = symbol;
            Leverage = leverage;
        }

        public string Symbol { get; }
        public int Leverage { get; }
        internal override string EndPoint => "/user/leverage/save";

        internal override RequestMethod Method =>  RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddSimpleStruct("leverage", Leverage);
                return res;
            }
        }
    }
}
