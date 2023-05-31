using BybitMapper.Handlers;

using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Account;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Order;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Account.Positions;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Market;

using JetBrains.Annotations;

namespace BybitMapper.UsdcPerpetual.RestV2
{
    /// <summary>
    /// UsdcPepetualHandlerComposition
    /// </summary>
    public sealed class UsdcPepetualHandlerComposition
    {
        [NotNull]
        private readonly ISingleMessageHandler<WalletInfoResponse> _walletInfoResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CancelAllActiveOrdersResponse> _cancelAllActiveOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CancelOrderResponse> _cancelOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<PlaceOrderResponse> _placeOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<QueryOrderHistoryResponse> _queryOrderHistoryResponse;
        [NotNull]
        private readonly ISingleMessageHandler<QueryUnfilledResponse> _queryUnfilledResponse;
        [NotNull]
        private readonly ISingleMessageHandler<TradeHistoryResponse> _tradeHistoryResponse;
        [NotNull]
        private readonly ISingleMessageHandler<QueryMyPositionsResponse> _queryMyPositionsResponse;

        [NotNull]
        private readonly ISingleMessageHandler<ContractInfoResponce> _contractInfoResponce;
        [NotNull]
        private readonly ISingleMessageHandler<OrderBookResponse> _qrderBookResponse;
        [NotNull]
        private readonly ISingleMessageHandler<QueryKlineResponse> _queryKlineResponse;
        [NotNull]
        private readonly ISingleMessageHandler<ServerTimeResponse> _serverTimeResponse;
        [NotNull]
        private readonly ISingleMessageHandler<LatestSymbolInfoReponse> _latestSymbolInfoReponse;

        public UsdcPepetualHandlerComposition([NotNull] IUsdcPepetualHandlerFactory factory)
        {
            #region [Account]

            _walletInfoResponse = factory.CreateWalletInfoResponse();
            _cancelOrderResponse = factory.CreateCancelOrderResponse();
            _cancelAllActiveOrdersResponse = factory.CreateCancelAllActiveOrdersResponse();
            _placeOrderResponse = factory.CreatePlaceOrderResponse();
            _queryOrderHistoryResponse = factory.CreateQueryOrderHistoryResponse();
            _queryUnfilledResponse = factory.CreateQueryUnfilledResponse();
            _tradeHistoryResponse = factory.CreateTradeHistoryResponse();
            _queryMyPositionsResponse = factory.CreateQueryMyPositionsResponse();

            #endregion

            #region [Market]

            _contractInfoResponce = factory.CreateContractInfoResponce();
            _qrderBookResponse = factory.CreateOrderBookResponse();
            _queryKlineResponse = factory.CreateQueryKlineResponse();
            _serverTimeResponse = factory.CreateServerTimeResponse();
            _latestSymbolInfoReponse = factory.CreateLatestSymbolInfoReponse();

            #endregion
        }

        #region [Account]
        public WalletInfoResponse HandleWalletInfoResponse(string message) => _walletInfoResponse.HandleSingle(message);
        public CancelOrderResponse HandleCancelOrderResponse(string message) => _cancelOrderResponse.HandleSingle(message);
        public CancelAllActiveOrdersResponse HandleCancelAllActiveOrdersResponse(string message) => _cancelAllActiveOrdersResponse.HandleSingle(message);
        public PlaceOrderResponse HandlePlaceOrderResponse(string message) => _placeOrderResponse.HandleSingle(message);
        public QueryOrderHistoryResponse HandleQueryOrderHistoryResponse(string message) => _queryOrderHistoryResponse.HandleSingle(message);
        public QueryUnfilledResponse HandleQueryUnfilledResponse(string message) => _queryUnfilledResponse.HandleSingle(message);
        public TradeHistoryResponse HandleTradeHistoryResponse(string message) => _tradeHistoryResponse.HandleSingle(message);
        public QueryMyPositionsResponse HandleQueryMyPositionsResponse(string message) => _queryMyPositionsResponse.HandleSingle(message);

        #endregion

        #region [Market]

        public ContractInfoResponce HandleContractInfoResponce(string message) => _contractInfoResponce.HandleSingle(message);
        public OrderBookResponse HandleOrderBookResponse(string message) => _qrderBookResponse.HandleSingle(message);
        public QueryKlineResponse HandleQueryKlineResponse(string message) => _queryKlineResponse.HandleSingle(message);
        public ServerTimeResponse HandleServerTimeResponse(string message) => _serverTimeResponse.HandleSingle(message);
        public LatestSymbolInfoReponse HandleLatestSymbolInfoReponse(string message) => _latestSymbolInfoReponse.HandleSingle(message);
        #endregion
    }
}
