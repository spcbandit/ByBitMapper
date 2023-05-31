using BybitMapper.Extensions;
using BybitMapper.Spot.RestV1.Convertors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.Spot.RestV1.Responses.Market
{
    public class CandlestickChartResponse
    {
        [JsonConstructor]
        public CandlestickChartResponse(int? retCode, string retMessage, string extCode, object extInfo, double timestamp, IReadOnlyList<Candle> result)
        {
            RetCode = retCode;
            RetMessage = retMessage;
            ExtCode = extCode;
            ExtInfo = extInfo;
            Result = result;
        }

        [JsonProperty("ret_code")]
        public int? RetCode { get; }
        [JsonProperty("ret_msg")]
        public string RetMessage { get; }
        [JsonProperty("result")]
        public IReadOnlyList<Candle> Result { get; }
        [JsonProperty("ext_code")]
        public string ExtCode { get; }
        [JsonProperty("ext_info")]
        public object ExtInfo { get; }
    }
    [JsonConverter(typeof(CandlestickChartJsonConverter))]
    public class Candle
    {
        public Candle(ulong openTimeInMilliseconds, decimal openPrice, decimal highestPrice, decimal lowestPrice, decimal closePrice, decimal volume, long closeTimeInMilliseconds, decimal quoteAssetVolume, int tradesCount, decimal takerBuyBaseAssetVolume, decimal takerBuyQuoteAssetVolume)
        {
            OpenTimeInMilliseconds = openTimeInMilliseconds;
            OpenPrice = openPrice;
            HighestPrice = highestPrice;
            LowestPrice = lowestPrice;
            ClosePrice = closePrice;
            Volume = volume;
            CloseTimeInMilliseconds = closeTimeInMilliseconds;
            QuoteAssetVolume = quoteAssetVolume;
            TradesCount = tradesCount;
            TakerBuyBaseAssetVolume = takerBuyBaseAssetVolume;
            TakerBuyQuoteAssetVolume = takerBuyQuoteAssetVolume;
        }

        public ulong OpenTimeInMilliseconds { get; set; }
        public decimal OpenPrice { get; set; }
        public decimal HighestPrice { get; set; }
        public decimal LowestPrice { get; set; }
        public decimal ClosePrice { get; set; }
        public decimal Volume { get; set; }
        public long CloseTimeInMilliseconds { get; set; }
        public decimal QuoteAssetVolume { get; set; }
        public int TradesCount { get; set; }
        public decimal TakerBuyBaseAssetVolume { get; set; }
        public decimal TakerBuyQuoteAssetVolume { get; set; }
        public DateTime? Time
        {
            get
            {
                return ((long)OpenTimeInMilliseconds).ToDateTimeFromUnixTimeMilliseconds();
            }
        }
    }
}
