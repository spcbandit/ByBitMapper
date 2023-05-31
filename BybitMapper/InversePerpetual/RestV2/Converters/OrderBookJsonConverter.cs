using BybitMapper.InversePerpetual.RestV2.Data;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace BybitMapper.InversePerpetual.RestV2.Converters
{
    //internal sealed class OrderBookJsonConverter : JsonConverter<OrderBook>
    //{
    //    public override void WriteJson(JsonWriter writer, OrderBook value, JsonSerializer serializer) =>
    //        throw new NotImplementedException();

    //    public override OrderBook ReadJson([NotNull] JsonReader reader, [CanBeNull] Type objectType,
    //        [CanBeNull] OrderBook existingValue, bool hasExistingValue, [CanBeNull] JsonSerializer serializer)
    //    {
    //        var data = JArray.Load(reader);

    //        return new OrderBook(data[0].Value<decimal>(), data[1].Value<decimal>());
    //    }
    //}
}