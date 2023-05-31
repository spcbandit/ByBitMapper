using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using BybitMapper.Perpetual.UserStreams.Data.Enum;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.UserStreams.Data.Object
{
    /// <summary>
    /// WebSocket USDT Perpetual/Private Position response data
    /// </summary>
    public sealed class PositionPerpetualEventData
    {
        [JsonConstructor]
        public PositionPerpetualEventData(string userId, string symbol, string positionSide, decimal size, decimal positionValue, decimal entryPrice, 
            decimal liqPrice, decimal bustPrice, decimal leverage, string orderMargin, decimal positionMargin, decimal occClosingFee, 
            decimal takeProfit, string tpTriggerBy, decimal stopLoss, string slTriggerBy, string realisedPnl, decimal cumRealisedPnl, 
            string positionalStatus, PositionType positionType, decimal positionSeq)
        {
            UserId = userId;
            Symbol = symbol;
            PositionSide = positionSide;
            PositionSideType = (MarketStreams.Data.Enums.SideType)PositionSide.ToEnum<OrderSideType>();
            Size = size;
            PositionValue = positionValue;
            EntryPrice = entryPrice;
            LiqPrice = liqPrice;
            BustPrice = bustPrice;
            Leverage = leverage;
            OrderMargin = orderMargin;
            PositionMargin = positionMargin;
            OccClosingFee = occClosingFee;
            TakeProfit = takeProfit;
            TpTriggerBy = tpTriggerBy;
            TriggeByType1 = TpTriggerBy.ToEnum<TriggerPriceType>();
            StopLoss = stopLoss;
            SlTriggerBy = slTriggerBy;
            TriggeByType2 = SlTriggerBy.ToEnum<TriggerPriceType>();
            RealisedPnl = realisedPnl;
            CumRealisedPnl = cumRealisedPnl;
            PositionalStatus = positionalStatus;
            PositionType = positionType;
            PositionSeq = positionSeq;
        }


        [ JsonProperty("user_id")]
        public string UserId { get; }
        [ JsonProperty("symbol")]
        public string Symbol { get; }
        [ JsonProperty("side")]
        public string PositionSide { get; }
        public MarketStreams.Data.Enums.SideType PositionSideType { get; }
        [ JsonProperty("size")]
        public decimal Size { get; }
        [ JsonProperty("position_value")]
        public decimal PositionValue { get; }
        [ JsonProperty("entry_price")]
        public decimal EntryPrice { get; }
        [JsonProperty("liq_price")]
        public decimal LiqPrice { get; }
        [JsonProperty("bust_price")]
        public decimal BustPrice { get; }
        [JsonProperty("leverage")]
        public decimal Leverage { get; }
        [JsonProperty("order_margin")]
        public string OrderMargin { get; }
        [JsonProperty("position_margin")]
        public decimal PositionMargin { get; }
        [JsonProperty("occ_closing_fee")]
        public decimal OccClosingFee { get; }
        [JsonProperty("take_profit")]
        public decimal TakeProfit { get; }

        [JsonProperty("tp_trigger_by")]
        public string TpTriggerBy { get; }
        public TriggerPriceType TriggeByType1 { get; }
        [JsonProperty("stop_loss")]
        public decimal StopLoss { get; }
        [JsonProperty("sl_trigger_by")]
        public string SlTriggerBy { get; }
        public TriggerPriceType TriggeByType2 { get; }
        [JsonProperty("realised_pnl")]
        public string RealisedPnl { get; }
        [JsonProperty("cum_realised_pnl")]
        public decimal CumRealisedPnl { get; }
        [JsonProperty("position_status")]
        public string PositionalStatus { get; }
        public PositionType PositionType { get; }

        [ JsonProperty("position_seq")]
        public decimal PositionSeq { get; }
        

    }
}

