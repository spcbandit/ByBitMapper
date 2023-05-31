using BybitMapper.Extensions;
using BybitMapper.Spot.RestV3.Data.Enums;
using Newtonsoft.Json;

namespace BybitMapper.Spot.RestV3.Data.ObjectDTO.Account
{
    public class TradeHistoryData
    {
        /// <summary>
        /// История сделок
        /// </summary>
        /// <param name="id">Идентификатор транзакции</param>
        /// <param name="symbol">Инструмент</param>
        /// <param name="orderId">Идентификатор ордера</param>
        /// <param name="tradeId"></param>
        /// <param name="orderPrice">Цена ордер</param>
        /// <param name="orderQty">Объем ордера</param>
        /// <param name="execFee">Торговая комиссия (за одно исполнение)</param>
        /// <param name="feeTokenId">Идентификатор токена комиссии</param>
        /// <param name="creatTime">Время размещения заявки</param>
        /// <param name="isBuyer">0：Buyer, 1：Seller</param>
        /// <param name="isMaker">0：Maker, 1：Taker</param>
        /// <param name="matchOrderId">Идентификатор ордера трейдера-оппонента</param>
        /// <param name="makerRebate">Сборы мейкера</param>
        /// <param name="executionTime">Время выполнения ордера</param>
        [JsonConstructor]
        public TradeHistoryData(string id, string symbol, string orderId, string tradeId,
            float orderPrice, decimal orderQty, decimal execFee, string feeTokenId, long creatTime,
            string isBuyer, string isMaker, string matchOrderId, string makerRebate, long executionTime)
        {
            Id = id;
            Symbol = symbol;
            OrderId = orderId;
            TradeId = tradeId;
            OrderPrice = orderPrice;
            OrderQty = orderQty;
            ExecFee = execFee;
            FeeTokenId = feeTokenId;
            CreatTime = creatTime;
            IsBuyer = isBuyer;
            BuyerEnum = isBuyer.ToEnum<BuyerType>();
            IsMaker = isMaker;
            MatchOrderId = matchOrderId;
            MakerRebate = makerRebate;
            ExecutionTime = executionTime;
        }

        [JsonProperty("id")]
        public string Id { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("orderId")]
        public string OrderId { get; }
        [JsonProperty("tradeId")]
        public string TradeId { get; }
        [JsonProperty("matchOrderId")]
        public string MatchOrderId { get; }
        [JsonProperty("orderPrice")]
        public float OrderPrice { get; }
        [JsonProperty("orderQty")]
        public decimal OrderQty { get; }
        [JsonProperty("creatTime")]
        public long CreatTime { get; }
        [JsonProperty("isBuyer")]
        public string IsBuyer { get; }
        public BuyerType BuyerEnum { get; }
        [JsonProperty("isMaker")]
        public string IsMaker { get; }
        [JsonProperty("execFee")]
        public decimal ExecFee { get; }
        [JsonProperty("feeTokenId")]
        public string FeeTokenId { get; }
        [JsonProperty("makerRebate")]
        public string MakerRebate { get; }
        [JsonProperty("executionTime")]
        public long ExecutionTime { get; }
        
    }
}
