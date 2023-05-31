using BybitMapper.Handlers;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Account;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Positions;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Market;

namespace BybitMapper.UsdcPerpetual.RestV2
{
    /// <summary>
    /// Фабрика
    /// </summary>
    public sealed class UsdcPepetualHandlerFactory : IUsdcPepetualHandlerFactory
    {
        #region [Account]
        public ISingleMessageHandler<WalletInfoResponse> CreateWalletInfoResponse() => new BaseJsonHandler<WalletInfoResponse>();
        public ISingleMessageHandler<CancelAllActiveOrdersResponse> CreateCancelAllActiveOrdersResponse() => new BaseJsonHandler<CancelAllActiveOrdersResponse>();
        public ISingleMessageHandler<CancelOrderResponse> CreateCancelOrderResponse() => new BaseJsonHandler<CancelOrderResponse>();
        public ISingleMessageHandler<PlaceOrderResponse> CreatePlaceOrderResponse() => new BaseJsonHandler<PlaceOrderResponse>();
        public ISingleMessageHandler<QueryOrderHistoryResponse> CreateQueryOrderHistoryResponse() => new BaseJsonHandler<QueryOrderHistoryResponse>();
        public ISingleMessageHandler<QueryUnfilledResponse> CreateQueryUnfilledResponse() => new BaseJsonHandler<QueryUnfilledResponse>();
        public ISingleMessageHandler<TradeHistoryResponse> CreateTradeHistoryResponse() => new BaseJsonHandler<TradeHistoryResponse>();
        public ISingleMessageHandler<QueryMyPositionsResponse> CreateQueryMyPositionsResponse() => new BaseJsonHandler<QueryMyPositionsResponse>();
        #endregion

        #region [Market]
        public ISingleMessageHandler<ContractInfoResponce> CreateContractInfoResponce() => new BaseJsonHandler<ContractInfoResponce>();
        public ISingleMessageHandler<OrderBookResponse> CreateOrderBookResponse() => new BaseJsonHandler<OrderBookResponse>();
        public ISingleMessageHandler<QueryKlineResponse> CreateQueryKlineResponse() => new BaseJsonHandler<QueryKlineResponse>();
        public ISingleMessageHandler<ServerTimeResponse> CreateServerTimeResponse() => new BaseJsonHandler<ServerTimeResponse>();
        public ISingleMessageHandler<LatestSymbolInfoReponse> CreateLatestSymbolInfoReponse() => new BaseJsonHandler<LatestSymbolInfoReponse>();

        #endregion
    }
}
