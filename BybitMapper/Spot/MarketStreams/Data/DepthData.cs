using BybitMapper.Spot.MarketStreams.Convertors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams.Data
{
    public class DepthData
    {
        [JsonConstructor]
        public DepthData(int exchangeId, string tradingPair, long timestamp, string version, IReadOnlyList<DeptBidAsk> bid, IReadOnlyList<DeptBidAsk> ask, int pleaseIgnore)
        {
            ExchangeId = exchangeId;
            TradingPair = tradingPair;
            Timestamp = timestamp;
            Version = version;
            Bid = bid;
            Ask = ask;
            PleaseIgnore = pleaseIgnore;
        }

        [JsonProperty("e")]
        public int ExchangeId { get; }
        [JsonProperty("s")]
        public string TradingPair { get; }
        [JsonProperty("t")]
        public long Timestamp { get; }
        [JsonProperty("v")]
        public string Version { get; }
        [JsonProperty("b")]
        public IReadOnlyList<DeptBidAsk> Bid { get; }
        [JsonProperty("a")]
        public IReadOnlyList<DeptBidAsk> Ask { get; }
        [JsonProperty("o")]
        public int PleaseIgnore { get; }
    }
    [JsonConverter(typeof(DepthDataJsonConverter))]
    public class DeptBidAsk
    {
        public DeptBidAsk( decimal prices, decimal quantities)
        {
            Prices = prices;
            Quantities = quantities;           
        }

        public decimal Prices { get; set; }
        public decimal Quantities { get; set; }
    }
}
