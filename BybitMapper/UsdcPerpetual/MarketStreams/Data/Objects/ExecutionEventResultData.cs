using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class ExecutionEventResultData
    {
        [JsonConstructor]
        public ExecutionEventResultData(string orderId, string orderLinkId, string tradeId, string symbol, string side,
            string execPrice, string execQty, string execFee, string feeRate, int tradeTime, string lastLiquidityInd,
            string execValue, string execType)
        {
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            TradeId = tradeId;
            Symbol = symbol;
            Side = side;
            ExecPrice = execPrice;
            ExecQty = execQty;
            ExecFee = execFee;
            FeeRate = feeRate;
            TradeTime = tradeTime;
            LastLiquidityInd = lastLiquidityInd;
            ExecValue = execValue;
            ExecType = execType;
        }
        [JsonProperty("orderId")]
        public string OrderId { get; set; }
        [JsonProperty("orderLinkId")]
        public string OrderLinkId { get; set; }
        [JsonProperty("tradeId")]
        public string TradeId { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("side")]
        public string Side { get; set; }
        [JsonProperty("execPrice")]
        public string ExecPrice { get; set; }
        [JsonProperty("execQty")]
        public string ExecQty { get; set; }
        [JsonProperty("execFee")]
        public string ExecFee { get; set; }
        [JsonProperty("feeRate")]
        public string FeeRate { get; set; }
        [JsonProperty("tradeTime")]
        public int TradeTime { get; set; }
        [JsonProperty("lastLiquidityInd")]
        public string LastLiquidityInd { get; set; }
        [JsonProperty("execValue")]
        public string ExecValue { get; set; }
        [JsonProperty("execType")]
        public string ExecType { get; set; }
    }
}