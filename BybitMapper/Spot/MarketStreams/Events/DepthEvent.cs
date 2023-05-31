using BybitMapper.Spot.MarketStreams.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams.Events
{
    public class DepthEvent
    {
        [JsonConstructor]
        public DepthEvent(string symbol, string symbolName, string topic, DepthParamsData @params, IReadOnlyList<DepthData> data, bool firstMessage, long sendTime, bool shared)
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
        public DepthParamsData Params { get; }
        [JsonProperty("data")]
        public IReadOnlyList<DepthData> Data { get; }
        [JsonProperty("f")]
        public bool FirstMessage { get; }
        [JsonProperty("sendTime")]
        public long SendTime { get; }
        [JsonProperty("shared")]
        public bool Shared { get; }
    }
}
