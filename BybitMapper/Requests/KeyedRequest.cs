using BybitMapper.Extensions;

using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;

namespace BybitMapper.Requests
{
    internal class KeyedRequest : Request
    {
        [NotNull]
        private readonly string _apiSecret;
        private readonly string _apiKey;
        private readonly long _timestamp;
        private readonly int? _recvWindow;

        public KeyedRequest([NotNull] RequestPayload requestPayload,
            [NotNull] string apiKey, [NotNull] string apiSecret, [NotNull] long timestamp, [NotNull] int? recvWindow = 5000)
            : base(requestPayload, apiKey)
        {
            _apiSecret = apiSecret ?? throw new ArgumentNullException(nameof(apiSecret));
            _apiKey = apiKey ?? throw new ArgumentNullException(nameof(apiKey));

            _timestamp = timestamp;
            _recvWindow = recvWindow;
            if (requestPayload.Headers != null)
            {
                Headers = requestPayload.Headers.ToDictionary(k=>k.Key, v=>v.Value);
            }
        }

        protected override string GenerateParametersString(IDictionary<string, string> properties)
        {
            properties.AddSimpleStruct("timestamp", _timestamp);
            properties.AddStringIfNotEmptyOrWhiteSpace("api_key", _apiKey);
            properties.AddSimpleStructIfNotNull("recv_window", _recvWindow);
            properties = properties.OrderBy(x => x.Key).ToDictionary(process => process.Key, process => process.Value);
            var totalParameters = base.GenerateParametersString(properties);
            var res = $"{totalParameters}&sign={CreateSignature(secret: _apiSecret, totalParameters)}";
            return res;
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

        public sealed override IReadOnlyDictionary<string, string> Headers { get; }
    }
}