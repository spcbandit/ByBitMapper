using Newtonsoft.Json;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Position
{
    public sealed class UserTradeRecordsData
    {
        [JsonConstructor]
        public UserTradeRecordsData(long currentPage, IReadOnlyList<DataUserTradeRecordsData> data)
        {
            CurrentPage = currentPage;
            Data = data;
        }

        [JsonProperty("current_page")]
        public long CurrentPage { get; }
        [JsonProperty("data")]
        public IReadOnlyList<DataUserTradeRecordsData>  Data { get; }
    }
}
