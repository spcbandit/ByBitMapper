using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class PositionEventResultData
    {
        [JsonConstructor]
        public PositionEventResultData(string symbol, string positionStatus, string side, string size, string entryPrice,
            string sessionAvgPrice, string markPrice, string positionIM, string positionMM, string positionValue,
            string liqPrice, string bustPrice, string occClosingFee, string unrealisedPnl, string cumRealisedPnl,
            string sessionUPL, string createdAt, string updatedAt, string tpSlMode, string leverage, int trailingStop,
            string takeProfit, string stopLoss, string deleverageIndicator, string riskId)
        {
            Symbol = symbol;
            PositionStatus = positionStatus;
            Side = side;
            Size = size;
            EntryPrice = entryPrice;
            SessionAvgPrice = sessionAvgPrice;
            MarkPrice = markPrice;
            PositionIM = positionIM;
            PositionMM = positionMM;
            PositionValue = positionValue;
            LiqPrice = liqPrice;
            BustPrice = bustPrice;
            OccClosingFee = occClosingFee;
            UnrealisedPnl = unrealisedPnl;
            CumRealisedPnl = cumRealisedPnl;
            SessionUPL = sessionUPL;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            TpSlMode = tpSlMode;
            Leverage = leverage;
            TrailingStop = trailingStop;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            DeleverageIndicator = deleverageIndicator;
            RiskId = riskId;
        }
        [CanBeNull, JsonProperty("symbol")]
        public string Symbol { get; set; }
        [CanBeNull, JsonProperty("positionStatus")]
        public string PositionStatus { get; set; }
        [CanBeNull, JsonProperty("side")]
        public string Side { get; set; }
        [CanBeNull, JsonProperty("size")]
        public string Size { get; set; }
        [CanBeNull, JsonProperty("entryPrice")]
        public string EntryPrice { get; set; }
        [CanBeNull, JsonProperty("sessionAvgPrice")]
        public string SessionAvgPrice { get; set; }
        [CanBeNull, JsonProperty("markPrice")]
        public string MarkPrice { get; set; }
        [CanBeNull, JsonProperty("positionIM")]
        public string PositionIM { get; set; }
        [CanBeNull, JsonProperty("positionMM")]
        public string PositionMM { get; set; }
        [CanBeNull, JsonProperty("positionValue")]
        public string PositionValue { get; }
        [CanBeNull, JsonProperty("liqPrice")]
        public string LiqPrice { get; }
        [CanBeNull, JsonProperty("bustPrice")]
        public string BustPrice { get; }
        [CanBeNull, JsonProperty("occClosingFee")]
        public string OccClosingFee { get; }
        [CanBeNull, JsonProperty("unrealisedPnl")]
        public string UnrealisedPnl { get; }
        [CanBeNull, JsonProperty("cumRealisedPnl")]
        public string CumRealisedPnl { get; }
        [CanBeNull, JsonProperty("sessionUPL")]
        public string SessionUPL { get; }
        [CanBeNull, JsonProperty("createdAt")]
        public string CreatedAt { get; }
        [CanBeNull, JsonProperty("updatedAt")]
        public string UpdatedAt { get; }
        [CanBeNull, JsonProperty("tpSlMode")]
        public string TpSlMode { get; }
        [CanBeNull, JsonProperty("leverage")]
        public string Leverage { get; }
        [CanBeNull, JsonProperty("trailingStop")]
        public int TrailingStop { get; }
        [CanBeNull, JsonProperty("takeProfit")]
        public string TakeProfit { get; }
        [CanBeNull, JsonProperty("stopLoss")]
        public string StopLoss { get; }
        [CanBeNull, JsonProperty("deleverageIndicator")]
        public string DeleverageIndicator { get; }
        [CanBeNull, JsonProperty("riskId")]
        public string RiskId { get; }
    }
}