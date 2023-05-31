using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.ActiveOrders
{
    /// <summary>
    /// USDT Perpetual формат реквеста ReplaceActiveOrder
    /// </summary>
    public sealed class ReplaceActiveOrderRequest : KeyedRequestPayload
    {
        public ReplaceActiveOrderRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string OrderId { get; set; }
        public string OrderLinkId { get; set; }
        public string Order { get; set; }
        public string Symbol { get; set; }
        public decimal? PRQty { get; set; }
        public decimal? PRPrice { get; set; }
        public decimal? TakeProfit { get; set; }
        public decimal? StopLoss { get; set; }
        public TriggerPriceType TpTriggerBy { get; set; }
        public TriggerPriceType SlTriggerBy { get; set; }

        internal override string EndPoint => "/private/linear/order/replace";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("order_id", OrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddStringIfNotEmptyOrWhiteSpace("order", Order);
                res.AddDecimalIfNotNull("p_r_qty", PRQty);
                res.AddDecimalIfNotNull("p_r_price", PRPrice);
                res.AddDecimalIfNotNull("take_profit", TakeProfit);
                res.AddDecimalIfNotNull("stop_loss", StopLoss);
                res.AddEnum("tp_trigger_by", TpTriggerBy);
                res.AddEnum("sl_trigger_by", SlTriggerBy);
                return res;
            }
        }
    }
}
