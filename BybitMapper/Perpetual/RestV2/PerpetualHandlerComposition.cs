using BybitMapper.Handlers;
using BybitMapper.Perpetual.RestV2.Responses;
using BybitMapper.Perpetual.RestV2.Responses.Account.ActiveOrders;
using BybitMapper.Perpetual.RestV2.Responses.Account.ConditionalOrders;
using BybitMapper.Perpetual.RestV2.Responses.Account.Funding;
using BybitMapper.Perpetual.RestV2.Responses.Account.Position;
using BybitMapper.Perpetual.RestV2.Responses.Account.RiskLimit;
using BybitMapper.Perpetual.RestV2.Responses.Account.Wallet;
using BybitMapper.Perpetual.RestV2.Responses.Market;

using JetBrains.Annotations;

using System;

namespace BybitMapper.Perpetual.RestV2
{
    /// <summary>
    /// PerpetualHandlerComposition
    /// </summary>
    public sealed class PerpetualHandlerComposition
    {
        #region [Market]
        [NotNull]
        private readonly ISingleMessageHandler<GetLastFundingRateResponse> _getLastFundingRateResponse;
        [NotNull]
        private readonly ISingleMessageHandler<LatestInformationSymbolResponse> _latestInformationSymbolResponse;
        [NotNull]
        private readonly ISingleMessageHandler<LiquidatedOrdersResponse> _liquidatedOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<OpenInterestResponse> _openInterestResponse;
        [NotNull]
        private readonly ISingleMessageHandler<OrderBookResponse> _orderBookResponse;
        [NotNull]
        private readonly ISingleMessageHandler<PublicTradingRecordsResponce> _publicTradingRecordsResponce;
        [NotNull]
        private readonly ISingleMessageHandler<QueryKlineResponse> _queryKlineResponse;
        [NotNull]
        private readonly ISingleMessageHandler<QueryMarkPriceKlineResponse> _queryMarkPriceKlineResponse;
        [NotNull]
        private readonly ISingleMessageHandler<QuerySymbolResponse> _querySymbolResponse;
        [NotNull]
        private readonly ISingleMessageHandler<ServerTimeResponse> _serverTimeResponse;

        #endregion
        #region [Account]
        //ActiveOrders
        [NotNull]
        private readonly ISingleMessageHandler<CancelActiveOrderResponse> _cancelActiveOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CancelAllActiveOrdersResponse> _cancelAllActiveOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<GetActiveOrderResponse> _getActiveOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<PlaceActiveOrderResponse> _placeActiveOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<QueryActiveOrderResponse> _queryActiveOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<ReplaceActiveOrderResponse> _replaceActiveOrderResponse;
        //ConditionalOrders
        [NotNull]
        private readonly ISingleMessageHandler<CancelAllConditionalOrdersResponse> _cancelAllConditionalOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CancelConditionalOrderResponse> _cancelConditionalOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<GetConditionalOrderResponse> _getConditionalOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<PlaceConditionalOrderResponse> _placeConditionalOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<QueryConditionalOrderResponse> _queryConditionalOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<ReplaceConditionalOrderResponse> _replaceConditionalOrderResponse;
        //Funding
        [NotNull]
        private readonly ISingleMessageHandler<MyLastFundingFeeResponse> _myLastFundingFeeResponse;
        [NotNull]
        private readonly ISingleMessageHandler<PredictedFundingRateMyFundingFeeResponse> _predictedFundingRateMyFundingFeeResponse;
        //Position
        [NotNull]
        private readonly ISingleMessageHandler<AddReduceMarginResponse> _addReduceMarginResponse;
        [NotNull]
        private readonly ISingleMessageHandler<PositionModeSwitchResponse> _addPositionModeSwitchResponse;
        [NotNull]
        private readonly ISingleMessageHandler<ClosedProfitLossResponse> _closedProfitLossResponse;
        [NotNull]
        private readonly ISingleMessageHandler<FullPartialPositionTPSLSwitchResponce> _fullPartialPositionTPSLSwitchResponce;
        [NotNull]
        private readonly ISingleMessageHandler<MyPositionResponse> _myPositionResponse;
        [NotNull]
        private readonly ISingleMessageHandler<SetAutoAddMarginResponse> _setAutoAddMargiResponse;
        [NotNull]
        private readonly ISingleMessageHandler<SetAutoAddMarginResponse> _crossIsolatedMarginSwitchResponse;
        [NotNull]
        private readonly ISingleMessageHandler<SetAutoAddMarginResponse> _setLeverageResponse;
        [NotNull]
        private readonly ISingleMessageHandler<SetTradingStopResponse> _setTradingStopResponse;
        [NotNull]
        private readonly ISingleMessageHandler<UserTradeRecordsResponse> _userTradeRecordsResponse;
        //RiskLimit
        [NotNull]
        private readonly ISingleMessageHandler<GetRiskLimitResponse> _getRiskLimitResponse;
        [NotNull]
        private readonly ISingleMessageHandler<SetRiskLimitResponse> _setRiskLimitResponse;
        //Wallet
        [NotNull]
        private readonly ISingleMessageHandler<GetWalletBalanceResponse> _getWalletBalanceResponse;
        [NotNull]
        private readonly ISingleMessageHandler<WalletFundRecordsResponce> _walletFundRecordsResponce;
        [NotNull]
        private readonly ISingleMessageHandler<AssetExchangeRecordsResponse> _assetExchangeRecordsResponse;
        //API
        [NotNull]
        private readonly ISingleMessageHandler<APIKeyInfoResponse> _aPIKeyInfoResponse;
        #endregion

