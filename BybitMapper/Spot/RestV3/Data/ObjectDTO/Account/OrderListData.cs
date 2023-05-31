using System;
using BybitMapper.Extensions;
using BybitMapper.Spot.RestV3.Data.Enums;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Data.ObjectDTO.Account
{
    public class OrderListData
    {
        /// <summary>
        /// Ордер
        /// </summary>
        /// <param name="accountId">Идентификатор аккаунта</param>
        /// <param name="symbol">Инструмент</param>
        /// <param name="orderLinkId">Пользовательский идентификатор ордера</param>
        /// <param name="orderId">Идентификатор ордера></param>
        /// <param name="orderPrice"></param>
        /// <param name="orderQty"></param>
        /// <param name="executedQty"></param>
        /// <param name="cummulativeQuoteQty"></param>
        /// <param name="avgPrice"></param>
        /// <param name="status"></param>
        /// <param name="timeInForce"></param>
        /// <param name="side"></param>
        /// <param name="stopPrice"></param>
        /// <param name="icebergQty"></param>
        /// <param name="updateTime"></param>
        /// <param name="isWorking"></param>
        [JsonConstructor]
        public OrderListData(string accountId, string symbol, string orderLinkId, 
            string orderId, float orderPrice, decimal orderQty, decimal executedQty, 
            float cummulativeQuoteQty, float avgPrice, string status, string timeInForce, 
            string orderType, string side, float stopPrice, float icebergQty, ulong createTime, 
            float updateTime, string isWorking, int orderCategory, float? triggerPrice)
        {
            AccountId = accountId;
            Symbol = symbol;
            OrderLinkId = orderLinkId;
            OrderId = orderId;
            OrderPrice = orderPrice;
            OrderQty = orderQty;
            ExecutedQty = executedQty;
            CummulativeQuoteQty = cummulativeQuoteQty;
            AvgPrice = avgPrice;
            Status = status;
            StatusEnum = Status.ToEnum<OrderListStatusType>();
            TimeInForce = timeInForce;
            TimeInForceEnum = TimeInForce.ToEnum<OrderListTimeInForceType>();
            OrderType = orderType;
            TypeEnum = OrderType.ToEnum<OrderListTypeType>();
            Side = side;
            SideEnum = Side.ToEnum<OrderListSideType>();
            StopPrice = stopPrice;
            IcebergQty = icebergQty;
            CreateTime = createTime;
            UpdateTime = updateTime;
            IsWorking = isWorking;
            IsWorkingBool = isWorking == "0";
            OrderCategory = orderCategory;
            TriggerPrice = triggerPrice;
        }

        [JsonProperty("accountId")]
        public string AccountId { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("orderLinkId")]
        public string OrderLinkId { get; }
        [JsonProperty("orderId")]
        public string OrderId { get; }
        [JsonProperty("orderPrice")]
        public float OrderPrice { get; }
        [JsonProperty("orderQty")]
        public decimal OrderQty { get; }
        [JsonProperty("execQty")]
        public decimal ExecutedQty { get; }
        [JsonProperty("cummulativeQuoteQty")]
        public float CummulativeQuoteQty { get; }
        [JsonProperty("avgPrice")]
        public float AvgPrice { get; }
        [JsonProperty("status")]
        public string Status { get; }
        public OrderListStatusType StatusEnum { get; }
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; }
        public OrderListTimeInForceType TimeInForceEnum { get; }
        [JsonProperty("orderType")]
        public string OrderType { get; }
        public OrderListTypeType TypeEnum { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderListSideType SideEnum { get; }
        [JsonProperty("stopPrice")]
        public float StopPrice { get; }
        [JsonProperty("icebergQty")]
        public float IcebergQty { get; }
        [JsonProperty("createTime")]
        public ulong CreateTime { get; }
        [JsonProperty("updateTime")]
        public float UpdateTime { get; }
        [JsonProperty("isWorking")]
        public string IsWorking { get; }
        public bool IsWorkingBool { get; }
        [JsonProperty("orderCategory")]
        public int OrderCategory { get; }
        [CanBeNull, JsonProperty("triggerPrice")]
        public float? TriggerPrice { get; }
        public DateTime? CreatedAt
        {
            get
            {
                return ((long)(CreateTime / 1000)).ToDateTimeFromUnixTimeSeconds();
            }
        }
    }
}
