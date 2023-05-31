using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.MarketStreams.Data;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Events
{
    public sealed class OrderBookL2Event
    {
        public OrderBookL2Event(string topic, DataEventType? type, ActionType? action, object dataUnnamed, string crossSeq, long timestampE6)
        {
            Topic = topic;
            Type = type;
            Action = action;
            DataUnnamed = dataUnnamed;
            CrossSeq = crossSeq;
            TimestampE6 = timestampE6;
        }

        [CanBeNull, JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("type")]
        public DataEventType? Type { get; }
        [CanBeNull, JsonProperty("action")]
        public ActionType? Action { get; }
        [CanBeNull, JsonProperty("data")]
        public object DataUnnamed { get; }

        [CanBeNull, JsonProperty("cross_seq")]
        public string CrossSeq { get; }
        [CanBeNull, JsonProperty("timestamp_e6")]
        public long TimestampE6 { get; }


        public IReadOnlyList<OrderBook25Data> DataSnap { get { return new BaseJsonHandler<OrderBook25Data>().HandleSnapshot(DataUnnamed.ToString()); } }
        public OrderBook25ObjectData DataObject { get { return new BaseJsonHandler<OrderBook25ObjectData>().HandleSingle(DataUnnamed.ToString()); } }
    }
}
