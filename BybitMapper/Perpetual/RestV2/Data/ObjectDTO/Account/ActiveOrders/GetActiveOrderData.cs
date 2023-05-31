using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.ActiveOrders
{
    public sealed class GetActiveOrderData
    {
        [JsonConstructor]
        public GetActiveOrderData(string currentPage, string lastPage, IReadOnlyList<PlaceActiveOrderData> data)
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
        public IReadOnlyList<PlaceActiveOrderData> Data { get; }
    }
}
