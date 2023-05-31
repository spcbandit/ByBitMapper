using BybitMapper.Extensions;
using BybitMapper.InversePerpetual.MarketStreams.Data;

using JetBrains.Annotations;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.MarketStreams.Subscriptions
{
    /// <summary>
    /// Статичный класс для подписки на все типы каналов (Быстрый сбор без хранения информации)
    /// </summary>
    public sealed class CombineStremsSubs
    {
        /// <summary>
        /// Methode for [TEST]
        /// </summary>
        /// <param name="subType"></param>
        /// <param name="eventType"></param>
        /// <returns></returns>
        public static string Create(SubType subType, PublicEndpointType eventType)
        {
            var result = new Dictionary<string, object>();

            result.Add("op", subType.GetEnumMemberAttributeValue());
            result.Add("args", new string[] { eventType.GetEnumMemberAttributeValue() });
            var res = JsonConvert.SerializeObject(result);
            return res;
        }
        /// <summary>
        /// Methode for [Trade, OrderBookL2_25, Insurance]
        /// </summary>
        /// <param name="market"></param>
        /// <param name="subType"></param>
        /// <param name="eventType"></param>
        /// <returns></returns>
        public static string Create(string market, SubType subType, PublicEndpointType eventType)
        {
            var result = new Dictionary<string, object>();

            result.Add("op", subType.GetEnumMemberAttributeValue());
            result.Add("args", new string[] { $"{eventType.GetEnumMemberAttributeValue()}.{market}" });
            return JsonConvert.SerializeObject(result);
        }

        /// <summary>
        /// Methode for [OrderBook_200, Instrument_info]
        /// </summary>
        /// <param name="market"></param>
        /// <param name="subType"></param>
        /// <param name="eventType"></param>
        /// <param name="ms"></param>
        /// <returns></returns>
        public static string Create(string market, SubType subType, PublicEndpointType eventType, string ms = "100ms")
        {
            var result = new Dictionary<string, object>();

            result.Add("op", subType.GetEnumMemberAttributeValue());
            result.Add("args", new string[] { $"{eventType.GetEnumMemberAttributeValue()}.{ms}.{market}" });
            return JsonConvert.SerializeObject(result);
        }
        /// <summary>
        /// Methode for [KlineV2]
        /// </summary>
        /// <param name="market"></param>
        /// <param name="klineType"></param>
        /// <param name="subType"></param>
        /// <param name="eventType"></param>
        /// <returns></returns>
        public static string Create(string market, KlineType klineType, SubType subType, PublicEndpointType eventType)
        {
            var result = new Dictionary<string, object>();

            result.Add("op", subType.GetEnumMemberAttributeValue());
            result.Add("args", new string[] { $"{eventType.GetEnumMemberAttributeValue()}.{klineType.GetEnumMemberAttributeValue()}.{market}" });
            return JsonConvert.SerializeObject(result);
        }
    }
}
