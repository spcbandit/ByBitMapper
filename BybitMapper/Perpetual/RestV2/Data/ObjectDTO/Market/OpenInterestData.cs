using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class OpenInterestData
    {
        [JsonConstructor]
        public OpenInterestData(long openInterest, long timestamp, string symbol)
        {
            OpenInterest = openInterest;
            Timestamp = timestamp;
            Symbol = symbol;
        }

        [JsonProperty("open_interest")]
        public long OpenInterest { get; }
        [JsonProperty("timestamp")]
        public long Timestamp { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
    }
}
