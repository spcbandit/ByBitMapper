using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Data
{
    public sealed class InsuranceData
    {
        [JsonConstructor]
        public InsuranceData(string currency, DateTime? timestamp, decimal walletBalance)
        {
            Currency = currency;
            Timestamp = timestamp;
            WalletBalance = walletBalance;
        }

        [JsonRequired, JsonProperty("currency")]
        public string Currency { get; }
        [CanBeNull, JsonProperty("timestamp")]
        public DateTime? Timestamp { get; }
        [JsonRequired, JsonProperty("wallet_balance")]
        public decimal WalletBalance { get; }
    }
}
