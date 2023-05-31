using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;

namespace BybitMapper.Perpetual.MarketStreams.Data.Object
{
    /// <summary>
    /// Коллекция объектов InstrumentInfoDeltaData
    /// </summary>
    public sealed class InstrumentInfoDeltaData
    {
        [JsonConstructor]
        public InstrumentInfoDeltaData(IReadOnlyList<InstrumentDeltaData> update)
        {
            Update = update;
        }

        [JsonProperty("update")]
        public IReadOnlyList<InstrumentDeltaData> Update { get; }
    }

    public sealed class InstrumentDeltaData
    {

     [JsonConstructor]
        public InstrumentDeltaData(long id, string symbol, decimal? lastPriceE4, decimal? lastPrice, 
            string lastTickDirection, TickDirectionType? tickDirectionType, decimal? prevPrice24HE4, 
            decimal? prevPrice24H, decimal? price24HPcntE6, decimal? highPrice24HE4, decimal? highPrice24H, 
            decimal? lowPrice24HE4, decimal? lowPrice24H, decimal? prevPrice1HE4, decimal? prevPrice1H, decimal? price1HPcntE6, 
            decimal? markPriceE4, decimal? markPrice, decimal? indexPriceE4, decimal? indexPrice, decimal? openInterestE8, decimal? totalTurnoverE8, 
            decimal? turnover24HE8, decimal? totalVolumeE8, decimal? volume24HE8, decimal? fundingRateE6, decimal? predictedFundingRateE6,
            decimal? crossSeq, DateTime createdAt, DateTime updatedAt, DateTime? nextFundingTime, decimal? countDownHour, decimal? bid1PriceE4, 
            decimal? ask1PriceE4, decimal? bid1Price, decimal? ask1Price)
        {
            Id = id;
            Symbol = symbol;
            LastPriceE4 = lastPriceE4;
            LastPrice = lastPrice;
            LastTickDirection = lastTickDirection;
            if(LastTickDirection != null)
                TickDirectionType = LastTickDirection.ToEnum<TickDirectionType>();
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
            OpenInterestE8 = openInterestE8;
            TotalTurnoverE8 = totalTurnoverE8;
            Turnover24hE8 = turnover24HE8;
            TotalVolumeE8 = totalVolumeE8;
            Volume24hE8 = volume24HE8;
            FundingRateE6 = fundingRateE6;
            PredictedFundingRateE6 = predictedFundingRateE6;
            CrossSeq = crossSeq;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            NextFundingTime = nextFundingTime;
            CountDownHour = countDownHour;
            Bid1PriceE4 = bid1PriceE4;
            Ask1PriceE4 = ask1PriceE4;
            Bid1Price = bid1Price;
            Ask1Price = ask1Price;
        }

     
        [JsonProperty("id")]
        public long Id { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("last_price_e4")]
        public decimal? LastPriceE4 { get; }
        [JsonProperty("last_price")]
        public decimal? LastPrice { get; }
        [JsonProperty("last_tick_direction")]
        public string LastTickDirection { get; }
        
        public TickDirectionType? TickDirectionType { get; }
        [JsonProperty("prev_price_24h_e4")]
        public decimal? PrevPrice24hE4 { get; }
        [JsonProperty("prev_price_24h")]
        public decimal? PrevPrice24h { get; }
        [JsonProperty("price_24h_pcnt_e6")]
        public decimal? Price24hPcntE6 { get; }
        [JsonProperty("high_price_24h_e4")]
        public decimal? HighPrice24hE4 { get; }
        [JsonProperty("high_price_24h")]
        public decimal? HighPrice24h { get; }
        [JsonProperty("low_price_24h_e4")]
        public decimal? LowPrice24hE4 { get; }
        [JsonProperty("low_price_24h")]
        public decimal? LowPrice24h { get; }
        [JsonProperty("prev_price_1h_e4")]
        public decimal? PrevPrice1hE4 { get; }
        [JsonProperty("prev_price_1h")]
        public decimal? PrevPrice1h { get; }
        [JsonProperty("price_1h_pcnt_e6")]
        public decimal? Price1hPcntE6 { get; }
        [JsonProperty("mark_price_e4")]
        public decimal? MarkPriceE4 { get; }
        [JsonProperty("mark_price")]
        public decimal? MarkPrice { get; }
        [JsonProperty("index_price_e4")]
        public decimal? IndexPriceE4 { get; }
        [JsonProperty("index_price")]
        public decimal? IndexPrice { get; }
        [JsonProperty("open_interest_e8")]
        public decimal? OpenInterestE8 { get; }
        [JsonProperty("total_turnover_e8")]
        public decimal? TotalTurnoverE8 { get; }
        [JsonProperty("turnover_24h_e8")]
        public decimal? Turnover24hE8 { get; }
        [JsonProperty("total_volume_e8")]
        public decimal? TotalVolumeE8 { get; }
        [JsonProperty("volume_24h_e8")]
        public decimal? Volume24hE8 { get; }
        [JsonProperty("funding_rate_e6")]
        public decimal? FundingRateE6 { get; }
        [JsonProperty("predicted_funding_rate_e6")]
        public decimal? PredictedFundingRateE6 { get; }
        [JsonProperty("cross_seq")]
        public decimal? CrossSeq { get; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; }
        [JsonProperty("next_funding_time")]
        public DateTime? NextFundingTime { get; }
        [JsonProperty("count_down_hour")]
        public decimal? CountDownHour { get; }
        [JsonProperty("bid1_price_e4")]
        public decimal? Bid1PriceE4 { get; }
        [JsonProperty("ask1_price_e4")]
        public decimal? Ask1PriceE4 { get; }
        [JsonProperty("bid1_price")]
        public decimal? Bid1Price { get; }
        [JsonProperty("ask1_price")]
        public decimal? Ask1Price { get; }
    }
}
