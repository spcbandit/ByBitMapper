using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class CancelAllOrdersData
    {
        [JsonConstructor]
        public CancelAllOrdersData(string clOrdId, string userId, string symbol, string side,
            string orderType, decimal price, decimal qty, string timeInForce,
            string createType, string cancelType, string orderStatus, decimal leavesQty,
            decimal leavesValue, DateTime? createdAt, DateTime? updatedAt, string crossStatus, string crossSeq)
        {
            ClOrdId = clOrdId;
            UserId = userId;
            Symbol = symbol;
            Side = side;
            OrderType = orderType;
            Price = price;
            Qty = qty;
            TimeInForce = timeInForce;
            CreateType = createType;
            CancelType = cancelType;
            OrderStatus = orderStatus;
            LeavesQty = leavesQty;
            LeavesValue = leavesValue;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            CrossStatus = crossStatus;
            CrossSeq = crossSeq;

            OrderSide = Side.ToEnum<OrderSideType>();
            OrderTypeEnum = OrderType.ToEnum<OrderType>();
            TimeInForceType = TimeInForce.ToEnum<TimeInForceType>();
            OrderStatusType = OrderStatus.ToEnum<OrderStatusType>();
        }

        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType OrderSide { get; }
        [JsonProperty("order_type")]
        public string OrderType { get; }
        public OrderType OrderTypeEnum { get; }
        [JsonProperty("time_in_force")]
        public string TimeInForce { get; }
        public TimeInForceType TimeInForceType { get; }
        [JsonProperty("order_status")]
        public string OrderStatus { get; }
        public OrderStatusType OrderStatusType { get; }

        [JsonProperty("clOrdID")]
        public string ClOrdId { get; }
        [JsonProperty("user_id")]
        public string UserId { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }


        [JsonProperty("price")]
        public decimal Price { get; }
        [JsonProperty("qty")]
        public decimal Qty { get; }

        [JsonProperty("create_type")]
        public string CreateType { get; }
        [JsonProperty("cancel_type")]
        public string CancelType { get; }

        [JsonProperty("leaves_qty")]
        public decimal LeavesQty { get; }
        [JsonProperty("leaves_value")]
        public decimal LeavesValue { get; }
        [CanBeNull, JsonProperty("created_at")]
        public DateTime? CreatedAt { get; }
        [CanBeNull, JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; }
        [JsonProperty("cross_status")]
        public string CrossStatus { get; }
        [JsonProperty("cross_seq")]
        public string CrossSeq { get; }
    }
}
