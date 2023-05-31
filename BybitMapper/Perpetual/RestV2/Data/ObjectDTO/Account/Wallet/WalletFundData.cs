using JetBrains.Annotations;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Wallet
{
    public sealed class WalletFundData
    {
        [JsonConstructor]
        public WalletFundData(IReadOnlyList<WalletFundInfoData> data)
        {
            Data = data;
        }

        [CanBeNull, JsonProperty("data")]
        public IReadOnlyList<WalletFundInfoData> Data { get; }
    }
    public sealed class WalletFundInfoData
    {
        [JsonConstructor]
        public WalletFundInfoData(string id, string userId, string coin, string walletId, string type, string amount, string txId, string address, string walletBalance, DateTime? execTime, string crossSeq)
        {
            Id = id;
            UserId = userId;
            Coin = coin;
            WalletId = walletId;
            Type = type;
            Amount = amount;
            TxId = txId;
            Address = address;
            WalletBalance = walletBalance;
            ExecTime = execTime;
            CrossSeq = crossSeq;
        }

        [CanBeNull, JsonProperty("id")]
        public string Id { get; }
        [CanBeNull, JsonProperty("user_id")]
        public string UserId { get; }
        [CanBeNull, JsonProperty("coin")]
        public string Coin { get; }
        [CanBeNull, JsonProperty("wallet_id")]
        public string WalletId { get; }
        [CanBeNull, JsonProperty("type")]
        public string Type { get; }
        [CanBeNull, JsonProperty("amount")]
        public string Amount { get; }
        [CanBeNull, JsonProperty("tx_id")]
        public string TxId { get; }
        [CanBeNull, JsonProperty("address")]
        public string Address { get; }
        [CanBeNull, JsonProperty("wallet_balance")]
        public string WalletBalance { get; }
        [CanBeNull, JsonProperty("exec_time")]
        public DateTime? ExecTime { get; }
        [CanBeNull, JsonProperty("cross_seq")]
        public string CrossSeq { get; }
    }
}
