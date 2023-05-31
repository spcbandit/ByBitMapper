using BybitMapper.Handlers;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects;

using Newtonsoft.Json;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Events
{
    /// <summary>
    /// Респонс подписки на инструменты
    /// </summary>
    public class InstrumentInfoEvent
    {
        [JsonConstructor]
        public InstrumentInfoEvent(string topic, DataEventType? type, object data, int crossSeq, long timestampE6)
        {
            Topic = topic;
            Type = type;
            Data = data;
            CrossSeq = crossSeq;
            TimestampE6 = timestampE6;
        }

        [JsonProperty("topic")]
        public string Topic { get; set; }
        [JsonProperty("type")]
        public DataEventType? Type { get; }
        [JsonProperty("data")]
        public object Data { get; set; }
        [JsonProperty("crossSeq")]
        public int CrossSeq { get; set; }
        [JsonProperty("timestampE6")]
        public long TimestampE6 { get; set; }

        public InstrumentInfoData DataSnap { get { return new BaseJsonHandler<InstrumentInfoData>().HandleSingle(Data.ToString()); } }
        public InstrumentInfoDeltaData DataDelta { get { return new BaseJsonHandler<InstrumentInfoDeltaData>().HandleSingle(Data.ToString()); } }
    }
}
