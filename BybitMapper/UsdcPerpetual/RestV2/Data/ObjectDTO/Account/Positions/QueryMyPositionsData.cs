using BybitMapper.Extensions;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Account.Positions
{
    /// <summary>
    /// Информация о позиции
    /// </summary>
    public sealed class QueryMyPositionsData
    {
        [JsonConstructor]
        public QueryMyPositionsData(string riskId, string symbol, string side, decimal size, decimal entryPrice, decimal sessionAvgPrice, 
            decimal markPrice, decimal sessionUPL, string sessionRPL, decimal positionIM, decimal positionMM, long createdAt, long updatedAt, 
            string tpSlMode, decimal positionValue, decimal leverage, decimal? liqPrice, decimal? bustPrice, decimal? occClosingFee, decimal takeProfit, 
            decimal stopLoss, string positionStatus, decimal? deleverageIndicator, decimal? orderMargin, decimal? unrealisedPnl, decimal? cumRealisedPnl, 
            decimal? trailingStop)
        {
            RiskId = riskId;
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<SideType>();
            Size = size;
            EntryPrice = entryPrice;
            SessionAvgPrice = sessionAvgPrice;
            MarkPrice = markPrice;
            SessionUPL = sessionUPL;
            SessionRPL = sessionRPL;
            PositionIM = positionIM;
            PositionMM = positionMM;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            TpSlMode = tpSlMode;
            TriggerByType = TpSlMode.ToEnum<TriggerByType>();
            PositionValue = positionValue;
            Leverage = leverage;
            LiqPrice = liqPrice;
            BustPrice = bustPrice;
            OccClosingFee = occClosingFee;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            PositionStatus = positionStatus;
            PositionStatusType = PositionStatus.ToEnum<PositionStatusType>();
            DeleverageIndicator = deleverageIndicator;
            OrderMargin = orderMargin;
            UnrealisedPnl = unrealisedPnl;
            CumRealisedPnl = cumRealisedPnl;
            TrailingStop = trailingStop;
        }

        [JsonProperty("riskId")]
        public string RiskId { get; set;}
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("side")]
        public string Side { get; set; }
        public SideType SideType { get; set; }
        [JsonProperty("size")]
        public decimal Size { get; set; }
        [JsonProperty("entryPrice")]
        public decimal EntryPrice { get; set; }
        [JsonProperty("sessionAvgPrice")]
        public decimal SessionAvgPrice { get; set; }
        [JsonProperty("markPrice")]
        public decimal MarkPrice { get; set; }
        [JsonProperty("sessionUPL")]
        public decimal SessionUPL { get; set; }
        [JsonProperty("sessionRPL")]
        public string SessionRPL { get; set; }
        [JsonProperty("positionIM")]
        public decimal PositionIM { get; set; }
        [JsonProperty("positionMM")]
        public decimal PositionMM { get; set; }
        [JsonProperty("createdAt")]
        public long CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        public long UpdatedAt { get; set; }
        [JsonProperty("tpSlMode")]
        public string TpSlMode { get; set; }
        public TriggerByType TriggerByType { get; set; }
        
        [JsonProperty("positionValue")]
        public decimal PositionValue { get; set; }
        [JsonProperty("leverage")]
        public decimal Leverage { get; set; }
        [JsonProperty("liqPrice")]
        public decimal? LiqPrice { get; set; }
        [JsonProperty("bustPrice")]
        public decimal? BustPrice { get; set; }
        [JsonProperty("occClosingFee")]
        public decimal? OccClosingFee { get; set; }
        [JsonProperty("takeProfit")]
        public decimal TakeProfit { get; set; }
        [JsonProperty("stopLoss")]
        public decimal StopLoss { get; set; }
        [JsonProperty("positionStatus")]
        public string PositionStatus { get; set; }
        public PositionStatusType PositionStatusType { get; set; }
        [JsonProperty("deleverageIndicator")]
        public decimal? DeleverageIndicator { get; set; }
        [JsonProperty("orderMargin")]
        public decimal? OrderMargin { get; set; }
        [JsonProperty("unrealisedPnl")]
        public decimal? UnrealisedPnl { get; set; }
        [JsonProperty("cumRealisedPnl")]
        public decimal? CumRealisedPnl { get; set; }
        [JsonProperty("trailingStop")]
        public decimal? TrailingStop { get; set; }
    }
}