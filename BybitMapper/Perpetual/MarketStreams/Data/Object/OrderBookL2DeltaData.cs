using JetBrains.Annotations;
using Newtonsoft.Json;

using System.Collections.Generic;

namespace BybitMapper.Perpetual.MarketStreams.Data.Object
{
    /// <summary>
    /// Коллекция объектов OrderBookL2DeltaData
    /// </summary>
    public sealed class OrderBookL2DeltaData
    {
        [JsonConstructor]
        public OrderBookL2DeltaData(IReadOnlyList<OrderBookL2Data> delete, IReadOnlyList<OrderBookL2Data> update, 
            IReadOnlyList<OrderBookL2Data> insert, long? transactTimeE6)
        {
            Delete = delete;
            Update = update;
            Insert = insert;
            TransactTimeE6 = transactTimeE6;
        }

        [CanBeNull, JsonProperty("delete")]
        public IReadOnlyList<OrderBookL2Data> Delete { get; }
        [CanBeNull, JsonProperty("update")]
        public IReadOnlyList<OrderBookL2Data> Update { get; }
        [CanBeNull, JsonProperty("insert")]
        public IReadOnlyList<OrderBookL2Data> Insert { get; }
        [CanBeNull, JsonProperty("transactTimeE6")]
        public long? TransactTimeE6 { get; }
    }
}
