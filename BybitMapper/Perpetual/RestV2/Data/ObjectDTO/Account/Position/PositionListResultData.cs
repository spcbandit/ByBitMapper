using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;


namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Position
{
    public sealed class PositionListResultData
    {
        public PositionListResultData(long userId, string symbol, string side, decimal size, decimal positionValue, decimal entryPrice, 
            decimal liqPrice, decimal bustPrice, decimal leverage, decimal positionMargin, decimal occClosingFee, decimal realisedPnl, 
            decimal cumRealisedPnl, decimal freeQty)
        {
            UserId = userId;
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Size = size;
            PositionValue = positionValue;
            EntryPrice = entryPrice;
            LiqPrice = liqPrice;
            BustPrice = bustPrice;
            Leverage = leverage;
            PositionMargin = positionMargin;
            OccClosingFee = occClosingFee;
            RealisedPnl = realisedPnl;
            CumRealisedPnl = cumRealisedPnl;
            FreeQty = freeQty;
        }

        [JsonProperty("user_id")]
        public long UserId { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonProperty("size")]
        public decimal Size { get; }
        [JsonProperty("position_value")]
        public decimal PositionValue { get; }
        [JsonProperty("entry_price")]
        public decimal EntryPrice { get; }
        [JsonProperty("liq_price")]
        public decimal LiqPrice { get; }
        [JsonProperty("bust_price")]
        public decimal BustPrice { get; }
        [JsonProperty("leverage")]
        public decimal Leverage { get; }
        [JsonProperty("position_margin")]
        public decimal PositionMargin { get; }
        [JsonProperty("occ_closing_fee")]
        public decimal OccClosingFee { get; }
        [JsonProperty("realised_pnl")]
        public decimal RealisedPnl { get; }
        [JsonProperty("cum_realised_pnl")]
        public decimal CumRealisedPnl { get; }
        [JsonProperty("free_qty")]
        public decimal FreeQty { get; }
    }
}
