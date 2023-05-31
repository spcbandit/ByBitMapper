using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using JetBrains.Annotations;

using BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account;

namespace BybitMapper.InversePerpetual.RestV2.Converters
{
    /*
	internal sealed class CoinBalanceJsonConverter : JsonConverter<CoinBalance>
	{
		public override void WriteJson(JsonWriter writer, CoinBalance value, JsonSerializer serializer) =>
            throw new NotImplementedException();

        public override CoinBalance ReadJson([NotNull] JsonReader reader, [CanBeNull] Type objectType,
            [CanBeNull] CoinBalance existingValue, bool hasExistingValue, [CanBeNull] JsonSerializer serializer)
        {
            var data = JObject.Load(reader);

            var list = new List<decimal>();

            foreach(var record in data)
			{
               list.Add(record.Value.Value<decimal>());
			}

            return new CoinBalance(list[0], list[1], list[2], list[3], list[4], list[5], list[6], 
                list[7], list[8], list[9], list[10], list[11], list[12]);

            //return new CoinBalance(
            //    equity : data[0].Value<decimal>(),
            //    availableBalnce : data[1].Value<decimal>(),
            //    usedMargin : data[2].Value<decimal>(),
            //    orderMargin : data[3].Value<decimal>(),
            //    positionMargin : data[4].Value<decimal>(),
            //    occClosingFee : data[5].Value<decimal>(),
            //    occFundingFee : data[6].Value<decimal>(),
            //    walletBalance : data[7].Value<decimal>(),
            //    realisedPnl : data[8].Value<decimal>(),
            //    unrealisedPnl : data[9].Value<decimal>(),
            //    cumRealisedPnl : data[10].Value<decimal>(),
            //    givenCash : data[11].Value<decimal>(),
            //    serviceCash : data[12].Value<decimal>()
            //);
        }
	}
    */
}
