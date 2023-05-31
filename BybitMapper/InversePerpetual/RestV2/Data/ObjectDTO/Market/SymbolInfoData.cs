using BybitMapper.Extensions;
using JetBrains.Annotations;
using Newtonsoft.Json;

using System;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class SymbolInfoData
    {
        [JsonConstructor]
        public SymbolInfoData(string symbol, decimal bidPrice, decimal askPrice, decimal lastPrice, string lastTickDirection, decimal prevPrice24h, decimal price24hPcnt, decimal highPrice24h, 
            decimal lowPrice24h, decimal prevPrice1h, decimal price1hPcnt, decimal markPrice, decimal indexPrice, decimal openInterest, decimal openValue, decimal totalTurnover, decimal turnover24h, 
            decimal totalVolume, decimal volume24h, decimal fundingRate, decimal predictedFundingRate, DateTime? nextFundingTime, int countdownHour)
        {
            Symbol = symbol;
            BidPrice = bidPrice;
            AskPrice = askPrice;
            LastPrice = lastPrice;
            LastTickDirection = lastTickDirection;
            LastTickDirectionType = LastTickDirection.ToEnum<TickDirectionType>();
            PrevPrice24h = prevPrice24h;
            Price24hPcnt = price24hPcnt;
            HighPrice24h = highPrice24h;
            LowPrice24h = lowPrice24h;
            PrevPrice1h = prevPrice1h;
            Price1hPcnt = price1hPcnt;
            MarkPrice = markPrice;
            IndexPrice = indexPrice;
            OpenInterest = openInterest;
            OpenValue = openValue;
            TotalTurnover = totalTurnover;
            Turnover24h = turnover24h;
            TotalVolume = totalVolume;
            Volume24h = volume24h;
            FundingRate = fundingRate;
            PredictedFundingRate = predictedFundingRate;
            NextFundingTime = nextFundingTime;
            CountdownHour = countdownHour;
        }

        [CanBeNull, JsonProperty("symbol")]
        public string Symbol { get; set; }
        [CanBeNull, JsonProperty("bid_price")]
        public decimal BidPrice { get; set; }
        [CanBeNull, JsonProperty("ask_price")]
        public decimal AskPrice { get; set; }
        [CanBeNull, JsonProperty("last_price")]
        public decimal LastPrice { get; set; }
        [CanBeNull, JsonProperty("last_tick_direction")]
        public string LastTickDirection { get; set; }
        public TickDirectionType LastTickDirectionType { get; set; }
        [JsonRequired, JsonProperty("prev_price_24h")]
        public decimal PrevPrice24h { get; set; }
        [CanBeNull, JsonProperty("price_24h_pcnt")]
        public decimal Price24hPcnt { get; set; }
        [CanBeNull, JsonProperty("high_price_24h")]
        public decimal HighPrice24h { get; }
        [CanBeNull, JsonProperty("low_price_24h")]
        public decimal LowPrice24h { get; set; }
        [CanBeNull, JsonProperty("prev_price_1h")]
        public decimal PrevPrice1h { get; set; }
        [CanBeNull, JsonProperty("price_1h_pcnt")]
        public decimal Price1hPcnt { get; set; }
        [CanBeNull, JsonProperty("mark_price")]
        public decimal MarkPrice { get; set; }
        [CanBeNull, JsonProperty("index_price")]
        public decimal IndexPrice { get; set; }
        [CanBeNull, JsonProperty("open_interest")]
        public decimal OpenInterest { get; set; }
        [CanBeNull, JsonProperty("open_value")]
        public decimal OpenValue { get; set; }
        [CanBeNull, JsonProperty("total_turnover")]
        public decimal TotalTurnover { get; set; }
        [CanBeNull, JsonProperty("turnover_24h")]
        public decimal Turnover24h { get; set; }
        [CanBeNull, JsonProperty("total_volume")]
        public decimal TotalVolume { get; set; }
        [CanBeNull, JsonProperty("volume_24h")]
        public decimal Volume24h { get; set; }
        [CanBeNull, JsonProperty("funding_rate")]
        public decimal FundingRate { get; set; }
        [CanBeNull, JsonProperty("predicted_funding_rate")]
        public decimal PredictedFundingRate { get; set; }
        [CanBeNull, JsonProperty("next_funding_time")]
        public DateTime? NextFundingTime { get; set; }
        [CanBeNull, JsonProperty("countdown_hour")]
        public int CountdownHour { get; set; }
    }
}
