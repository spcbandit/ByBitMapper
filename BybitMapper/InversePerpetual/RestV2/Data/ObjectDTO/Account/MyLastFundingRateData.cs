using BybitMapper.Extensions;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO.Account
{
    public sealed class MyLastFundingRateData
    {
        [JsonConstructor]
        public MyLastFundingRateData(string symbol, string side, decimal size, decimal fundingRate, decimal execFee, decimal execTimestamp)
        {
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Size = size;
            FundingRate = fundingRate;
            ExecFee = execFee;
            ExecTimestamp = execTimestamp;
        }

        [JsonRequired, JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonRequired, JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonRequired, JsonProperty("size")]
        public decimal Size { get; }
        [JsonRequired, JsonProperty("funding_rate")]
        public decimal FundingRate { get; }
        [JsonRequired, JsonProperty("exec_fee")]
        public decimal ExecFee { get; }
        [JsonRequired, JsonProperty("exec_timestamp")]
        public decimal ExecTimestamp { get; }
    }
}
