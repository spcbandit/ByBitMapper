using JetBrains.Annotations;
using Newtonsoft.Json;

using System;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Wallet
{
    public sealed class AssetExchangeData
    {
        [JsonConstructor]
        public AssetExchangeData(string id, decimal exchangeRate, string fromCoin, string toCoin, decimal toAmount, decimal fromFee, decimal fromAmount, DateTime? createdAt)
        {
            Id = id;
            ExchangeRate = exchangeRate;
            FromCoin = fromCoin;
            ToCoin = toCoin;
            ToAmount = toAmount;
            FromFee = fromFee;
            FromAmount = fromAmount;
            CreatedAt = createdAt;
        }

        [JsonProperty("id")]
        public string Id { get; }
        [JsonProperty("exchange_rate")]
        public decimal ExchangeRate { get; }
        [JsonProperty("from_coin")]
        public string FromCoin { get; }
        [JsonProperty("to_coin")]
        public string ToCoin { get; }
        [JsonProperty("to_amount")]
        public decimal ToAmount { get; }
        [JsonProperty("from_fee")]
        public decimal FromFee { get; }
        [JsonProperty("from_amount")]
        public decimal FromAmount { get; }
        [CanBeNull, JsonProperty("created_at")]
        public DateTime? CreatedAt { get; }
    }
}
