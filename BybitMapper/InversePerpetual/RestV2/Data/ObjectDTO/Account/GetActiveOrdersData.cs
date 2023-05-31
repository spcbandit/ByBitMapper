using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class GetActiveOrdersData
    {

        [JsonConstructor]
        public GetActiveOrdersData(List<PlaceOrderExtData> data, string cursor)
        {
            Data = data;
            Cursor = cursor;
        }

        //[JsonProperty("current_page")]
        //public int CurrentPage { get; }
        //[JsonProperty("last_page")]
        //public int LastPage { get; }
        [JsonProperty("data")]
        public List<PlaceOrderExtData> Data { get; }
        [CanBeNull, JsonProperty("cursor")]
        public string Cursor{ get; }
    }
}
