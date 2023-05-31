using BybitMapper.Handlers;
using BybitMapper.Spot.RestV3.Responses;
using BybitMapper.Spot.RestV3.Responses.Account;
using BybitMapper.Spot.RestV3.Responses.Market;

namespace BybitMapper.Spot.RestV3
{
    public sealed class SpotHandlerFactoryV3 : ISpotHandlerFactoryV3
    {
        #region [market]
        public ISingleMessageHandler<ErrorResponse> CreateErrorResponse() => new BaseJsonHandler<ErrorResponse>();
        public ISingleMessageHandler<LatestInformationSymbolResponse> CreateLatestInformationSymbolResponse() => new BaseJsonHandler<LatestInformationSymbolResponse>();
        public ISingleMessageHandler<CandlestickChartResponse> CreateCandlestickChartResponse() => new BaseJsonHandler<CandlestickChartResponse>();
        public ISingleMessageHandler<GetSymbolsResponse> CreateGetSymbolsResponse() => new BaseJsonHandler<GetSymbolsResponse>();
        public ISingleMessageHandler<OrderBookResponse> CreateOrderBookResponse() => new BaseJsonHandler<OrderBookResponse>();
        public ISingleMessageHandler<ServerTimeResponse> CreateServerTimeResponse() => new BaseJsonHandler<ServerTimeResponse>();
        #endregion
        #region [Account]
        public ISingleMessageHandler<CancelSpotOrderResponse> CreateCancelSpotOrderResponse() => new BaseJsonHandler<CancelSpotOrderResponse>();
        public ISingleMessageHandler<CreateSpotOrderResponse> CreateCreateSpotOrderResponse() => new BaseJsonHandler<CreateSpotOrderResponse>();
        public ISingleMessageHandler<OrderListResponse> CreateOrderListResponse() => new BaseJsonHandler<OrderListResponse>();
        public ISingleMessageHandler<TradeHistoryResponse> CreateTradeHistoryResponse() => new BaseJsonHandler<TradeHistoryResponse>();
        public ISingleMessageHandler<SpotWalletBalanceResponse> CreateSpotWalletBalanceResponse() => new BaseJsonHandler<SpotWalletBalanceResponse>();
        #endregion
    }
}
