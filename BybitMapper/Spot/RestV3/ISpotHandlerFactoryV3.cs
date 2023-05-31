using BybitMapper.Handlers;
using BybitMapper.Spot.RestV3.Responses;
using BybitMapper.Spot.RestV3.Responses.Account;
using BybitMapper.Spot.RestV3.Responses.Market;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3
{
    public interface ISpotHandlerFactoryV3
    {
        #region [Market]
        [NotNull]
        ISingleMessageHandler<ErrorResponse> CreateErrorResponse();
        [NotNull]
        ISingleMessageHandler<CandlestickChartResponse> CreateCandlestickChartResponse();
        [NotNull]
        ISingleMessageHandler<GetSymbolsResponse> CreateGetSymbolsResponse();
        [NotNull]
        ISingleMessageHandler<OrderBookResponse> CreateOrderBookResponse();
        [NotNull]
        ISingleMessageHandler<ServerTimeResponse> CreateServerTimeResponse();
        [NotNull]
        ISingleMessageHandler<LatestInformationSymbolResponse> CreateLatestInformationSymbolResponse();
        #endregion
        #region [Account]
        [NotNull]
        ISingleMessageHandler<CancelSpotOrderResponse> CreateCancelSpotOrderResponse();
        [NotNull]
        ISingleMessageHandler<CreateSpotOrderResponse> CreateCreateSpotOrderResponse();
        [NotNull]
        ISingleMessageHandler<OrderListResponse> CreateOrderListResponse();
        [NotNull]
        ISingleMessageHandler<TradeHistoryResponse> CreateTradeHistoryResponse();
        [NotNull]
        ISingleMessageHandler<SpotWalletBalanceResponse> CreateSpotWalletBalanceResponse();
        #endregion
    }
}
