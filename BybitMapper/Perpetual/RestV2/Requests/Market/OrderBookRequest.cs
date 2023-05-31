using BybitMapper.Extensions;
using BybitMapper.Requests;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Market
{
    /// <summary>
    /// USDT Perpetual Реквест : книга заказов размером 50
    /// </summary>
    public sealed class OrderBookRequest : RequestPayload
    {
        public OrderBookRequest(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
                throw new ArgumentException("Symbol can not be null!", symbol);
            Symbol = symbol;
        }
        public string Symbol { get; set; }
        /// <summary>
        /// Такая же ссылка как у InversePerpetual
        /// </summary>
        internal override string EndPoint => "/v2/public/orderBook/L2";
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
