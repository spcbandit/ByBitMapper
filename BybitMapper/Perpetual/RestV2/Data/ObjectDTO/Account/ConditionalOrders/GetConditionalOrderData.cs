using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.ConditionalOrders
{
    public sealed class GetConditionalOrderData
    {
        [JsonConstructor]
        public GetConditionalOrderData(string currentPage, string lastPage, IReadOnlyList<DataGetConditionalOrderData> data)
        {
            CurrentPage = currentPage;
            LastPage = lastPage;
            Data = data;
        }

        [JsonProperty("current_page")]
        public string CurrentPage { get; }
        [JsonProperty("last_page")]
        public string LastPage { get; }
        [JsonProperty("data")]
        public IReadOnlyList<DataGetConditionalOrderData> Data { get; }
    }
}
