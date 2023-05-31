using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.ConditionalOrders
{
    /// <summary>
    /// USDT Perpetual формат реквеста ReplaceConditionalOrder
    /// </summary>
    public sealed class ReplaceConditionalOrderRequest : KeyedRequestPayload
    {
        public ReplaceConditionalOrderRequest(string symbol)
        {
            Symbol = symbol;
        }

        public string StopOrderId { get; set; }
        public string OrderLinkId { get; set; }
        public string Symbol { get; set; }
        public int? PRQty { get; set; }
        public decimal? PRPrice { get; set; }
        public decimal? PRTriggerPrice { get; set; }
        public decimal? TakeProfit { get; set; }
        public decimal? StopLoss { get; set; }
        public TriggerPriceType TpTriggerBy { get; set; }
        public TriggerPriceType SlTriggerBy { get; set; }


        internal override string EndPoint => "/private/linear/stop-order/replace";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", StopOrderId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", OrderLinkId);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddDecimalIfNotNull("qty", PRQty);
                res.AddDecimalIfNotNull("price", PRPrice);
                res.AddDecimalIfNotNull("price", PRTriggerPrice);
                res.AddDecimalIfNotNull("take_profit", TakeProfit);
                res.AddDecimalIfNotNull("stop_loss", StopLoss);
                res.AddEnum("tp_trigger_by", TpTriggerBy);
                res.AddEnum("sl_trigger_by", SlTriggerBy);

                return res;
            }
        }
    }
}
