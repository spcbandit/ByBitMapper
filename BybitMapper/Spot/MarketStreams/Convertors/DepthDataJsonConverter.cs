using BybitMapper.Spot.MarketStreams.Data;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.MarketStreams.Convertors
{
    public class DepthDataJsonConverter : JsonConverter<DeptBidAsk>
    {
        public override void WriteJson(JsonWriter writer, DeptBidAsk value, JsonSerializer serializer) =>
            throw new NotImplementedException();

        public override DeptBidAsk ReadJson([NotNull] JsonReader reader, [CanBeNull] Type objectType,
            [CanBeNull] DeptBidAsk existingValue, bool hasExistingValue, [CanBeNull] JsonSerializer serializer)
        {
            var data = JArray.Load(reader);

            return new DeptBidAsk(
                prices: data[0].Value<decimal>(),
                quantities: data[1].Value<decimal>());
        }
    }
}
