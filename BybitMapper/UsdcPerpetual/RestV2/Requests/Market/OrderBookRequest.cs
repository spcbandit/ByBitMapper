using BybitMapper.Extensions;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Market
{
    /// <summary>
    /// OrderBook
    /// </summary>
    public sealed class OrderBookRequest : RequestPayload
    {
        public OrderBookRequest(string symbol)
        {
            Symbol = symbol;
        }
        public string Symbol { get; set; }
        
        internal override string EndPoint => "/perpetual/usdc/openapi/public/v1/order-book";
        internal override RequestMethod Method => RequestMethod.GET;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.Add("symbol", Symbol);
                return res;
            }
        }
    }
}