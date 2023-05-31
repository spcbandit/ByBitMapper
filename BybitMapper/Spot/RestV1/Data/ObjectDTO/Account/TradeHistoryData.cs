using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Data.ObjectDTO.Account
{
    public class TradeHistoryData
    {
        [JsonConstructor]
        public TradeHistoryData(string id, string ticketId, string symbol, string symbolName, string orderId, string matchOrderId, float price, decimal qty, float commission, string commissionAsset, long time, bool isBuyer, bool isMaker, TradeHistoryFeeData fee, string feeTokenId, float feeAmount, float makerRebate)
        {
            Id = id;
            TicketId = ticketId;
            Symbol = symbol;
            SymbolName = symbolName;
            OrderId = orderId;
            MatchOrderId = matchOrderId;
            Price = price;
            Qty = qty;
            Commission = commission;
            CommissionAsset = commissionAsset;
            Time = time;
            IsBuyer = isBuyer;
            IsMaker = isMaker;
            Fee = fee;
            FeeTokenId = feeTokenId;
            FeeAmount = feeAmount;
            MakerRebate = makerRebate;
        }

        [JsonProperty("id")]
        public string Id { get; }
        [JsonProperty("ticketId")]
        public string TicketId { get; }
        
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("symbolName")]
        public string SymbolName { get; }
        [JsonProperty("orderId")]
        public string OrderId { get; }
        [JsonProperty("matchOrderId")]
        public string MatchOrderId { get; }
        [JsonProperty("price")]
        public float Price { get; }
        [JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonProperty("commission")]
        public float Commission { get; }
        [JsonProperty("commissionAsset")]
        public string CommissionAsset { get; }
        [JsonProperty("time")]
        public long Time { get; }
        [JsonProperty("isBuyer")]
        public bool IsBuyer { get; }
        [JsonProperty("isMaker")]
        public bool IsMaker { get; }
        [JsonProperty("fee")]
        public TradeHistoryFeeData Fee { get; }
        [JsonProperty("feeTokenId")]
        public string FeeTokenId { get; }
        [JsonProperty("feeAmount")]
        public float FeeAmount { get; }
        [JsonProperty("makerRebate")]
        public float MakerRebate { get; }
    }
    public class TradeHistoryFeeData
    {
        [JsonConstructor]
        public TradeHistoryFeeData(string feeTokenId, string feeTokenName, decimal fee)
        {
            FeeTokenId = feeTokenId;
            FeeTokenName = feeTokenName;
            Fee = fee;
        }

        [JsonProperty("feeTokenId")]
        public string FeeTokenId { get; }
        [JsonProperty("feeTokenName")]
        public string FeeTokenName { get; }
        [JsonProperty("fee")]
        public decimal Fee { get; }
    }
}
