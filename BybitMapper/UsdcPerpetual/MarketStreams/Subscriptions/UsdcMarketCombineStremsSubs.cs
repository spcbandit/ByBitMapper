using Newtonsoft.Json;

using System.Collections.Generic;

using BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum;
using BybitMapper.Extensions;

namespace BybitMapper.UsdcPerpetual.MarketStreams.Subscriptions
{
    /// <summary>
    /// Статичный класс для подписки на все типы каналов (Быстрый сбор без хранения информации)
    /// </summary>
    public sealed class UsdcMarketCombineStremsSubs
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
            if (eventType == PublicEndpointType.OrderBook200 || eventType == PublicEndpointType.InstrumentInfo)
            {
                market = "100ms." + market;
            }

            var result = new Dictionary<string, object>();

            result.Add("op", subType.GetEnumMemberAttributeValue());
            result.Add("args", new string[] { $"{eventType.GetEnumMemberAttributeValue()}.{market}" });
            return JsonConvert.SerializeObject(result);
        }
    }
}
