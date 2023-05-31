using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV1.Data.ObjectDTO.Account
{
    public sealed class BalancesData
    {
        [JsonConstructor]
        public BalancesData(string coin, string coinId, string coinName, decimal total, decimal free, decimal locked)
        {
            Coin = coin;
            CoinId = coinId;
            CoinName = coinName;
            Total = total;
            Free = free;
            Locked = locked;
        }

        [JsonProperty("coin")]
        public string Coin { get; }
        [JsonProperty("coinId")]
        public string CoinId { get; }
        [JsonProperty("coinName")]
        public string CoinName { get; }
        [JsonProperty("total")]
        public decimal? Total { get; }
        [JsonProperty("free")]
        public decimal? Free { get; }
        [JsonProperty("locked")]
        public decimal? Locked { get; }
    }
}
