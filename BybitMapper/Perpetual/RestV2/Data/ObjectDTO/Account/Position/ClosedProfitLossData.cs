using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Position
{
    public sealed class ClosedProfitLossData
    {
        [JsonConstructor]
        public ClosedProfitLossData(long currentPage, IReadOnlyList<DataClosedProfitLossData> data)
        {
            CurrentPage = currentPage;
            Data = data;
        }

        [JsonProperty("current_page")]
        public long CurrentPage { get; }
        [JsonProperty("data")]
        public IReadOnlyList<DataClosedProfitLossData>  Data { get; }
    }
}
