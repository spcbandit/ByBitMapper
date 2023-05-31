using BybitMapper.Extensions;
using BybitMapper.Spot.UserStreams.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.UserStreams.Subscriptions
{
    public class CombineStremsSubs
    {
        public static string Login(SubType subType, string apikey, string secretkey, long timestamp)
        {
            // string expires = (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 5000).ToString();
            string expires = timestamp.ToString();
            string signature = CreateSignature(secretkey, "GET/realtime" + expires);
            var result = new Dictionary<string, object>();

            result.Add("op", subType.GetEnumMemberAttributeValue());
            result.Add("args", new string[] { apikey, expires, signature });
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
