using System;
using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Requests;
using BybitMapper.Spot.RestV3.Data.Enums;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3.Requests.Account
{
    public class CreateSpotOrderRequest : KeyedRequestPayload
    {
        /// <summary>
        /// Создание ордера
        /// </summary>
        /// <param name="symbol">Инструмент</param>
        /// <param name="order_qty">Количество ордеров (для рыночных ордеров: когда сторона Buy, это в валюте котировки.
        /// В противном случае qty указывается в базовой валюте. Например, на BTCUSDT ордер на покупку находится в USDT, иначе — в BTC. Для лимитных ордеров количество всегда указывается в базовой валюте.)</param>
        /// <param name="side">Направление Buy/Sell</param>
        /// <param name="order_type">Тип ордера LIMIT/MARKET/LIMIT_MAKER</param>
        /// <param name="triggerPrice">Триггерная цена</param>
        public CreateSpotOrderRequest([NotNull] string symbol, decimal? order_qty, CreateSpotOrderSideType side, CreateSpotOrderType order_type, [CanBeNull] decimal? triggerPrice = null)
        {
            if (symbol == null)
                throw new ArgumentException("Symbol can not be null!", symbol);

            Symbol = symbol;
            OrderQty = order_qty;
            Side = side;
            OrderType = order_type;
            TriggerPrice = triggerPrice;
            OrderCategory = triggerPrice == null ? OrderCategoryType.Normal : OrderCategoryType.Tpsl;
        }
        public string Symbol { get; }
        public decimal? OrderQty { get; }
        public CreateSpotOrderSideType Side { get; }
        public CreateSpotOrderType OrderType { get; }
        public CreateSpotOrderTimeInForceType? TimeInForce { get; set; }
        /// <summary>
        /// Цена ордера. Если поле типа MARKET, поле цены является необязательным. Когда поле типа LIMIT или LIMIT_MAKER, поле цены обязательно
        /// </summary>
        public decimal? OrderPrice { get; set; }
        public string OrderLinkId { get; set; }
        public string AgentSource { get; set; }
        public OrderCategoryType? OrderCategory { get; set; }
        /// <summary>
        /// Триггерная цена
        /// </summary>
        public decimal? TriggerPrice { get; set; }

        public override IDictionary<string, string> Headers { get; set; }
        internal override string EndPoint => "/spot/v3/private/order";
        internal override RequestMethod Method => RequestMethod.POST;
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var res = new Dictionary<string, string>();

                res.AddStringIfNotEmptyOrWhiteSpace("symbol", Symbol);
                res.AddDecimalIfNotNull("orderQty", OrderQty);
                res.AddEnum("side", Side);
                res.AddEnum("orderType", OrderType);
                res.AddEnumIfNotNull("timeInForce", TimeInForce);
                res.AddDecimalIfNotNull("orderPrice", OrderPrice);
                res.AddStringIfNotEmptyOrWhiteSpace("orderLinkId", OrderLinkId);
                res.AddEnumIfNotNull("orderCategory", OrderCategory);
                res.AddStringIfNotEmptyOrWhiteSpace("triggerPrice", TriggerPrice.ToString().Replace(',','.'));
                res.AddStringIfNotEmptyOrWhiteSpace("agentSource", AgentSource);
                return res;
            }
        }
    }
}
