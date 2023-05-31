using System;
using BybitMapper.Spot.MarketStreamsV3.Data;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BybitMapper.Spot.MarketStreamsV3.Convertors
{
    public class DepthDataJsonConverterV3 : JsonConverter<DeptBidAsk>
    {
        public override void WriteJson(JsonWriter writer, DeptBidAsk value, JsonSerializer serializer) =>
            throw new NotImplementedException();

        public override DeptBidAsk ReadJson([NotNull] JsonReader reader, [CanBeNull] Type objectType,
            [CanBeNull] DeptBidAsk existingValue, bool hasExistingValue, [CanBeNull] JsonSerializer serializer)
        {
            var data = JArray.Load(reader);

            return new DeptBidAsk(
                price: data[0].Value<decimal>(),
                quantity: data[1].Value<decimal>());
        }
    }
}
