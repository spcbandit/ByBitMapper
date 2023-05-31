using BybitMapper.Extensions;

using JetBrains.Annotations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BybitMapper.Requests
{
    internal class UsdcKeyedRequest : Request
    {
        [NotNull]
        private readonly string _apiSecret;
        private readonly string _apiKey;
        private readonly long _timestamp;
        private readonly int? _recvWindow;
        private RequestPayload _requestPayload;
        public UsdcKeyedRequest([NotNull] RequestPayload requestPayload,
            [NotNull] string apiKey, [NotNull] string apiSecret, [NotNull] long timestamp, [NotNull] int? recvWindow = 5000)
            : base(requestPayload, apiKey)
        {
            _apiSecret = apiSecret ?? throw new ArgumentNullException(nameof(apiSecret));
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));

            _timestamp = timestamp;
            _recvWindow = recvWindow;
            _requestPayload = requestPayload;
            //if (requestPayload.Headers != null)
            //{
            //    Headers = requestPayload.Headers.ToDictionary(k => k.Key, v => v.Value);
            //}
        }
        public sealed override IReadOnlyDictionary<string, string> Headers 
        {
            get 
            {
                var res = new Dictionary<string, string>();
                res.Add("Content-Type", "application/json");
                res.Add("X-BAPI-API-KEY", _apiKey);
                var parStr = _timestamp+ _apiKey+ _recvWindow;
                if (_requestPayload.Body!=null)
                {
                    parStr = parStr + JsonConvert.SerializeObject(_requestPayload.Body);
                }
                res.Add("X-BAPI-SIGN", CreateSignature(_apiSecret, parStr));
                res.Add("X-BAPI-SIGN-TYPE", "2");
                res.AddDecimal("X-BAPI-TIMESTAMP", _timestamp);
                res.AddDecimalIfNotNull("X-BAPI-RECV-WINDOW", _recvWindow);
                return res;
            }
        }
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
    }
}
