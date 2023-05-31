using BybitMapper.Spot.RestV1.Data.ObjectDTO.Market;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Convertors
{
    internal sealed class OrderBookConvertor : JsonConverter<OrderRaw>
    {
        public override void WriteJson(JsonWriter writer, OrderRaw value, JsonSerializer serializer) =>
            throw new NotImplementedException();

        public override OrderRaw ReadJson([NotNull] JsonReader reader, [CanBeNull] Type objectType,
            [CanBeNull] OrderRaw existingValue, bool hasExistingValue, [CanBeNull] JsonSerializer serializer)
        {
            var data = JArray.Load(reader);

            return new OrderRaw(
                price: data[0].Value<decimal>(),
                size: data[1].Value<decimal>());
        }
    }
}
