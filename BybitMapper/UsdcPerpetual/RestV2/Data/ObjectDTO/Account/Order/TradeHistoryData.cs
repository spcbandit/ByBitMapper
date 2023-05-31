using BybitMapper.Extensions;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order
{
    public sealed class TradeHistoryData
    {
        [JsonConstructor]
        public TradeHistoryData(string symbol, string orderId, string orderLinkId, string side, decimal? execPrice,
            decimal execQty, decimal execFee, decimal feeRate, long tradeTime, string exec, string lastLiquidityInd,
            decimal? execValue, string tradeId)
        {
            Symbol = symbol;
            OrderId = orderId;
            OrderLinkId = orderLinkId;
            Side = side;
            SideType = Side.ToEnum<SideType>();
            ExecPrice = execPrice;
            ExecQty = execQty;
            ExecFee = execFee;
            FeeRate = feeRate;
            TradeTime = tradeTime;
            Exec = exec;
            ExecType = Exec.ToEnum<ExecType>();
            LastLiquidityInd = lastLiquidityInd;
            LastLiquidityIndType = LastLiquidityInd.ToEnum<LastLiquidityIndType>();
            ExecValue = execValue;
            TradeId = tradeId;
        }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("orderId")]
        public string OrderId { get; set; }
        [JsonProperty("orderLinkId")]
        public string OrderLinkId { get; set; }
        [JsonProperty("side")]
        public string Side { get; set; }
        public SideType SideType { get; set; }
        [JsonProperty("execPrice")]
        public decimal? ExecPrice { get; set; }
        [JsonProperty("execQty")]
        public decimal ExecQty { get; set; }
        [JsonProperty("execFee")]
        public decimal ExecFee { get; set; }
        [JsonProperty("feeRate")]
        public decimal FeeRate { get; set; }
        [JsonProperty("tradeTime")]
        public long TradeTime { get; set; }
        [JsonProperty("execType")]
        public string Exec { get; set; }
        public ExecType ExecType { get; set; }
        [JsonProperty("lastLiquidityInd")]
        public string LastLiquidityInd { get; set; }
        public LastLiquidityIndType LastLiquidityIndType { get; set; }
        [JsonProperty("execValue")]
        public decimal? ExecValue { get; set; }
        [JsonProperty("tradeId")]
        public string TradeId { get; set; }
    }
}