using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using Newtonsoft.Json;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public class SetTradingStopResult
    {
          [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("user_id")]
        public int? UserId { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("side")]
        public string Side { get; set; }
        public OrderSideType? SideEnum
        {
            get { return Side?.ToEnum<OrderSideType>(); }
        }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("position_value")]
        public double? PositionValue { get; set; }

        [JsonProperty("entry_price")]
        public double? EntryPrice { get; set; }

        [JsonProperty("risk_id")]
        public int? RiskId { get; set; }

        [JsonProperty("auto_add_margin")]
        public int? AutoAddMargin { get; set; }

        [JsonProperty("leverage")]
        public int? Leverage { get; set; }

        [JsonProperty("position_margin")]
        public double? PositionMargin { get; set; }

        [JsonProperty("liq_price")]
        public double? LiqPrice { get; set; }

        [JsonProperty("bust_price")]
        public int? BustPrice { get; set; }

        [JsonProperty("occ_closing_fee")]
        public double? OccClosingFee { get; set; }

        [JsonProperty("occ_funding_fee")]
        public int? OccFundingFee { get; set; }

        [JsonProperty("take_profit")]
        public int? TakeProfit { get; set; }

        [JsonProperty("stop_loss")]
        public int? StopLoss { get; set; }

        [JsonProperty("trailing_stop")]
        public int? TrailingStop { get; set; }

        [JsonProperty("position_status")]
        public string PositionStatus { get; set; }
        public PositionStatusType? PositionStatusEnum
        {
            get { return PositionStatus?.ToEnum<PositionStatusType>(); }
        }

        [JsonProperty("deleverage_indicator")]
        public int? DeleverageIndicator { get; set; }

        [JsonProperty("oc_calc_data")]
        public string OcCalcData { get; set; }

        [JsonProperty("order_margin")]
        public double? OrderMargin { get; set; }

        [JsonProperty("wallet_balance")]
        public double? WalletBalance { get; set; }

        [JsonProperty("realised_pnl")]
        public int? RealisedPnl { get; set; }

        [JsonProperty("cum_realised_pnl")]
        public double? CumRealisedPnl { get; set; }

        [JsonProperty("cum_commission")]
        public int? CumCommission { get; set; }

        [JsonProperty("cross_seq")]
        public long? CrossSeq { get; set; }

        [JsonProperty("position_seq")]
        public int? PositionSeq { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("ext_fields")]
        public SetTradingStopExtFields ExtFields { get; set; }
    }
}