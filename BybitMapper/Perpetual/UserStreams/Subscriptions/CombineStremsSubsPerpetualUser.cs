using BybitMapper.Extensions;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;
using BybitMapper.Perpetual.UserStreams.Data.Enum;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BybitMapper.Perpetual.UserStreams.Subscriptions
{
    /// <summary>
    /// Статичный класс для подписки на все типы каналов (Быстрый сбор без хранения информации)
    /// {"op":"auth","args":["{api_key}","{expires}","{signature}"]}
    /// </summary>
    public sealed class CombineStremsSubsPerpetualUser
    {
        /// <summary>
        /// Methode for [Login]
        /// </summary>
        /// <param name="subType"></param>
        /// <param name="apikey"></param>
        /// <returns></returns>
        public static string Create(SubType subType, string apikey, string secretkey, long timestamp)
        {
            // string expires = (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 5000).ToString();
            string expires = timestamp.ToString();
            string signature = CreateSignature(secretkey, "GET/realtime" + expires);
            var result = new Dictionary<string, object>();

            result.Add("op", subType.GetEnumMemberAttributeValue());
            result.Add("args", new string[] { apikey, expires, signature });
            return JsonConvert.SerializeObject(result);
        }
        /// <summary>
        /// Methode for other [Account] endpoint
        /// </summary>
        /// <param name="subType"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string Create(SubType subType, UserEventType type)
        {
            var result = new Dictionary<string, object>();

            result.Add("op", subType.GetEnumMemberAttributeValue());
            result.Add("args", new string[] { type.GetEnumMemberAttributeValue() });
            return JsonConvert.SerializeObject(result);
        }

        #region [Helpers]
        public static string CreateSignature(string secret, string message)
        {
            var signatureBytes = Hmacsha256(Encoding.UTF8.GetBytes(secret), Encoding.UTF8.GetBytes(message));

            return ByteArrayToString(signatureBytes);
        }
        private static byte[] Hmacsha256(byte[] keyByte, byte[] messageBytes)
        {
            using (var hash = new HMACSHA256(keyByte))
            {
                return hash.ComputeHash(messageBytes);
            }
        }
        public static string ByteArrayToString(byte[] ba)
        {
            var hex = new StringBuilder(ba.Length * 2);

            foreach (var b in ba)
            {
                hex.AppendFormat("{0:x2}", b);
            }
            return hex.ToString();
        }
        #endregion
    }
}
