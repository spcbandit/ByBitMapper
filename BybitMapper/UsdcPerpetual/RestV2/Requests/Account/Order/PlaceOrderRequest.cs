using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;

using System.Collections.Generic;

// https://bybit-exchange.github.io/docs/usdc/perpetual/#t-usdcplaceorder

namespace BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Order
{
    /// <summary>
    /// Запрос на выставление ордера
    /// </summary>
    public sealed class PlaceOrderRequest : UsdcKeyedRequestPayload
    {
        public PlaceOrderRequest(string symbol, OrderType orderType, OrderFilterType orderFilter, SideType side, decimal orderQty)
        {
            Symbol = symbol;
            OrderType = orderType;
            OrderFilter = orderFilter;
            Side = side;
            OrderQty = orderQty;
        }

        public string Symbol { get; set; }
        public OrderType OrderType { get; set; }
        public OrderFilterType OrderFilter { get; set; }
        public SideType Side { get; set; }
        public decimal? OrderPrice { get; set; }
        public decimal OrderQty { get; set; }
        public TimeInForceType? TimeInForce { get; set; }
        public string OrderLinkId { get; set; }
        public bool? ReduceOnly { get; set; }
        public bool? CloseOnTrigger { get; set; }
        public decimal? TakeProfit { get; set; }
        public decimal? StopLoss { get; set; }
        public TriggerByType? Tptriggerby { get; set; }
        public TriggerByType? SlTriggerBy { get; set; }
        public decimal? BasePrice { get; set; }
        public decimal? TriggerPrice { get; set; }
        public TriggerByType? TriggerBy { get; set; }
        public bool? Mmp { get; set; }
        
        internal override string EndPoint => "/perpetual/usdc/openapi/private/v1/place-order";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override object Body
        {
            get
            {
                var res = new Dictionary<string, string>();
                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddEnum("orderType", OrderType);
                res.AddEnum("orderFilter", OrderFilter);
                res.AddEnum("side", Side);
                res.AddDecimalIfNotNull("orderPrice", OrderPrice);
                res.AddDecimalIfNotNull("orderQty", OrderQty);
                res.AddEnumIfNotNull("timeInForce", TimeInForce);
                res.AddStringIfNotEmptyOrWhiteSpace("orderLinkId", OrderLinkId);
                res.AddBooleanIfNotNull("reduceOnly", ReduceOnly);
                res.AddBooleanIfNotNull("closeOnTrigger", CloseOnTrigger);
                res.AddDecimalIfNotNull("takeProfit", TakeProfit);
                res.AddDecimalIfNotNull("stopLoss", StopLoss);
                res.AddEnumIfNotNull("tptriggerby", Tptriggerby);
                res.AddEnumIfNotNull("slTriggerBy", SlTriggerBy);
                res.AddDecimalIfNotNull("triggerPrice", TriggerPrice);
                res.AddDecimalIfNotNull("basePrice", BasePrice);
                res.AddEnumIfNotNull("triggerBy", TriggerBy);
                res.AddBooleanIfNotNull("mmp", Mmp);
                
                return res;
            }
        }
    }
}
