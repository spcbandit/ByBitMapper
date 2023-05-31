using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
    public class OrderBook25ObjectData
    {
        [JsonConstructor]
        public OrderBook25ObjectData(IReadOnlyList<OrderBook25Data> delete, IReadOnlyList<OrderBook25Data> update, IReadOnlyList<OrderBook25Data> insert, long? transactTimeE6)
        {
            Delete = delete;
            Update = update;
            Insert = insert;
            TransactTimeE6 = transactTimeE6;
        }

        [CanBeNull, JsonProperty("delete")]
        public IReadOnlyList<OrderBook25Data> Delete { get; }
        [CanBeNull, JsonProperty("update")]
        public IReadOnlyList<OrderBook25Data> Update { get; }
        [CanBeNull, JsonProperty("insert")]
        public IReadOnlyList<OrderBook25Data> Insert { get; }
        [CanBeNull, JsonProperty("transactTimeE6")]
        public long? TransactTimeE6 { get; }
    }
}
