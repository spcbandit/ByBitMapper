using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Market
{
    public class ContractInfoData
    {
        [JsonConstructor]
        public ContractInfoData(string symbol, string status, string baseCoin, string quoteCoin, decimal takerFeeRate, decimal makerFeeRate, 
            int minLeverage, int maxLeverage, decimal leverageStep, decimal minPrice, decimal maxPrice, decimal tickSize, decimal minTradingQty, 
            decimal maxTradingQty, decimal qtyStep, string deliveryFreeRate, string deliveryTime)
        {
            Symbol = symbol;
            Status = status;
            BaseCoin = baseCoin;
            QuoteCoin = quoteCoin;
            TakerFeeRate = takerFeeRate;
            MakerFeeRate = makerFeeRate;
            MinLeverage = minLeverage;
            MaxLeverage = maxLeverage;
            LeverageStep = leverageStep;
            MinPrice = minPrice;
            MaxPrice = maxPrice;
            TickSize = tickSize;
            MinTradingQty = minTradingQty;
            MaxTradingQty = maxTradingQty;
            QtyStep = qtyStep;
            DeliveryFreeRate = deliveryFreeRate;
            DeliveryTime = deliveryTime;
        }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("baseCoin")]
        public string BaseCoin { get; set; }
        [JsonProperty("quoteCoin")]
        public string QuoteCoin { get; set; }
        [JsonProperty("takerFeeRate")]
        public decimal TakerFeeRate { get; set; }
        [JsonProperty("makerFeeRate")]
        public decimal MakerFeeRate { get; set; }
        [JsonProperty("minLeverage")]
        public int MinLeverage { get; set; }
        [JsonProperty("maxLeverage")]
        public int MaxLeverage { get; set; }
        [JsonProperty("leverageStep")]
        public decimal LeverageStep { get; set; }
        [JsonProperty("minPrice")]
        public decimal MinPrice { get; set; }
        [JsonProperty("maxPrice")]
        public decimal MaxPrice { get; set; }
        [JsonProperty("tickSize")]
        public decimal TickSize { get; set; }
        [JsonProperty("minTradingQty")]
        public decimal MinTradingQty { get; set; }
        [JsonProperty("maxTradingQty")]
        public decimal MaxTradingQty { get; set; }
        [JsonProperty("qtyStep")]
        public decimal QtyStep { get; set; }
        [CanBeNull,JsonProperty("deliveryFeeRate")]
        public string DeliveryFreeRate { get; set; }
        [JsonProperty("deliveryTime")]
        public string DeliveryTime { get; set; }

    }
}