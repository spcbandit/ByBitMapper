using BybitMapper.Extensions;
using BybitMapper.Spot.RestV3.Data.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Data.ObjectDTO.Account
{
    public class CreateSpotOrderResult
    {
        /// <summary>
        /// Создание ордера
        /// </summary>
        /// <param name="symbol">Инструмент</param>
        /// <param name="orderLinkId">Пользовательский идентификатор ордера</param>
        /// <param name="orderId">Идентификатор ордера</param>
        /// <param name="createTime">Время создания ордера</param>
        /// <param name="orderPrice">Цена ордера</param>
        /// <param name="orderQty">Объем ордера</param>
        /// <param name="execQty">Исполненный объем</param>
        /// <param name="status">Статус</param>
        /// <param name="timeInForce">Срок действи</param>
        /// <param name="orderType">Тип ордера</param>
        /// <param name="side">Направление</param>
        /// <param name="orderCategory"></param>
        /// <param name="triggerPrice"></param>
        [JsonConstructor]
        public CreateSpotOrderResult(string symbol, string orderLinkId, string orderId, long createTime, 
        float orderPrice, decimal orderQty, float execQty, string status, 
        string timeInForce, string orderType, string side, string orderCategory, [CanBeNull] string triggerPrice)
        {
            Symbol = symbol;
            OrderLinkId = orderLinkId;
            OrderId = orderId;
            CreateTime = createTime;
            OrderPrice = orderPrice;
            OrderQty = orderQty;
            ExecQty = execQty;
            Status = status;
            StatusEnum = Status.ToEnum<SpotOrderResultStatusType>();
            TimeInForce = timeInForce;
            TimeInForceEnum = TimeInForce.ToEnum<SpotOrderResultTimeInForceType>();
            OrderType = orderType;
            TypeEnum = OrderType.ToEnum<SpotOrderResultTypeType>();
            Side = side;
            OrderCategory = orderCategory;
            OrderCategoryEnum = OrderCategory.ToEnum<OrderCategoryType>();
            TriggerPrice = triggerPrice;
        }

        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("orderLinkId")]
        public string OrderLinkId { get; }
        [JsonProperty("orderId")]
        public string OrderId { get; }
        [JsonProperty("createTime")]
        public long CreateTime { get; }
        [JsonProperty("orderPrice")]
        public float OrderPrice { get; }
        [JsonProperty("orderQty")]
        public decimal OrderQty { get; }
        [JsonProperty("execQty")]
        public float ExecQty { get; }
        [JsonProperty("status")]
        public string Status { get; }
        public SpotOrderResultStatusType StatusEnum { get; }
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; }
        public SpotOrderResultTimeInForceType TimeInForceEnum { get; }
        [JsonProperty("orderType")]
        public string OrderType { get; }
        public SpotOrderResultTypeType TypeEnum { get; }
        [JsonProperty("side")]
        public string Side { get; }
        [JsonProperty("orderCategory")]
        public string OrderCategory { get; }
        public OrderCategoryType OrderCategoryEnum { get; }
        [CanBeNull, JsonProperty("triggerPrice")] 
        public string TriggerPrice { get; }
    }
}
