using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.MarketStreams.Data;
using Newtonsoft.Json;

namespace BybitMapper.InversePerpetual.MarketStreams.Events
{
    /// <summary>
    /// Респонс информации об инструменте
    /// </summary>
    public sealed class InstrumentInfoEvent
    {
        [JsonConstructor]
        public InstrumentInfoEvent(string topic, DataEventType type, object dataUnnamed, string crossSeq, long timestampE6)
        {
            Topic = topic;
            Type = type;
            DataUnnamed = dataUnnamed;
            CrossSeq = crossSeq;
            TimestampE6 = timestampE6;
        }

        [JsonProperty("topic")]
        public string Topic { get; set; }
        [JsonProperty("type")]
        public DataEventType Type { get; set; }
        [JsonProperty("data")]
        public object DataUnnamed { get; set; }

        [JsonProperty("cross_seq")]
        public string CrossSeq { get; set; }
        [ JsonProperty("timestamp_e6")]
        public long TimestampE6 { get; set; }


        public InstrumentInfoData DataSnap { get { return new BaseJsonHandler<InstrumentInfoData>().HandleSingle(DataUnnamed.ToString()); } }
        public InstrumentInfoDeltaData DataDelta { get { return new BaseJsonHandler<InstrumentInfoDeltaData>().HandleSingle(DataUnnamed.ToString()); } }
    }
}
