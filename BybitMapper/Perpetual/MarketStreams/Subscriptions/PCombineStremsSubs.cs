using BybitMapper.Extensions;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BybitMapper.Perpetual.MarketStreams.Subscriptions
{
    /// <summary>
    /// Статичный класс для подписки на все типы каналов (Быстрый сбор без хранения информации)
    /// </summary>
    public sealed class PCombineStremsSubs
    {
        /// <summary>
        /// Methode for [All]
        /// </summary>
        /// <param name="market"></param>
        /// <param name="subType"></param>
        /// <param name="eventType"></param>
        /// <returns></returns>
        public static string Create(string market, SubType subType, PublicEndpointType eventType)
        {
            if(eventType== PublicEndpointType.InstrumentInfo || eventType == PublicEndpointType.OrderBook200)
            {
                market = "100ms." + market;
            }
            if (eventType == PublicEndpointType.Kline)
            {
                market = "1." + market;
            }
            var result = new Dictionary<string, object>();

            result.Add("op", subType.GetEnumMemberAttributeValue());
            result.Add("args", new string[] { $"{eventType.GetEnumMemberAttributeValue()}.{market}" });
            return JsonConvert.SerializeObject(result);
        }
    }
}
