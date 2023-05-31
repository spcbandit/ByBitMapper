using BybitMapper.Extensions;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
    public sealed class InstrumentInfoData
    {
        public InstrumentInfoData(int id, string symbol, decimal lastPriceE4, decimal lastPrice, decimal bid1PriceE4, decimal bid1Price, decimal ask1PriceE4, decimal ask1Price, string lastTickDirection, 
            decimal prevPrice24hE4, decimal prevPrice24h, decimal price24hPcntE6, decimal highPrice24hE4, decimal highPrice24h, decimal lowPrice24hE4, decimal lowPrice24h, decimal prevPrice1hE4, 
            decimal prevPrice1h, decimal price1hPcntE6, decimal markPriceE4, decimal markPrice, decimal indexPriceE4, decimal indexPrice, decimal openInterest, decimal openValueE8, decimal totalTurnoverE8, 
            decimal turnover24hE8, decimal totalVolume, decimal volume24h, decimal fundingRateE6, decimal predictedFundingRateE6, decimal crossAeq, DateTime createdAt, DateTime updatedAt, 
            DateTime nextFundingTime, int countdownHour, int fundingRateInterval)
        {
            Id = id;
            Symbol = symbol;
            LastPriceE4 = lastPriceE4;
            LastPrice = lastPrice;
            Bid1PriceE4 = bid1PriceE4;
            Bid1Price = bid1Price;
            Ask1PriceE4 = ask1PriceE4;
            Ask1Price = ask1Price;
            LastTickDirection = lastTickDirection;
            LastTickDirectionType = LastTickDirection.ToEnum<TickDirectionType>();
            PrevPrice24hE4 = prevPrice24hE4;
            PrevPrice24h = prevPrice24h;
            Price24hPcntE6 = price24hPcntE6;
            HighPrice24hE4 = highPrice24hE4;
            HighPrice24h = highPrice24h;
            LowPrice24hE4 = lowPrice24hE4;
            LowPrice24h = lowPrice24h;
            PrevPrice1hE4 = prevPrice1hE4;
            PrevPrice1h = prevPrice1h;
            Price1hPcntE6 = price1hPcntE6;
            MarkPriceE4 = markPriceE4;
            MarkPrice = markPrice;
            IndexPriceE4 = indexPriceE4;
            IndexPrice = indexPrice;
            OpenInterest = openInterest;
            OpenValueE8 = openValueE8;
            TotalTurnoverE8 = totalTurnoverE8;
            Turnover24hE8 = turnover24hE8;
            TotalVolume = totalVolume;
            Volume24h = volume24h;
            FundingRateE6 = fundingRateE6;
            PredictedFundingRateE6 = predictedFundingRateE6;
            CrossAeq = crossAeq;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            NextFundingTime = nextFundingTime;
            CountdownHour = countdownHour;
            FundingRateInterval = fundingRateInterval;
        }

        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("last_price_e4")]
        public decimal LastPriceE4 { get; set; }
        [JsonProperty("last_price")]
        public decimal LastPrice { get; set; }
        [JsonProperty("bid1_price_e4")]
        public decimal Bid1PriceE4 { get; set; }
        [JsonProperty("bid1_price")]
        public decimal Bid1Price { get; set; }
        [JsonProperty("ask1_price_e4")]
        public decimal Ask1PriceE4 { get; set; }
        [JsonProperty("ask1_price")]
        public decimal Ask1Price { get; set; }
        [JsonProperty("last_tick_direction")]
        public string LastTickDirection { get; set; }
        public TickDirectionType LastTickDirectionType { get; set; }
        [JsonProperty("prev_price_24h_e4")]
        public decimal PrevPrice24hE4 { get; set; }
        [JsonProperty("prev_price_24h")]
        public decimal PrevPrice24h { get; set; }
        [JsonProperty("price_24h_pcnt_e6")]
        public decimal Price24hPcntE6 { get; set; }
        [JsonProperty("high_price_24h_e4")]
        public decimal HighPrice24hE4 { get; set; }
        [JsonProperty("high_price_24h")]
        public decimal HighPrice24h { get; set; }
        [JsonProperty("low_price_24h_e4")]
        public decimal LowPrice24hE4 { get; set; }
        [JsonProperty("low_price_24h")]
        public decimal LowPrice24h { get; set; }
        [JsonProperty("prev_price_1h_e4")]
        public decimal PrevPrice1hE4 { get; set; }
        [JsonProperty("prev_price_1h")]
        public decimal PrevPrice1h { get; set; }
        [JsonProperty("price_1h_pcnt_e6")]
        public decimal Price1hPcntE6 { get; set; }
        [JsonProperty("mark_price_e4")]
        public decimal MarkPriceE4 { get; set; }
        [JsonProperty("mark_price")]
        public decimal MarkPrice { get; set; }
        [JsonProperty("index_price_e4")]
        public decimal IndexPriceE4 { get; set; }
        [JsonProperty("index_price")]
        public decimal IndexPrice { get; set; }
        [JsonProperty("open_interest")]
        public decimal OpenInterest { get; set; }
        [JsonProperty("open_value_e8")]
        public decimal OpenValueE8 { get; set; }
        [JsonProperty("total_turnover_e8")]
        public decimal TotalTurnoverE8 { get; set; }
        [JsonProperty("turnover_24h_e8")]
        public decimal Turnover24hE8 { get; set; }
        [JsonProperty("total_volume")]
        public decimal TotalVolume { get; set; }
        [JsonProperty("volume_24h")]
        public decimal Volume24h { get; set; }
        [JsonProperty("funding_rate_e6")]
        public decimal FundingRateE6 { get; set; }
        [JsonProperty("predicted_funding_rate_e6")]
        public decimal PredictedFundingRateE6 { get; set; }
        [JsonProperty("cross_seq")]
        public decimal CrossAeq { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
        [JsonProperty("next_funding_time")]
        public DateTime NextFundingTime { get; set; }
        [JsonProperty("countdown_hour")]
        public int CountdownHour { get; set; }
        [JsonProperty("funding_rate_interval")]
        public int FundingRateInterval { get; set; }
    }

    public class InstrumentInfoDeltaData
    {
        [JsonConstructor]
        public InstrumentInfoDeltaData(IReadOnlyList<InstrumentDeltaData> update)
        {
            Update = update;
        }

        [JsonProperty("update")]
        public IReadOnlyList<InstrumentDeltaData> Update { get; set; }
    }

    public sealed class InstrumentDeltaData
    {
        [JsonConstructor]
        public InstrumentDeltaData(int id, string symbol, decimal? lastPriceE4, decimal? lastPrice, decimal? bid1PriceE4, decimal? bid1Price, decimal? ask1PriceE4, decimal? ask1Price, string lastTickDirection, TickDirectionType? lastTickDirectionType, decimal? prevPrice24HE4, decimal? prevPrice24H, decimal? price24HPcntE6, decimal? highPrice24HE4, decimal? highPrice24H, decimal? lowPrice24HE4, decimal? lowPrice24H, decimal? prevPrice1HE4, decimal? prevPrice1H, decimal? price1HPcntE6, decimal? markPriceE4, decimal? markPrice, decimal? indexPriceE4, decimal? indexPrice, decimal? openInterest, decimal? openValueE8, decimal? totalTurnoverE8, decimal? turnover24HE8, decimal? totalVolume, decimal? volume24H, decimal? fundingRateE6, decimal? predictedFundingRateE6, decimal? crossAeq, DateTime? createdAt, DateTime? updatedAt, DateTime? nextFundingTime, int? countdownHour, int? fundingRateInterval)
        {
            Id = id;
            Symbol = symbol;
            LastPriceE4 = lastPriceE4;
            LastPrice = lastPrice;
            Bid1PriceE4 = bid1PriceE4;
            Bid1Price = bid1Price;
            Ask1PriceE4 = ask1PriceE4;
            Ask1Price = ask1Price;
            LastTickDirection = lastTickDirection;
            if(LastTickDirection != null)
                LastTickDirectionType = LastTickDirection.ToEnum<TickDirectionType>();
            PrevPrice24hE4 = prevPrice24HE4;
            PrevPrice24h = prevPrice24H;
            Price24hPcntE6 = price24HPcntE6;
            HighPrice24hE4 = highPrice24HE4;
            HighPrice24h = highPrice24H;
            LowPrice24hE4 = lowPrice24HE4;
            LowPrice24h = lowPrice24H;
            PrevPrice1hE4 = prevPrice1HE4;
            PrevPrice1h = prevPrice1H;
            Price1hPcntE6 = price1HPcntE6;
            MarkPriceE4 = markPriceE4;
            MarkPrice = markPrice;
            IndexPriceE4 = indexPriceE4;
            IndexPrice = indexPrice;
            OpenInterest = openInterest;
            OpenValueE8 = openValueE8;
            TotalTurnoverE8 = totalTurnoverE8;
            Turnover24hE8 = turnover24HE8;
            TotalVolume = totalVolume;
            Volume24h = volume24H;
            FundingRateE6 = fundingRateE6;
            PredictedFundingRateE6 = predictedFundingRateE6;
            CrossAeq = crossAeq;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            NextFundingTime = nextFundingTime;
            CountdownHour = countdownHour;
            FundingRateInterval = fundingRateInterval;
        }
        
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("last_price_e4")]
        public decimal? LastPriceE4 { get; set; }
        [JsonProperty("last_price")]
        public decimal? LastPrice { get; set; }
        [JsonProperty("bid1_price_e4")]
        public decimal? Bid1PriceE4 { get; set; }
        [JsonProperty("bid1_price")]
        public decimal? Bid1Price { get; set; }
        [JsonProperty("ask1_price_e4")]
        public decimal? Ask1PriceE4 { get; set; }
        [JsonProperty("ask1_price")]
        public decimal? Ask1Price { get; set; }
        [JsonProperty("last_tick_direction")]
        public string LastTickDirection { get; set; }
        public TickDirectionType? LastTickDirectionType { get; set; }
        [JsonProperty("prev_price_24h_e4")]
        public decimal? PrevPrice24hE4 { get; set; }
        [JsonProperty("prev_price_24h")]
        public decimal? PrevPrice24h { get; set; }
        [JsonProperty("price_24h_pcnt_e6")]
        public decimal? Price24hPcntE6 { get; set; }
        [JsonProperty("high_price_24h_e4")]
        public decimal? HighPrice24hE4 { get; set; }
        [JsonProperty("high_price_24h")]
        public decimal? HighPrice24h { get; set; }
        [JsonProperty("low_price_24h_e4")]
        public decimal? LowPrice24hE4 { get; set; }
        [JsonProperty("low_price_24h")]
        public decimal? LowPrice24h { get; set; }
        [JsonProperty("prev_price_1h_e4")]
        public decimal? PrevPrice1hE4 { get; set; }
        [JsonProperty("prev_price_1h")]
        public decimal? PrevPrice1h { get; set; }
        [JsonProperty("price_1h_pcnt_e6")]
        public decimal? Price1hPcntE6 { get; set; }
        [JsonProperty("mark_price_e4")]
        public decimal? MarkPriceE4 { get; set; }
        [JsonProperty("mark_price")]
        public decimal? MarkPrice { get; set; }
        [JsonProperty("index_price_e4")]
        public decimal? IndexPriceE4 { get; set; }
        [JsonProperty("index_price")]
        public decimal? IndexPrice { get; set; }
        [JsonProperty("open_interest")]
        public decimal? OpenInterest { get; set; }
        [JsonProperty("open_value_e8")]
        public decimal? OpenValueE8 { get; set; }
        [JsonProperty("total_turnover_e8")]
        public decimal? TotalTurnoverE8 { get; set; }
        [JsonProperty("turnover_24h_e8")]
        public decimal? Turnover24hE8 { get; set; }
        [JsonProperty("total_volume")]
        public decimal? TotalVolume { get; set; }
        [JsonProperty("volume_24h")]
        public decimal? Volume24h { get; set; }
        [JsonProperty("funding_rate_e6")]
        public decimal? FundingRateE6 { get; set; }
        [JsonProperty("predicted_funding_rate_e6")]
        public decimal? PredictedFundingRateE6 { get; set; }
        [JsonProperty("cross_seq")]
        public decimal? CrossAeq { get; set; }
        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        [JsonProperty("next_funding_time")]
        public DateTime? NextFundingTime { get; set; }
        [JsonProperty("countdown_hour")]
        public int? CountdownHour { get; set; }
        [JsonProperty("funding_rate_interval")]
        public int? FundingRateInterval { get; set; }
    }
}
