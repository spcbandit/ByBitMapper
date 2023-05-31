using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Requests;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Requests.Account.ActiveOrders
{
    /// <summary>
    /// USDT Perpetual формат реквеста PlaceActiveOrder
    /// </summary>
    public sealed class PlaceActiveOrderRequest : KeyedRequestPayload
    {
        public PlaceActiveOrderRequest(OrderSideType side, string symbol, OrderType orderType, decimal qty, 
            TimeInForceType timeInForce, bool? reduceOnly, bool? closeOnTrigger)
        {
            Side = side;
            Symbol = symbol;
            OrderType = orderType;
            Qty = qty;
            TimeInForce = timeInForce;
            ReduceOnly = reduceOnly;
            CloseOnTrigger = closeOnTrigger;
        }

        public OrderSideType Side { get; set; }
        public string Symbol { get; set; }
        public OrderType OrderType { get; set; }
        public decimal Qty { get; set; }
        public decimal? Price { get; set; }
        public TimeInForceType TimeInForce { get; set; }
        public decimal? TakeProfit { get; set; }
        public decimal? StopLoss { get; set; }
        public bool? ReduceOnly { get; set; }
        public bool? CloseOnTrigger { get; set; }
        public string OrderLinkId { get; set; }
        public TriggerPriceType TpTriggerBy { get; set; }
        public TriggerPriceType SlTriggerBy { get; set; }
        public PositionIdxType PositionIdx { get; set; }
        internal override string EndPoint => "/private/linear/order/create";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddEnum("side", Side);
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("order_type", OrderType);
                res.AddDecimal("qty", Qty);
                res.AddDecimalIfNotNull("price", Price);
                res.AddEnum("time_in_force", TimeInForce);
                res.AddSimpleStructIfNotNull("close_on_trigger", CloseOnTrigger);
                res.AddSimpleStructIfNotNull("reduce_only", ReduceOnly);
                res.AddDecimalIfNotNull("take_profit", TakeProfit);
                res.AddDecimalIfNotNull("stop_loss", StopLoss);
                res.AddStringIfNotEmptyOrWhiteSpace("order_link_id", OrderLinkId);
                res.AddEnum("tp_trigger_by", TpTriggerBy);
                res.AddEnum("sl_trigger_by", SlTriggerBy);
                res.AddEnum("position_idx", PositionIdx);
                return res;
            }
        }
    }
}
