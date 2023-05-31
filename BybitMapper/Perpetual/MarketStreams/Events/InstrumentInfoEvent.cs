using BybitMapper.Handlers;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;
using BybitMapper.Perpetual.MarketStreams.Data.Object;

using JetBrains.Annotations;
using Newtonsoft.Json;

namespace BybitMapper.Perpetual.MarketStreams.Events
{
    /// <summary>
    /// USDT Perpetual MarketStreams Формат полного ответа на запрос InstrumentInfoEvent
    /// </summary>
    public sealed class InstrumentInfoEvent
    {
        [JsonConstructor]
        public InstrumentInfoEvent(string topic, DataEventType? type, object dataUnnamed, string crossSeq, long timestampE6)
        {
            Topic = topic;
            Type = type;
            DataUnnamed = dataUnnamed;
            CrossSeq = crossSeq;
            TimestampE6 = timestampE6;
        }

        [CanBeNull, JsonProperty("topic")]
        public string Topic { get; }
        [CanBeNull, JsonProperty("type")]
        public DataEventType? Type { get; }
        [CanBeNull, JsonProperty("data")]
        public object DataUnnamed { get; }

        [CanBeNull, JsonProperty("cross_seq")]
        public string CrossSeq { get; }
        [CanBeNull, JsonProperty("timestamp_e6")]
        public long TimestampE6 { get; }


        public InstrumentInfoSnapshotData DataSnap { get { return new BaseJsonHandler<InstrumentInfoSnapshotData>().HandleSingle(DataUnnamed.ToString()); } }
        public InstrumentInfoDeltaData DataDelta { get { return new BaseJsonHandler<InstrumentInfoDeltaData>().HandleSingle(DataUnnamed.ToString()); } }
    }
}
