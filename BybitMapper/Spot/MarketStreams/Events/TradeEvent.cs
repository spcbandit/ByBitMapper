using BybitMapper.Spot.MarketStreams.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams.Events
{
    public class TradeEvent
    {
        [JsonConstructor]
        public TradeEvent(string symbol, string symbolName, string topic, TradeParamsData @params, IReadOnlyList<TradeData> data, bool firstMessage, double sendTime, bool shared)
        {
            Symbol = symbol;
            SymbolName = symbolName;
            Topic = topic;
            Params = @params;
            Data = data;
            FirstMessage = firstMessage;
            SendTime = sendTime;
            Shared = shared;
        }

        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("symbolName")]
        public string SymbolName { get; }
        [JsonProperty("topic")]
        public string Topic { get; }
        [JsonProperty("params")]
        public TradeParamsData Params { get; }
        [JsonProperty("data")]
        public IReadOnlyList<TradeData> Data { get; }
        [JsonProperty("f")]
        public bool? FirstMessage { get; }
        [JsonProperty("sendTime")]
        public double SendTime { get; }
        [JsonProperty("shared")]
        public bool? Shared { get; }
    }
}
