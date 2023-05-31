using BybitMapper.Handlers;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Account;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Positions;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Market;

using JetBrains.Annotations;

namespace BybitMapper.UsdcPerpetual.RestV2
{
    /// <summary>
    ///  Интерфейс фабрики
    /// </summary>
    public interface IUsdcPepetualHandlerFactory
    {
        #region [Account]
        [NotNull]
        ISingleMessageHandler<WalletInfoResponse> CreateWalletInfoResponse();
        [NotNull]
        ISingleMessageHandler<CancelAllActiveOrdersResponse> CreateCancelAllActiveOrdersResponse();
        [NotNull]
        ISingleMessageHandler<CancelOrderResponse> CreateCancelOrderResponse();
        [NotNull]
        ISingleMessageHandler<PlaceOrderResponse> CreatePlaceOrderResponse();
        [NotNull]
        ISingleMessageHandler<QueryOrderHistoryResponse> CreateQueryOrderHistoryResponse();
        [NotNull]
        ISingleMessageHandler<QueryUnfilledResponse> CreateQueryUnfilledResponse();
        [NotNull]
        ISingleMessageHandler<TradeHistoryResponse> CreateTradeHistoryResponse();
        [NotNull]
        ISingleMessageHandler<QueryMyPositionsResponse> CreateQueryMyPositionsResponse();
        #endregion

        #region [Market]
        [NotNull]
        ISingleMessageHandler<ContractInfoResponce> CreateContractInfoResponce();
        [NotNull]
        ISingleMessageHandler<LatestSymbolInfoReponse> CreateLatestSymbolInfoReponse();
        [NotNull]
        ISingleMessageHandler<OrderBookResponse> CreateOrderBookResponse();
        [NotNull]
        ISingleMessageHandler<QueryKlineResponse> CreateQueryKlineResponse();
        [NotNull]
        ISingleMessageHandler<ServerTimeResponse> CreateServerTimeResponse();
        #endregion
    }
}
