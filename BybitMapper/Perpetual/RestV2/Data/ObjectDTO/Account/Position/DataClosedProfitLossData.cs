using BybitMapper.Extensions;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using Newtonsoft.Json;

namespace BybitMapper.Perpetual.RestV2.Data.ObjectDTO.Account.Position
{
    public sealed class DataClosedProfitLossData
    {
        public DataClosedProfitLossData(long id, long uderId, string symbol, string orderId, string side, decimal qty, decimal orderPrice, 
            string order, string exec, decimal closedSize, decimal cumEntryValue, decimal avgEntryPrice, decimal cumExitValue, 
            decimal avgExitPrice, decimal closedPnl, decimal fillCount, decimal leverage, long createdAt)
        {
            Id = id;
            UderId = uderId;
            Symbol = symbol;
            OrderId = orderId;
            Side = side;
            SideType = Side.ToEnum<OrderSideType>();
            Qty = qty;
            OrderPrice = orderPrice;
            Order = order;
            OrderType = Order.ToEnum<OrderType>();
            Exec = exec;
            ExecType = Exec.ToEnum<ExecType>();
            ClosedSize = closedSize;
            CumEntryValue = cumEntryValue;
            AvgEntryPrice = avgEntryPrice;
            CumExitValue = cumExitValue;
            AvgExitPrice = avgExitPrice;
            ClosedPnl = closedPnl;
            FillCount = fillCount;
            Leverage = leverage;
            CreatedAt = createdAt;
        }

        [JsonProperty("id")]
        public long Id { get; }
        [JsonProperty("user_id")]
        public long UderId { get; }
        [JsonProperty("symbol")]
        public string Symbol { get; }
        [JsonProperty("order_id")]
        public string OrderId { get; }
        [JsonProperty("side")]
        public string Side { get; }
        public OrderSideType SideType { get; }
        [JsonProperty("qty")]
        public decimal Qty { get; }
        [JsonProperty("order_price")]
        public decimal OrderPrice { get; }
        [JsonProperty("order_type")]
        public string Order { get; }
        public OrderType OrderType { get; }
        [JsonProperty("exec_type")]
        public string Exec { get; }
        public ExecType ExecType { get; }
        [JsonProperty("closed_size")]
        public decimal ClosedSize { get; }
        [JsonProperty("cum_entry_value")]
        public decimal CumEntryValue { get; }
        [JsonProperty("avg_entry_price")]
        public decimal AvgEntryPrice { get; }
        [JsonProperty("cum_exit_value")]
        public decimal CumExitValue { get; }
        [JsonProperty("avg_exit_price")]
        public decimal AvgExitPrice { get; }
        [JsonProperty("closed_pnl")]
        public decimal ClosedPnl { get; }
        [JsonProperty("fill_count")]
        public decimal FillCount { get; }
        [JsonProperty("leverage")]
        public decimal Leverage { get; }
        [JsonProperty("created_at")]
        public long CreatedAt { get; }
    }
}
