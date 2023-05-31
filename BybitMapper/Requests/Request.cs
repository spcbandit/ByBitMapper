using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BybitMapper.Requests
{
    internal class Request : IRequestContent
    {
        [NotNull]
        private readonly RequestPayload _requestPayload;
        private readonly string _apiKey;
        public Request([NotNull] RequestPayload requestPayload, [CanBeNull] string apiKey)
        {
            _requestPayload = requestPayload ?? throw new ArgumentNullException(nameof(requestPayload));
            _apiKey = apiKey;
        }

        public string Query {
            get {
                if (_requestPayload.Properties is null)
                {
                    return _requestPayload.EndPoint;
                }
                else
                {
                    return $"{_requestPayload.EndPoint}?{GenerateParametersString(_requestPayload.Properties)}";
                }

            }
        }
        public RequestMethod Method => _requestPayload.Method;

        public virtual IReadOnlyDictionary<string, string> Headers => null;

        public object Body => _requestPayload.Body;

        [NotNull]
        protected virtual string GenerateParametersString([NotNull] IDictionary<string, string> properties) =>
            string.Join("&", properties.Select(a => $"{a.Key}={a.Value}"));
    }
}