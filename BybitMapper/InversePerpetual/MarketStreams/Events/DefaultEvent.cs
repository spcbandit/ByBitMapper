using BybitMapper.InversePerpetual.MarketStreams.Data;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Events
{
    public class DefaultEvent
    {
        [JsonConstructor]
        public DefaultEvent(bool? success, string retMsg, string connId, DefaultRequest request, string topic, DataEventType? type, ActionType? action, object data, string crossSeq, long? timestampE6)
        {
            Success = success;
            RetMsg = retMsg;
            ConnId = connId;
            Request = request;
            Topic = topic;
            Type = type;
            Action = action;
            Data = data;
            CrossSeq = crossSeq;
            TimestampE6 = timestampE6;
        }

        [CanBeNull, JsonProperty("success")]
        public bool? Success { get; }
        [CanBeNull, JsonProperty("ret_msg")]
        public string RetMsg { get; }
        [CanBeNull, JsonProperty("conn_id")]
        public string ConnId { get; }
        [CanBeNull, JsonProperty("request")]
        public DefaultRequest Request { get; }
        [CanBeNull, JsonProperty("topic")]
        public string Topic { get; }

        [CanBeNull, JsonProperty("type")]
        public DataEventType? Type { get; }

        [CanBeNull, JsonProperty("action")]
        public ActionType? Action { get; }
        [CanBeNull, JsonProperty("data")]
        public object Data { get; }
        [CanBeNull, JsonProperty("cross_seq")]
        public string CrossSeq { get; }
        [CanBeNull, JsonProperty("timestamp_e6")]
        public long? TimestampE6 { get; }

        public EventType? WSEventType
        {
            get
            {
                //For public methodes
                if (Topic?.Contains("instrument_info")==true)
                { return EventType.InstrumentInfo; }
                if (Topic?.Contains("orderBookL2_25") == true)
                { return EventType.OrderBook25; }
                else if (Topic?.Contains("orderBook_200") == true)
                { return EventType.OrderBook200; }
                else if (Topic?.Contains("trade") == true)
                { return EventType.Trade; }
                else if (Topic?.Contains("insurance") == true)
                { return EventType.Insurance; }
                else if (Topic?.Contains("klineV2") == true)
                { return EventType.Kline; }
                //For private methodes
                else if (Topic?.Contains("position") == true)
                { return EventType.Position; }
                else if (Topic?.Contains("execution") == true)
                { return EventType.Execution; }
                else if (Topic?.Contains("stop_order") == true)
                { return EventType.StopOrder; }
                else if (Topic?.Contains("order") == true)
                { return EventType.Order; }
                return EventType.None;
            }
        }
    }
}
