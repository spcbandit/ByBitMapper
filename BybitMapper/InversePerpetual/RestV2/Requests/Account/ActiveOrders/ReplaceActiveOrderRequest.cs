using BybitMapper.Extensions;
using BybitMapper.Requests;

using JetBrains.Annotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Requests.Account.ActiveOrders
{
    public class ReplaceActiveOrderRequest : KeyedRequestPayload
    {
        public ReplaceActiveOrderRequest([NotNull] string symbol, string orderId, string orderLinkId, decimal pRQty, decimal pRPrice)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can not be null!", symbol);
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            Symbol = symbol;
            PRQty = pRQty;
            PRPrice = pRPrice;
        }

        public string OrderId { get; }
        public string OrderLinkId { get; }
        public string Symbol { get; }
        public decimal? PRQty { get; }
        public decimal? PRPrice { get; }
        internal override string EndPoint => "/open-api/order/replace";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties {
            get 
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("order_id", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddDecimalIfNotNull("p_r_qty", PRQty);
                res.AddDecimalIfNotNull("p_r_price", PRPrice);
                return res;
            }
        }
    }
}
