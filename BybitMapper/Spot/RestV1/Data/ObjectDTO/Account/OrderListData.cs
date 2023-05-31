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
    public class OrderListData
    {
        [JsonConstructor]
        public OrderListData(string accountId, string exchangeId, string symbol, string symbolName, 
            string orderLinkId, string orderId, float price, decimal origQty, decimal executedQty, 
            float cummulativeQuoteQty, float avgPrice, string status,string timeInForce, string type, string side, 
            float stopPrice, float icebergQty, ulong time, float updateTime, bool isWorking)
        {
            AccountId = accountId;
            ExchangeId = exchangeId;
            Symbol = symbol;
            SymbolName = symbolName;
            OrderLinkId = orderLinkId;
            OrderId = orderId;
            Price = price;
            OrigQty = origQty;
            ExecutedQty = executedQty;
            CummulativeQuoteQty = cummulativeQuoteQty;
            AvgPrice = avgPrice;
            Status = status;
            StatusEnum = Status.ToEnum<OrderListStatusType>();
            TimeInForce = timeInForce;
            TimeInForceEnum = TimeInForce.ToEnum<OrderListTimeInForceType>();
            Type = type;
            TypeEnum = Type.ToEnum<OrderListTypeType>();
            Side = side;
            SideEnum = Side.ToEnum<OrderListSideType>();
            StopPrice = stopPrice;
            IcebergQty = icebergQty;
            Time = time;
            UpdateTime = updateTime;
            IsWorking = isWorking;
        }

        [JsonProperty("accountId")]
        public string AccountId { get; }
        [JsonProperty("exchangeId")]
        public string ExchangeId { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [ JsonProperty("symbolName")]
        public string SymbolName { get; }
        [JsonProperty("orderLinkId")]
        public string OrderLinkId { get; }
        [JsonProperty("orderId")]
        public string OrderId { get; }
        [JsonProperty("price")]
        public float Price { get; }
        [JsonProperty("origQty")]
        public decimal OrigQty { get; }
        [JsonProperty("executedQty")]
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
        [JsonProperty("type")]
        public string Type { get; }
        public OrderListTypeType TypeEnum { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderListSideType SideEnum { get; }
        [JsonProperty("stopPrice")]
        public float StopPrice { get; }
        [JsonProperty("icebergQty")]
        public float IcebergQty { get; }
        [JsonProperty("time")]
        public ulong Time { get; }
        [JsonProperty("updateTime")]
        public float UpdateTime { get; }
        [JsonProperty("isWorking")]
        public bool IsWorking { get; }

        public DateTime? CreatedAt
        {
            get
            {
                return ((long)(Time/1000)).ToDateTimeFromUnixTimeSeconds(); 
            }
        }

    }
}
