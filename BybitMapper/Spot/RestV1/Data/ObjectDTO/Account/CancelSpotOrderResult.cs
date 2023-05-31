using BybitMapper.Extensions;
using BybitMapper.Spot.RestV1.Data.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Data.ObjectDTO.Account
{
    public class CancelSpotOrderResult
    {
        [JsonConstructor]
        public CancelSpotOrderResult(long accountId, string symbol, string orderLinkId, string orderId, long transactTime, float price, float origQty, float executedQty, string status, string timeInForce, string type, string side)
        {
            AccountId = accountId;
            Symbol = symbol;
            OrderLinkId = orderLinkId;
            OrderId = orderId;
            TransactTime = transactTime;
            Price = price;
            OrigQty = origQty;
            ExecutedQty = executedQty;
            Status = status;
            StatusEnum = Status.ToEnum<SpotOrderResultStatusType>();
            TimeInForce = timeInForce;
            TimeInForceEnum = TimeInForce.ToEnum<SpotOrderResultTimeInForceType>();
            Type = type;
            TypeEnum = Type.ToEnum<SpotOrderResultTypeType>();
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
        [JsonProperty("TransactTime")]
        public long TransactTime { get; }
        [JsonProperty("price")]
        public float Price { get; }
        [JsonProperty("origQty")]
        public float OrigQty { get; }
        [JsonProperty("executedQty")]
        public float ExecutedQty { get; }
        [JsonProperty("status")]
        public string Status { get; }
        public SpotOrderResultStatusType StatusEnum { get; }
        [JsonProperty("timeInForce")]
        public string TimeInForce { get; }
        public SpotOrderResultTimeInForceType TimeInForceEnum { get; }
        [JsonProperty("type")]
        public string Type { get; }
        public SpotOrderResultTypeType TypeEnum { get; }
        [JsonProperty("side")]
        public string Side { get; }
    }
}
