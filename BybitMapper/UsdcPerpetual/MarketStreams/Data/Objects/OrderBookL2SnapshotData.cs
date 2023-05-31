using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Data.Objects
{
    public sealed class OrderBookL2SnapshotData
    {
        [JsonConstructor]
        public OrderBookL2SnapshotData(IReadOnlyList<OrderBookL2Data> orderBook)
        {
            OrderBook = orderBook;
        }

        [CanBeNull, JsonProperty("order_book")]
        public IReadOnlyList<OrderBookL2Data> OrderBook { get; }
    }
}
