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
    public sealed class MyPositionData
    {
        [JsonConstructor]
        public MyPositionData(string id, string userId, string riskId, string symbol, string side, decimal size, decimal positionValue, 
            decimal entryPrice, bool isIsolated, decimal autoAddMargin, decimal leverage, 
            decimal effectiveLeverage, decimal positionMargin, decimal liqPrice, decimal bustPrice, 
            decimal occClosingFee, decimal occFundingFee, decimal takeProfit, decimal stopLoss, 
            decimal trailingStop, string positionStatus, decimal deleverageIndicator, 
            string ocCalcData, decimal orderMargin, decimal walletBalance, decimal realisedPnl, 
            decimal unrealisedPnl, decimal cumRealisedPnl, decimal crossSeq, decimal positionSeq, DateTime? createdAt, DateTime? updatedAt)
        {
            Id = id;
            UserId = userId;
            RiskId = riskId;
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Size = size;
            PositionValue = positionValue;
            EntryPrice = entryPrice;
            IsIsolated = isIsolated;
            AutoAddMargin = autoAddMargin;
            Leverage = leverage;
            EffectiveLeverage = effectiveLeverage;
            PositionMargin = positionMargin;
            LiqPrice = liqPrice;
            BustPrice = bustPrice;
            OccClosingFee = occClosingFee;
            OccFundingFee = occFundingFee;
            TakeProfit = takeProfit;
            StopLoss = stopLoss;
            TrailingStop = trailingStop;
            PositionStatus = positionStatus;
            PositionStatusType = PositionStatus.ToEnum<PositionStatusType>();
            DeleverageIndicator = deleverageIndicator;
            OcCalcData = ocCalcData;
            OrderMargin = orderMargin;
            WalletBalance = walletBalance;
            RealisedPnl = realisedPnl;
            UnrealisedPnl = unrealisedPnl;
            CumRealisedPnl = cumRealisedPnl;
            CrossSeq = crossSeq;
            PositionSeq = positionSeq;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        [JsonRequired, JsonProperty("id")]
        public string Id { get; }
        [JsonRequired, JsonProperty("user_id")]

        public string UserId { get; }
        [JsonRequired, JsonProperty("risk_id")]
        public string RiskId { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonRequired, JsonProperty("size")]
        public decimal Size { get; }
        [JsonRequired, JsonProperty("position_value")]
        public decimal PositionValue { get; }
        [JsonRequired, JsonProperty("entry_price")]
        public decimal EntryPrice { get; }
        [JsonRequired, JsonProperty("is_isolated")]
        public bool IsIsolated { get; }
        [JsonRequired, JsonProperty("auto_add_margin")]
        public decimal AutoAddMargin { get; }
        [JsonRequired, JsonProperty("leverage")]
        public decimal Leverage { get; }
        [JsonRequired, JsonProperty("effective_leverage")]
        public decimal EffectiveLeverage { get; }
        [JsonRequired, JsonProperty("position_margin")]
        public decimal PositionMargin { get; }
        [JsonRequired, JsonProperty("liq_price")]
        public decimal LiqPrice { get; }
        [JsonRequired, JsonProperty("bust_price")]
        public decimal BustPrice { get; }
        [JsonRequired, JsonProperty("occ_closing_fee")]
        public decimal OccClosingFee { get; }
        [JsonRequired, JsonProperty("occ_funding_fee")]
        public decimal OccFundingFee { get; }
        [JsonRequired, JsonProperty("take_profit")]
        public decimal TakeProfit { get; }
        [JsonRequired, JsonProperty("stop_loss")]
        public decimal StopLoss { get; }
        [JsonRequired, JsonProperty("trailing_stop")]
        public decimal TrailingStop { get; }
        [JsonRequired, JsonProperty("position_status")]
        public string PositionStatus { get; }
        public PositionStatusType PositionStatusType { get; }
        [JsonRequired, JsonProperty("deleverage_indicator")]
        public decimal DeleverageIndicator { get; }
        [JsonRequired, JsonProperty("oc_calc_data")]
        public string OcCalcData { get; }
        [JsonRequired, JsonProperty("order_margin")]
        public decimal OrderMargin { get; }
        [JsonRequired, JsonProperty("wallet_balance")]
        public decimal WalletBalance { get; }
        [JsonRequired, JsonProperty("realised_pnl")]
        public decimal RealisedPnl { get; }
        [JsonRequired, JsonProperty("unrealised_pnl")]
        public decimal UnrealisedPnl { get; }
        [JsonRequired, JsonProperty("cum_realised_pnl")]
        public decimal CumRealisedPnl { get; }
        [JsonRequired, JsonProperty("cross_seq")]
        public decimal CrossSeq { get; }
        [JsonRequired, JsonProperty("position_seq")]
        public decimal PositionSeq { get; }
        [CanBeNull, JsonProperty("created_at")]
        public DateTime? CreatedAt { get; }
        [CanBeNull, JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; }
    }
}
