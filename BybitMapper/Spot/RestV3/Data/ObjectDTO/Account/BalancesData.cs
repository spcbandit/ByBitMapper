using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Data.ObjectDTO.Account
{
    public class BalancesData
    {
        [JsonConstructor]
        public BalancesData(string coin, string coinId, decimal total, decimal free, decimal locked)
        {
            Coin = coin;
            CoinId = coinId;
            Total = total;
            Free = free;
            Locked = locked;
        }

        [JsonProperty("coin")]
        public string Coin { get; }
        [JsonProperty("coinId")]
        public string CoinId { get; }
        [JsonProperty("total")]
        public decimal? Total { get; }
        [JsonProperty("free")]
        public decimal? Free { get; }
        [JsonProperty("locked")]
        public decimal? Locked { get; }
    }
}
