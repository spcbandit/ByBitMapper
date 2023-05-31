using BybitMapper.Extensions;
using BybitMapper.Spot.RestV3.Data.Enums;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Data.ObjectDTO.Account
{
    public class CancelSpotOrderResult
    {
        /// <summary>
        /// Отмена активного ордера
        /// </summary>
        /// <param name="accountId">Идентификатор аккаунта</param>
        /// <param name="symbol">Инструмент</param>
        /// <param name="orderLinkId">Пользовательский идентификатор ордера</param>
        /// <param name="orderId">Идентификатор ордера</param>
        /// <param name="createTime">Время создания ордера</param>
        /// <param name="orderPrice">Цена ордера</param>
        /// <param name="orderQty">Объем ордера</param>
        /// <param name="execQty">Исполненный объем</param>
        /// <param name="status">Статус</param>
        /// <param name="timeInForce">Срок действия</param>
        /// <param name="orderType">Тип ордера</param>
        /// <param name="side">Направление</param>
        [JsonConstructor]
        public CancelSpotOrderResult(long accountId, string symbol, string orderLinkId, string orderId, long createTime, float orderPrice, float orderQty, float execQty, string status, string timeInForce, string orderType, string side)
        {
            AccountId = accountId;
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
            TypeEnum = orderType.ToEnum<SpotOrderResultTypeType>();
            Side = side;
        }
        [JsonProperty("accountId")]
        public long AccountId { get; }
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
        public float OrderQty { get; }
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
    }
}
