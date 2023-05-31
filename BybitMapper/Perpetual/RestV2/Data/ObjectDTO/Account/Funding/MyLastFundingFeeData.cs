using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

using System;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Funding
{
    public sealed class MyLastFundingFeeData
    {
        public MyLastFundingFeeData(string symbol, string side, decimal size, decimal fundingRate, decimal execFee, DateTime execTime)
        {
            Symbol = symbol;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Size = size;
            FundingRate = fundingRate;
            ExecFee = execFee;
            ExecTime = execTime;
        }

        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonProperty("size")]
        public decimal Size { get; }
        [JsonProperty("funding_rate")]
        public decimal FundingRate { get; }
        [JsonProperty("exec_fee")]
        public decimal ExecFee { get; }
        [JsonProperty("exec_time")]
        public DateTime ExecTime { get; }
    }
}
