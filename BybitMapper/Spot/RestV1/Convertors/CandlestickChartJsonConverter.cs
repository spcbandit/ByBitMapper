using BybitMapper.Spot.RestV1.Responses.Market;
using JetBrains.Annotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace BybitMapper.Spot.RestV1.Convertors
{
    internal sealed class CandlestickChartJsonConverter : JsonConverter<Candle>
    {
        public override void WriteJson(JsonWriter writer, Candle value, JsonSerializer serializer) =>
            throw new NotImplementedException();

        public override Candle ReadJson([NotNull] JsonReader reader, [CanBeNull] Type objectType,
            [CanBeNull] Candle existingValue, bool hasExistingValue, [CanBeNull] JsonSerializer serializer)
        {
            var data = JArray.Load(reader);

            return new Candle(
                openTimeInMilliseconds: data[0].Value<ulong>(),
                openPrice: data[1].Value<decimal>(),
                highestPrice: data[2].Value<decimal>(),
                lowestPrice: data[3].Value<decimal>(),
                closePrice: data[4].Value<decimal>(),
                volume: data[5].Value<decimal>(),
                closeTimeInMilliseconds: data[6].Value<long>(),
                quoteAssetVolume: data[7].Value<decimal>(),
                tradesCount: data[8].Value<int>(),
                takerBuyBaseAssetVolume: data[9].Value<decimal>(),
                takerBuyQuoteAssetVolume: data[10].Value<decimal>());
        }
    }
}