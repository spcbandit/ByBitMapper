using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using BybitMapper.Extensions;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class InstrumentInfoDeltaData
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
        public InstrumentDeltaData(int id, string symbol, decimal? lastPriceE4, decimal? lastPrice, string lastTickDirection, TickDirectionType tickDirectionType, decimal? prevPrice24HE4, decimal? prevPrice24H, decimal? price24HPcntE6, decimal? highPrice24HE4, decimal? highPrice24H, decimal? lowPrice24HE4, decimal? lowPrice24H, decimal? prevPrice1HE4, decimal? prevPrice1H, decimal? price1HPcntE6, decimal? mArkPriceE4, decimal? markPrice, decimal? indexPriceE4, decimal? indexPrice, decimal? openInterestE8, decimal? totalTurnoverE8, decimal? turnover24HE8, decimal? totalVolumeE8, decimal? volume24HE8, decimal? fundingRateE6, decimal? predictedFundingRateE6, decimal? crossSeq, DateTime? createdAt, DateTime? updatedAt, DateTime? nextFundingTime, decimal? countDownHour, decimal? bid1PriceE4, decimal? bid1Price, decimal? ask1PriceE4, decimal? ask1Price)
        {
            Id = id;
            Symbol = symbol;
            LastPriceE4 = lastPriceE4;
            LastPrice = lastPrice;
            LastTickDirection = lastTickDirection;
            if (LastTickDirection != null) 
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
            MArkPriceE4 = mArkPriceE4;
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
            Bid1Price = bid1Price;
            Ask1PriceE4 = ask1PriceE4;
            Ask1Price = ask1Price;
        }

      

         [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("lastPriceE4")]
        public decimal? LastPriceE4 { get; set; }
        [JsonProperty("lastPrice")]
        public decimal? LastPrice { get; set; }
        [JsonProperty("lastTickDirection")]
        public string LastTickDirection { get; set; }
        public TickDirectionType TickDirectionType { get; set; }
        [JsonProperty("prevPrice24hE4")]
        public decimal? PrevPrice24hE4 { get; set; }
        [JsonProperty("prevPrice24h")]
        public decimal? PrevPrice24h { get; set; }
        [JsonProperty("price24hPcntE6")]
        public decimal? Price24hPcntE6 { get; set; }
        [JsonProperty("highPrice24hE4")]
        public decimal? HighPrice24hE4 { get; set; }
        [JsonProperty("highPrice24h")]
        public decimal? HighPrice24h { get; set; }
        [JsonProperty("lowPrice24hE4")]
        public decimal? LowPrice24hE4 { get; set; }
        [JsonProperty("lowPrice24h")]
        public decimal? LowPrice24h { get; set; }
        [JsonProperty("prevPrice1hE4")]
        public decimal? PrevPrice1hE4 { get; set; }
        [JsonProperty("prevPrice1h")]
        public decimal? PrevPrice1h { get; set; }
        [JsonProperty("price1hPcntE6")]
        public decimal? Price1hPcntE6 { get; set; }
        [JsonProperty("markPriceE4")]
        public decimal? MArkPriceE4 { get; set; }
        [JsonProperty("markPrice")]
        public decimal? MarkPrice { get; set; }
        [JsonProperty("indexPriceE4")]
        public decimal? IndexPriceE4 { get; set; }
        [JsonProperty("indexPrice")]
        public decimal? IndexPrice { get; set; }
        [JsonProperty("openInterestE8")]
        public decimal? OpenInterestE8 { get; set; }
        [JsonProperty("totalTurnoverE8")]
        public decimal? TotalTurnoverE8 { get; set; }
        [JsonProperty("turnover24hE8")]
        public decimal? Turnover24hE8 { get; set; }
        [JsonProperty("totalVolumeE8")]
        public decimal? TotalVolumeE8 { get; set; }
        [JsonProperty("volume24hE8")]
        public decimal? Volume24hE8 { get; set; }
        [JsonProperty("fundingRateE6")]
        public decimal? FundingRateE6 { get; set; }
        [JsonProperty("predictedFundingRateE6")]
        public decimal? PredictedFundingRateE6 { get; set; }
        [JsonProperty("crossSeq")]
        public decimal? CrossSeq { get; set; }
        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }
        [JsonProperty("nextFundingTime")]
        public DateTime? NextFundingTime { get; set; }
        [JsonProperty("countDownHour")]
        public decimal? CountDownHour { get; set; }
        [JsonProperty("bid1PriceE4")]
        public decimal? Bid1PriceE4 { get; set; }
        [JsonProperty("bid1Price")]
        public decimal? Bid1Price { get; set; }
        [JsonProperty("ask1PriceE4")]
        public decimal? Ask1PriceE4 { get; set; }
        [JsonProperty("ask1Price")]
        public decimal? Ask1Price { get; set; }
    }
}
