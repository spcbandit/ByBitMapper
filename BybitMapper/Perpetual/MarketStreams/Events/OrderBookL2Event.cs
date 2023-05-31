using BybitMapper.Handlers;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;
using BybitMapper.Perpetual.MarketStreams.Data.Object;
using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Perpetual.MarketStreams.Events
{
    /// <summary>
    /// USDT Perpetual MarketStreams Формат полного ответа на запрос OrderBookL2Event
    /// </summary>
    public sealed class OrderBookL2Event
    {
        [JsonConstructor]
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


        public OrderBookL2SnapshotData DataSnap { get { return new BaseJsonHandler<OrderBookL2SnapshotData>().HandleSingle(DataUnnamed.ToString()); } }
        public OrderBookL2DeltaData DataDelta { get { return new BaseJsonHandler<OrderBookL2DeltaData>().HandleSingle(DataUnnamed.ToString()); } }
    }
}
