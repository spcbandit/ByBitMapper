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
    public sealed class PositionRiskLimitData
    {
        [JsonConstructor]
        public PositionRiskLimitData(string userId, string symbol, string positionSide, decimal size, decimal positionValue, decimal entryPrice, int riskId, decimal autoAddMargin, decimal leverage, decimal positionMargin, decimal liqPrice, decimal bustPrice, decimal occClosingFee, decimal occFundingFee, decimal takeProfit, decimal stopLoss, decimal trailingStop, string positionStatus, decimal orderMargin, decimal walletBalance, decimal realisedPnl, decimal cumRealisedPnl, decimal positionSeq, DateTime? createdAt, DateTime? updatedAt)
        {
            UserId = userId;
            Symbol = symbol;
            PositionSide = positionSide;
            PositionSideType = PositionSide.ToEnum<OrderSideType>();
            Size = size;
            PositionValue = positionValue;
            EntryPrice = entryPrice;
            RiskId = riskId;
            AutoAddMargin = autoAddMargin;
            Leverage = leverage;
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
            OrderMargin = orderMargin;
            WalletBalance = walletBalance;
            RealisedPnl = realisedPnl;
            CumRealisedPnl = cumRealisedPnl;
            PositionSeq = positionSeq;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        [JsonRequired, JsonProperty("user_id")]
        public string UserId { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("side")]
        public string PositionSide { get; }
        public OrderSideType PositionSideType { get; }
        [JsonRequired, JsonProperty("size")]
        public decimal Size { get; }
        [JsonRequired, JsonProperty("position_value")]
        public decimal PositionValue { get; }
        [JsonRequired, JsonProperty("entry_price")]
        public decimal EntryPrice { get; }
        [JsonRequired, JsonProperty("risk_id")]
        public int RiskId { get; }
        [JsonRequired, JsonProperty("auto_add_margin")]
        public decimal AutoAddMargin { get; }
        [JsonRequired, JsonProperty("leverage")]
        public decimal Leverage { get; }
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
        [JsonRequired, JsonProperty("order_margin")]
        public decimal OrderMargin { get; }
        [JsonRequired, JsonProperty("wallet_balance")]
        public decimal WalletBalance { get; }
        [JsonRequired, JsonProperty("realised_pnl")]
        public decimal RealisedPnl { get; }
        [JsonRequired, JsonProperty("cum_realised_pnl")]
        public decimal CumRealisedPnl { get; }
        [JsonRequired, JsonProperty("position_seq")]
        public decimal PositionSeq { get; }
        [CanBeNull, JsonProperty("created_at")]
        public DateTime? CreatedAt { get; }
        [CanBeNull, JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; }
       
    }
    public sealed class ExtField 
    {
        [JsonConstructor]
        public ExtField(decimal trailingActive, decimal v)
        {
            TrailingActive = trailingActive;
            V = v;
        }

        [JsonRequired, JsonProperty("trailing_active")]
        public decimal TrailingActive { get; }
        [JsonRequired, JsonProperty("v")]
        public decimal V { get; }
    }
}