        public PerpetualHandlerComposition([NotNull] IPerpetualHandlerFactory factory)
        {
            if (factory is null) throw new ArgumentNullException(nameof(factory));
            #region [Market]
            _getLastFundingRateResponse = factory.CreateGetLastFundingRateResponse();
            _latestInformationSymbolResponse = factory.CreateLatestInformationSymbolResponse();
            _liquidatedOrdersResponse = factory.CreateLiquidatedOrdersResponse();
            _openInterestResponse = factory.CreateOpenInterestResponse();
            _orderBookResponse = factory.CreateOrderBookResponse();
            _publicTradingRecordsResponce = factory.CreatePublicTradingRecordsResponce();
            _queryKlineResponse = factory.CreateQueryKlineResponse();
            _queryMarkPriceKlineResponse = factory.CreateQueryMarkPriceKlineResponse();
            _querySymbolResponse = factory.CreateQuerySymbolResponse();
            _serverTimeResponse = factory.CreateServerTimeResponse();
            #endregion

            #region [Account]
            //ActiveOrders
            _cancelActiveOrderResponse = factory.CreateCancelActiveOrderResponse();
            _cancelAllActiveOrdersResponse = factory.CreateCancelAllActiveOrdersResponse(); 
            _getActiveOrderResponse = factory.CreateGetActiveOrderResponse();
            _placeActiveOrderResponse = factory.CreatePlaceActiveOrderResponse();
            _queryActiveOrderResponse = factory.CreateQueryActiveOrderResponse();
            _replaceActiveOrderResponse = factory.CreateReplaceActiveOrderResponse();

            //ConditionalOrders
            _cancelAllConditionalOrdersResponse = factory.CreateCancelAllConditionalOrdersResponse();
            _cancelConditionalOrderResponse = factory.CreateCancelConditionalOrderResponse();
            _getConditionalOrderResponse = factory.CreateGetConditionalOrderResponse();
            _placeConditionalOrderResponse = factory.CreatePlaceConditionalOrderResponse();
            _queryConditionalOrderResponse = factory.CreateQueryConditionalOrderResponse();
            _replaceConditionalOrderResponse = factory.CreateReplaceConditionalOrderResponse();

            //Funding
            _myLastFundingFeeResponse = factory.CreateMyLastFundingFeeResponse();
            _predictedFundingRateMyFundingFeeResponse = factory.CreatePredictedFundingRateMyFundingFeeResponse();

            //Position
            _addPositionModeSwitchResponse = factory.CreatePositionModeSwitchResponse(); 
            _addReduceMarginResponse = factory.CreateAddReduceMarginResponse(); 
            _closedProfitLossResponse = factory.CreateClosedProfitLossResponse(); 
            _fullPartialPositionTPSLSwitchResponce = factory.CreateFullPartialPositionTPSLSwitchResponce(); 
            _myPositionResponse = factory.CreateMyPositionResponse(); 
            _setAutoAddMargiResponse = factory.CreateSetAutoAddMarginResponse(); 
            _crossIsolatedMarginSwitchResponse = factory.CreateCrossIsolatedMarginSwitch(); 
            _setLeverageResponse = factory.CreateSetLeverage(); 
            _setTradingStopResponse = factory.CreateSetTradingStop(); 
            _userTradeRecordsResponse = factory.CreateUserTradeRecordsResponse(); 
 
            //RiskLimit
            _getRiskLimitResponse = factory.CreateGetRiskLimitResponse(); 
            _setRiskLimitResponse = factory.CreateSetRiskLimitResponse(); 
 
            //Wallet
            _getWalletBalanceResponse = factory.CreateGetWalletBalanceResponse();
            _walletFundRecordsResponce = factory.CreateWalletFundRecordsResponce();
            _assetExchangeRecordsResponse = factory.CreateAssetExchangeRecordsResponse();

            //API
            _aPIKeyInfoResponse = factory.CreateAPIKeyInfoResponse();
            #endregion
        }

