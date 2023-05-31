using BybitMapper.Spot.MarketStreams.Data;

using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Spot.MarketStreams.Events
{
    /// <summary>
    /// Респонс подписки на инструменты СПОТ
    /// </summary>
    public class InstrumentInfoEvent
    {
        [JsonConstructor]
        public InstrumentInfoEvent(string symbol, string symbolName, string topic, IReadOnlyList<InstrumentInfoData> data, bool firstMessage, long sendTime, bool shared)
        {
            Symbol = symbol;
            SymbolName = symbolName;
            Topic = topic;
            Data = data;
            FirstMessage = firstMessage;
            SendTime = sendTime;
            Shared = shared;
        }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("symbolName")]
        public string SymbolName { get; set; }
        [JsonProperty("topic")]
        public string Topic { get; set; }
        [JsonProperty("data")]
        public IReadOnlyList<InstrumentInfoData> Data { get; set; }
        [JsonProperty("f")]
        public bool FirstMessage { get; set; }
        [JsonProperty("sendTime")]
        public long SendTime { get; set; }
        [JsonProperty("shared")]
        public bool Shared { get; set; }
    }
}
