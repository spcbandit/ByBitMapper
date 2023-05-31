using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Market
{
    public sealed class SymbolOpenInterestData
    {
        [JsonConstructor]
        public SymbolOpenInterestData(decimal openInterest, long timestamp, string symbol)
        {
            OpenInterest = openInterest;
            Timestamp = timestamp;
            Symbol = symbol;
        }

        [JsonRequired, JsonProperty("open_interest")]
        public decimal OpenInterest { get; }
        [JsonRequired, JsonProperty("timestamp")]
        public long Timestamp { get; }
        [JsonRequired, JsonProperty("symbol")]
        public string Symbol{ get; }
    }
}