        #region [Market]
        public GetLastFundingRateResponse HandleGetLastFundingRateResponse(string message) => _getLastFundingRateResponse.HandleSingle(message);
        public LatestInformationSymbolResponse HandleLatestInformationSymbolResponse(string message) => _latestInformationSymbolResponse.HandleSingle(message);
        public LiquidatedOrdersResponse HandleLiquidatedOrdersResponse(string message) => _liquidatedOrdersResponse.HandleSingle(message);
        public OpenInterestResponse HandleOpenInterestResponse(string message) => _openInterestResponse.HandleSingle(message);
        public OrderBookResponse HandleOrderBookResponse(string message) => _orderBookResponse.HandleSingle(message);
        public PublicTradingRecordsResponce HandlePublicTradingRecordsResponce(string message) => _publicTradingRecordsResponce.HandleSingle(message);
        public QueryKlineResponse HandleQueryKlineResponse(string message) => _queryKlineResponse.HandleSingle(message);
        public QueryMarkPriceKlineResponse HandleQueryMarkPriceKlineResponse(string message) => _queryMarkPriceKlineResponse.HandleSingle(message);
        public QuerySymbolResponse HandleQuerySymbolResponse(string message) => _querySymbolResponse.HandleSingle(message);
        public ServerTimeResponse HandlerServerTimeResponse(string message) => _serverTimeResponse.HandleSingle(message);

        #endregion

        #region [Account]

