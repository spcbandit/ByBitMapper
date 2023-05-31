using BybitMapper.Extensions;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.Position
{
    /// <summary>
    /// USDT Perpetual формат реквеста MyPosition
    /// </summary>
    public sealed class MyPositionRequest : KeyedRequestPayload
    {
        public MyPositionRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; set; }

        internal override string EndPoint => "/private/linear/position/list";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);

                return res;
            }
        }
    }
}
