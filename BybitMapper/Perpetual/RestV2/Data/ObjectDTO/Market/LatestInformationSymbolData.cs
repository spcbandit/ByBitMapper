using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;
using Newtonsoft.Json;
using System;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class LatestInformationSymbolData
    {
        [JsonConstructor]
        public LatestInformationSymbolData(string symbol, decimal bidPrice, decimal askPrice, decimal lastPrice, string lastTickDirection, decimal prevPrice24h, decimal price24hPcnt, decimal highPrice24h, decimal lowPrice24h, decimal prevPrice1h, decimal price1hPcnt, 
            decimal markPrice, decimal indexPrice, decimal openInterest, decimal openValue, decimal totalTurnover, decimal turnover24h, decimal totalVolume, decimal volume24h, decimal fundingRate, decimal predictedFundingRate, DateTime? nextFundingTime, int countdownHour)
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

        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("bid_price")]
        public decimal BidPrice { get; }
        [JsonProperty("ask_price")]
        public decimal AskPrice { get; }
        [JsonProperty("last_price")]
        public decimal LastPrice { get; }
        [JsonProperty("last_tick_direction")]
        public string LastTickDirection { get; }
        public TickDirectionType LastTickDirectionType { get; }
        [JsonProperty("prev_price_24h")]
        public decimal PrevPrice24h { get; }
        [JsonProperty("price_24h_pcnt")]
        public decimal Price24hPcnt { get; }
        [JsonProperty("high_price_24h")]
        public decimal HighPrice24h { get; }
        [JsonProperty("low_price_24h")]
        public decimal LowPrice24h { get; }
        [JsonProperty("prev_price_1h")]
        public decimal PrevPrice1h { get; }
        [JsonProperty("price_1h_pcnt")]
        public decimal Price1hPcnt { get; }
        [JsonProperty("mark_price")]
        public decimal MarkPrice { get; }
        [JsonProperty("index_price")]
        public decimal IndexPrice { get; }
        [JsonProperty("open_interest")]
        public decimal OpenInterest { get; }
        [JsonProperty("open_value")]
        public decimal OpenValue { get; }
        [JsonProperty("total_turnover")]
        public decimal TotalTurnover { get; }
        [JsonProperty("turnover_24h")]
        public decimal Turnover24h { get; }
        [JsonProperty("total_volume")]
        public decimal TotalVolume { get; }
        [JsonProperty("volume_24h")]
        public decimal Volume24h { get; }
        [JsonProperty("funding_rate")]
        public decimal FundingRate { get; }
        [JsonProperty("predicted_funding_rate")]
        public decimal PredictedFundingRate { get; }
        [JsonProperty("next_funding_time")]
        public DateTime? NextFundingTime { get; }
        [JsonProperty("countdown_hour")]
        public int CountdownHour { get; }

    }
}
