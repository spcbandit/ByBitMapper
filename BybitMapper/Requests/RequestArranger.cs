using JetBrains.Annotations;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace BybitMapper.Requests
{
    public sealed class RequestArranger
    {
        [NotNull]
        private readonly Func<long> _timestampFactory;
        public RequestArranger([CanBeNull] Func<long> timestampFactory = null) =>
          _timestampFactory = timestampFactory ?? (() => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
        //private long Timestamp => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + TimestampShiftInMilliseconds;
        private long Timestamp => _timestampFactory.Invoke();
        public int TimestampShiftInMilliseconds { get; set; }

        /// <summary>
        /// Пустой конструктор для создания публичных запросов из (Payload)
        /// </summary>
        public RequestArranger()
        { }
        /// <summary>
        /// Конструктор для создания приватных запросов из (Payload)
        /// </summary>
        /// <param name="apiKey">Публичный ключ аккаунта</param>
        /// <param name="apiSecret">Приватный ключ аккаунта</param>
        /// <param name="subaccountName">[Optional]Ник суб-аккаунта для работы с конкретным суб-аккаунтом от основного аккаунта биржи (можно указать не через конструктор и продолжать запросы с тем же экземпляром класса)</param>
        public RequestArranger([NotNull] string apiKey, [NotNull] string apiSecret, [CanBeNull] Func<long> timestampFactory = null)
            :this(timestampFactory)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentException("Cannot be empty!", nameof(apiKey));

            if (string.IsNullOrWhiteSpace(apiSecret))
                throw new ArgumentException("Cannot be empty!", nameof(apiSecret));

            ApiKey = apiKey;
            ApiSecret = apiSecret;
        }

        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public int ActualityWindow { get; set; } = 5000;
        public string Nonce { get;set; }

        /// <summary>
        /// Метод создания запроса к бирже
        /// </summary>
        /// <param name="payload">Вся собранная информация запроса</param>
        /// <returns></returns>
        [NotNull]
        public IRequestContent Arrange([NotNull] RequestPayload payload)
        {
            switch (payload)
            {
                case KeyedRequestPayload _payload:
                    _payload.ActualityWindow = this.ActualityWindow;
                    return new KeyedRequest(payload, 
                        ApiKey, 
                        ApiSecret, 
                        Timestamp, 
                        _payload.ActualityWindow);
                case UsdcKeyedRequestPayload _payloadUsdc:
                    _payloadUsdc.ActualityWindow = this.ActualityWindow;
                    return new UsdcKeyedRequest(payload,
                        ApiKey,
                        ApiSecret,
                        Timestamp,
                        _payloadUsdc.ActualityWindow);
                default:
                    return new Request(payload, null);
            }
        }
    }

    
}