using BybitMapper.Spot.MarketStreamsV3.Data;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Spot.MarketStreamsV3.Events
{
    /// <summary>
    /// Дефолтная подписка
    /// </summary>
    public class DefaultEvent
    {
        [JsonConstructor]
        public DefaultEvent(string topic, string auth)
        {
            Topic = topic;
            Auth = auth;
        }
        [CanBeNull, JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("auth")]
        public string Auth { get; }

        public EventType? WSEventType
        {
            get
            {
                if (Topic?.Contains("trade") == true)
                { return EventType.Trade; }
                else if (Topic?.Contains("orderbook") == true)
                { return EventType.Depth; }
                else if (Topic?.Contains("kline") == true)
                { return EventType.Kline; }
                else if (Topic?.Contains("tickers") == true)
                { return EventType.Tickers; }
                else if (Topic?.Contains("bookticker") == true)
                { return EventType.BookTicker; }
                return EventType.None;
            }
        }
    }
}
