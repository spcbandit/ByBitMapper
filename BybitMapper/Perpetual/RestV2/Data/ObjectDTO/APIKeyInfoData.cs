using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO
{
    /// <summary>
    /// USDT Perpetual формат респонса result APIKeyInfoData
    /// </summary>
    public sealed class APIKeyInfoData
    {
        [JsonConstructor]
        public APIKeyInfoData(string apiKey, string type, long userId, long inviterId, IReadOnlyList<string> ips, string note, 
            IReadOnlyList<string> permissions, DateTime createdAt, DateTime expiresAt, bool readOnly)
        {
            ApiKey = apiKey;
            Type = type;
            UserId = userId;
            InviterId = inviterId;
            Ips = ips;
            Note = note;
            Permissions = permissions;
            CreatedAt = createdAt;
            ExpiresAt = expiresAt;
            ReadOnly = readOnly;
        }

        [JsonProperty("api_key")]
        public string ApiKey { get; }
        [JsonProperty("type")]
        public string Type { get; }
        [JsonProperty("user_id")]
        public long UserId { get; }
        [JsonProperty("inviter_id")]
        public long InviterId { get; }
        [JsonProperty("ips")]
        public IReadOnlyList<string> Ips { get; }
        [JsonProperty("note")]
        public string Note { get; }
        [JsonProperty("permissions")]
        public IReadOnlyList<string> Permissions { get; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; }
        [JsonProperty("expired_at")]
        public DateTime ExpiresAt { get; }
        [JsonProperty("read_only")]
        public bool ReadOnly { get; }
    }
}
