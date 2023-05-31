using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.Positions
{
    public class FullPartialPositionSLTPRequest : KeyedRequestPayload
    {
        public FullPartialPositionSLTPRequest(string symbol, TPSLModeType tpslMode)
        {
            Symbol = symbol;
            TPSLMode = tpslMode;
        }

        public string Symbol { get; set; }
        public TPSLModeType TPSLMode { get; set; }
        internal override string EndPoint => "/v2/private/tpsl/switch-mode";

        internal override RequestMethod Method =>  RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("tp_sl_mode", TPSLMode);
                return res;
            }
        }
    }
}