        //ActiveOrders
        public CancelActiveOrderResponse HandleCancelActiveOrderResponse(string message) => _cancelActiveOrderResponse.HandleSingle(message);
        public CancelAllActiveOrdersResponse HandleCancelAllActiveOrdersResponse(string message) => _cancelAllActiveOrdersResponse.HandleSingle(message);
        public GetActiveOrderResponse HandleGetActiveOrderResponse(string message) => _getActiveOrderResponse.HandleSingle(message);
        public PlaceActiveOrderResponse HandlePlaceActiveOrderResponse(string message) => _placeActiveOrderResponse.HandleSingle(message);
        public QueryActiveOrderResponse HandleQueryActiveOrderResponse(string message) => _queryActiveOrderResponse.HandleSingle(message);
        public ReplaceActiveOrderResponse HandleReplaceActiveOrderResponse(string message) => _replaceActiveOrderResponse.HandleSingle(message);
        //ConditionalOrders
        public CancelAllConditionalOrdersResponse HandleCancelAllConditionalOrdersResponse(string message) => _cancelAllConditionalOrdersResponse.HandleSingle(message);
        public CancelConditionalOrderResponse HandleCancelConditionalOrderResponse(string message) => _cancelConditionalOrderResponse.HandleSingle(message);
        public GetConditionalOrderResponse HandleGetConditionalOrderResponse(string message) => _getConditionalOrderResponse.HandleSingle(message);
        public PlaceConditionalOrderResponse HandlePlaceConditionalOrderResponse(string message) => _placeConditionalOrderResponse.HandleSingle(message);
        public QueryConditionalOrderResponse HandleQueryConditionalOrderResponse(string message) => _queryConditionalOrderResponse.HandleSingle(message);
        public ReplaceConditionalOrderResponse HandleReplaceConditionalOrderResponse(string message) => _replaceConditionalOrderResponse.HandleSingle(message);
        //Funding
        public MyLastFundingFeeResponse HandleMyLastFundingFeeResponse(string message) => _myLastFundingFeeResponse.HandleSingle(message);
        public PredictedFundingRateMyFundingFeeResponse HandlePredictedFundingRateMyFundingFeeResponse(string message) => _predictedFundingRateMyFundingFeeResponse.HandleSingle(message);
        //Position
        public PositionModeSwitchResponse HandleAddPositionModeSwitchResponse(string message) => _addPositionModeSwitchResponse.HandleSingle(message);
        public AddReduceMarginResponse HandleAddReduceMarginResponse(string message) => _addReduceMarginResponse.HandleSingle(message);
        public ClosedProfitLossResponse HandleClosedProfitLossResponse(string message) => _closedProfitLossResponse.HandleSingle(message);
        public FullPartialPositionTPSLSwitchResponce HandleFullPartialPositionTPSLSwitchResponce(string message) => _fullPartialPositionTPSLSwitchResponce.HandleSingle(message);
        public MyPositionResponse HandleMyPositionResponse(string message) => _myPositionResponse.HandleSingle(message);
        public SetAutoAddMarginResponse HandleSetAutoAddMarginResponse(string message) => _setAutoAddMargiResponse.HandleSingle(message);
        public SetAutoAddMarginResponse HandleCrossIsolatedMarginSwitchResponse(string message) => _crossIsolatedMarginSwitchResponse.HandleSingle(message);
        public SetAutoAddMarginResponse HandleSetLeverageResponse(string message) => _setLeverageResponse.HandleSingle(message);
        public SetTradingStopResponse HandleSetTradingStopResponse(string message) => _setTradingStopResponse.HandleSingle(message);
        public UserTradeRecordsResponse HandleUserTradeRecordsResponse(string message) => _userTradeRecordsResponse.HandleSingle(message);
        //RiskLimit
        public GetRiskLimitResponse HandleGetRiskLimitResponse(string message) => _getRiskLimitResponse.HandleSingle(message);
        public SetRiskLimitResponse HandleSetRiskLimitResponse(string message) => _setRiskLimitResponse.HandleSingle(message);
        //Wallet
        public GetWalletBalanceResponse HandleWalletBalanceResponse(string message) => _getWalletBalanceResponse.HandleSingle(message);
        public WalletFundRecordsResponce HandleWalletFundRecordsResponce(string message) => _walletFundRecordsResponce.HandleSingle(message);
        public AssetExchangeRecordsResponse HandleAssetExchangeRecordsResponse(string message) => _assetExchangeRecordsResponse.HandleSingle(message);
        //API
        public APIKeyInfoResponse HandleAPIKeyInfoResponse(string message) => _aPIKeyInfoResponse.HandleSingle(message);
        #endregion
    }
}
