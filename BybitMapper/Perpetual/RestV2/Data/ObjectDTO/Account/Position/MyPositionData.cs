using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Position
{
    public sealed class MyPositionData
    { 
        [JsonConstructor]
        public MyPositionData(string userId, string symbol, string side, decimal size, decimal positionValue, decimal entryPrice, 
            decimal liqPrice, decimal bustPrice, decimal leverage, bool isIsolated, decimal autoAddMargin, decimal positionMargin, 
            decimal occClosingFee, decimal realisedPnl, decimal cumRealisedPnl, decimal freeQty, string tpSlMode, decimal unrealisedPnl, 
            decimal deleverageIndicator, decimal riskId, decimal stopLoss, decimal takeProfit, decimal trailingStop, int? positionIdx)
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
            IsIsolated = isIsolated;
            AutoAddMargin = autoAddMargin;
            PositionMargin = positionMargin;
            OccClosingFee = occClosingFee;
            RealisedPnl = realisedPnl;
            CumRealisedPnl = cumRealisedPnl;
            FreeQty = freeQty;
            TpSlMode = tpSlMode;
            TpSlModeType = TpSlMode.ToEnum<TpSlModeType>();
            UnrealisedPnl = unrealisedPnl;
            DeleverageIndicator = deleverageIndicator;
            RiskId = riskId;
            StopLoss = stopLoss;
            TakeProfit = takeProfit;
            TrailingStop = trailingStop;
            PositionIdx = positionIdx;
        }

        [JsonProperty("position_idx")]
        public int? PositionIdx { get; }

        [JsonProperty("user_id")]
        public string UserId { get; }
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
        [JsonProperty("is_isolated")]
        public bool IsIsolated { get; }
        [JsonProperty("auto_add_margin")]
        public decimal AutoAddMargin { get; }
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
        [JsonProperty("tp_sl_mode")]
        public string TpSlMode { get; }
        public TpSlModeType TpSlModeType { get; }

        [JsonProperty("unrealised_pnl")]
        public decimal UnrealisedPnl { get; }

        [JsonProperty("deleverage_indicator")]
        public decimal DeleverageIndicator { get; }
        [JsonProperty("risk_id")]
        public decimal RiskId { get; }
        [JsonProperty("stop_loss")]
        public decimal StopLoss { get; }
        [JsonProperty("take_profit")]
        public decimal TakeProfit { get; }
        [JsonProperty("trailing_stop")]
        public decimal TrailingStop { get; }

    }
}
