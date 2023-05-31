using Newtonsoft.Json;

using System;

namespace BybitMapper.UsdcPerpetual.RestV2.Data.ObjectDTO.Market
{
    /// <summary>
    /// Информаци об инструменте
    /// </summary>
    public sealed class LatestSymbolInfoData
    {
        [JsonConstructor]
        public LatestSymbolInfoData(string symbol, decimal bid, decimal? bidIv, decimal bidSize, decimal ask, decimal? askIv, decimal askSize, decimal lastPrice, decimal openInterest, 
            decimal indexPrice, decimal markPrice, decimal? markPriceIv, decimal change24h, decimal high24h, decimal low24h, decimal volume24h, decimal turnover24h, decimal totalVolume, 
            decimal totalTurnover, decimal fundingRate, decimal predictedFundingRate, DateTime nextFundingTime, int countdownHour, decimal? predictedDeliveryPrice, decimal? underlyingPrice, 
            string delta, string gamma, string vega, string theta)
        {
            Symbol = symbol;
            Bid = bid;
            BidIv = bidIv;
            BidSize = bidSize;
            Ask = ask;
            AskIv = askIv;
            AskSize = askSize;
            LastPrice = lastPrice;
            OpenInterest = openInterest;
            IndexPrice = indexPrice;
            MarkPrice = markPrice;
            MarkPriceIv = markPriceIv;
            Change24h = change24h;
            High24h = high24h;
            Low24h = low24h;
            Volume24h = volume24h;
            Turnover24h = turnover24h;
            TotalVolume = totalVolume;
            TotalTurnover = totalTurnover;
            FundingRate = fundingRate;
            PredictedFundingRate = predictedFundingRate;
            NextFundingTime = nextFundingTime;
            CountdownHour = countdownHour;
            PredictedDeliveryPrice = predictedDeliveryPrice;
            UnderlyingPrice = underlyingPrice;
            Delta = delta;
            Gamma = gamma;
            Vega = vega;
            Theta = theta;
        }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("bid")]
        public decimal Bid { get; set; }
        [JsonProperty("bidIv")]
        public decimal? BidIv { get; set; }
        [JsonProperty("bidSize")]
        public decimal BidSize { get; set; }
        [JsonProperty("ask")]
        public decimal Ask { get; set; }
        [JsonProperty("askIv")]
        public decimal? AskIv { get; set; }
        [JsonProperty("askSize")]
        public decimal AskSize { get; set; }
        [JsonProperty("lastPrice")]
        public decimal LastPrice { get; set; }
        [JsonProperty("openInterest")]
        public decimal OpenInterest { get; set; }
        [JsonProperty("indexPrice")]
        public decimal IndexPrice { get; set; }
        [JsonProperty("markPrice")]
        public decimal MarkPrice { get; set; }
        [JsonProperty("markPriceIv")]
        public decimal? MarkPriceIv { get; set; }
        [JsonProperty("change24h")]
        public decimal Change24h { get; set; }
        [JsonProperty("high24h")]
        public decimal High24h { get; set; }
        [JsonProperty("low24h")]
        public decimal Low24h { get; set; }
        [JsonProperty("volume24h")]
        public decimal Volume24h { get; set; }
        [JsonProperty("turnover24h")]
        public decimal Turnover24h { get; set; }
        [JsonProperty("totalVolume")]
        public decimal TotalVolume { get; set; }
        [JsonProperty("totalTurnover")]
        public decimal TotalTurnover { get; set; }
        [JsonProperty("fundingRate")]
        public decimal FundingRate { get; set; }
        [JsonProperty("predictedFundingRate")]
        public decimal PredictedFundingRate { get; set; }
        [JsonProperty("nextFundingTime")]
        public DateTime NextFundingTime { get; set; }
        [JsonProperty("countdownHour")]
        public int CountdownHour { get; set; }
        [JsonProperty("predictedDeliveryPrice")]
        public decimal? PredictedDeliveryPrice { get; set; }
        [JsonProperty("underlyingPrice")]
        public decimal? UnderlyingPrice { get; set; }
        [JsonProperty("delta")]
        public string Delta { get; set; }
        [JsonProperty("gamma")]
        public string Gamma { get; set; }
        [JsonProperty("vega")]
        public string Vega { get; set; }
        [JsonProperty("theta")]
        public string Theta { get; set; }
    }
}
