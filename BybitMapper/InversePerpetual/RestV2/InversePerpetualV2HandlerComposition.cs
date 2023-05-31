using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.RestV2.Responses;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.ActiveOrders;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.ConditionalOrders;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.Funding;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.Positions;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.RiskLimit;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.Wallet;
using BybitMapper.InversePerpetual.RestV2.Responses.Market;

using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace BybitMapper.InversePerpetual.RestV2
{
    public sealed class InversePerpetualV2HandlerComposition
    {
        #region [Market]
        [NotNull]
        private readonly ISingleMessageHandler<ErrorResponse> _ErrorResponse;
        [NotNull]
        private readonly ISingleMessageHandler<OrderBookResponse> _orderBookResponse;
        [NotNull]
        private readonly ISingleMessageHandler<KlineResponse> _klineResponse;
        [NotNull]
        private readonly ISingleMessageHandler<SymbolInfoResponse> _symbolInfoResponse;
        [NotNull]
        private readonly ISingleMessageHandler<TradingRecordsResponse> _tradingRecordsResponse;
        [NotNull]
        private readonly ISingleMessageHandler<SymbolsResponse> _symbolsResponse;
        [NotNull]
        private readonly ISingleMessageHandler<LiquidatedOrdersResponse> _liquidatedResponse;
        [NotNull]
        private readonly ISingleMessageHandler<MarkPriceResponse> _markPriceResponse;
        [NotNull]
        private readonly ISingleMessageHandler<SymbolOpenInterestResponse> _openInteresResponse;
        [NotNull]
        private readonly ISingleMessageHandler<ServerTimeResponse> _serverTimeResponse;
        #endregion
        #region [Account]
        [NotNull]
        private readonly ISingleMessageHandler<PlaceOrdersResponse> _placeOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<GetActiveOrdersResponse> _getActiveOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CancelActiveOrderResponse> _cancelActiveOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CancelAllOrdersResponse> _cancelAllActiveOrdersResponse;
        // [NotNull]
        // private readonly ISingleMessageHandler<PlaceConditionalOrderResponse> _placeConditionalOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<GetConditionalOrderResponse> _getConditionalOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CancelConditionalOrderResponse> _cancelConditionalOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CancelAllConditionalOrdersResponse> _cancelAllConditionalOrdersResponse;
        [NotNull]
        private readonly ISingleMessageHandler<ReplaceConditionalResponse> _replaceConditionalResponse;
        [NotNull]
        private readonly ISingleMessageHandler<GetLastFundingRateResponse> _getLastFundingRate;
        [NotNull]
        private readonly ISingleMessageHandler<MyLastFundingFeeResponse> _getMyLastFundingRate;
        [NotNull]
        private readonly ISingleMessageHandler<GetRiskLimitResponse> _getRiskLimit;
        [NotNull]
        private readonly ISingleMessageHandler<SetRiskLimitResponse> _setRiskLimit;
        [NotNull]
        private readonly ISingleMessageHandler<MyPositionResponse> _myPositions;
        [NotNull]
        private readonly ISingleMessageHandler<ChangeMarginResponse> _changeMargin;
        [NotNull]
        private readonly ISingleMessageHandler<SetLeverageResponse> _setLeverage;
        [NotNull]
        private readonly ISingleMessageHandler<GetWalletBalanceResponse> _getWalletBalanceResponse;
        [NotNull]
        private readonly ISingleMessageHandler<WalletFundRecordsResponce> _walletFundRecordsResponce;
        [NotNull]
        private readonly ISingleMessageHandler<AssetExchangeRecordsResponse> _assetExchangeRecordsResponse;
        [NotNull]
        private readonly ISingleMessageHandler<UserTradeResponse> _userTradeResponse;
        [NotNull]
        private readonly ISingleMessageHandler<PlaceConditionalOrderResponse> _placeConditionalOrdersResponse2;
        private readonly ISingleMessageHandler<SetTradingStopResponse> _SetTradingStopResponse;
        private readonly ISingleMessageHandler<FullPartialTPSLResponse> _FullPartialTPSLResponse;
        #endregion
        public InversePerpetualV2HandlerComposition([NotNull] IInversePerpetualV2HandlerFactory factory)
        {
            if (factory is null) throw new ArgumentNullException(nameof(factory));
            #region [Market]
            _ErrorResponse  = factory.CreateErrorResponse();
            _orderBookResponse = factory.CreateOrderBookResponse();
            _klineResponse = factory.CreateKlineResponse();
            _symbolInfoResponse = factory.CreateSymbolInfoResponse();
            _tradingRecordsResponse = factory.CreateTradingRecordsResponse();
            _symbolsResponse = factory.CreateSymbolsResponse();
            _liquidatedResponse = factory.CreateLiquidatedOrdersResponse();
            _markPriceResponse = factory.CreateMarkPriceKlineResponse();
            _openInteresResponse = factory.CreateSymbolOpenInterestResponse();
            _serverTimeResponse = factory.CreateServerTimeResponse();

            #endregion
            #region [Account]
            _placeOrderResponse = factory.CreatePlaceOrdersResponse();
            _getActiveOrdersResponse = factory.CreateGetActiveOrdersResponse();
            _cancelActiveOrdersResponse = factory.CreateCancelActiveOrderResponse();
            _cancelAllActiveOrdersResponse = factory.CreateCancelAllActiveOrdersResponse();
            // _placeConditionalOrdersResponse = factory.CreatePlaceConditionOrdersResponse();
            _getConditionalOrdersResponse = factory.CreateGetConditionalOrderResponse();
            _cancelConditionalOrdersResponse = factory.CreateCancelConditionalOrderResponse();
            _cancelAllConditionalOrdersResponse = factory.CreateCancelAllConditionalOrdersResponse();
            _replaceConditionalResponse = factory.CreateReplaceConditionalOrder();
            _getLastFundingRate = factory.CreateGetLastFundingRateResponse();
            _getMyLastFundingRate = factory.CreateMyLastFundingFeeResponse();
            _getRiskLimit = factory.CreateGetRiskLimitResponse();
            _setRiskLimit = factory.CreateSetRiskLimitResponse();
            _myPositions = factory.CreateMyPositionResponse();
            _changeMargin = factory.CreateChangeMarginResponse();
            _setLeverage = factory.CreateSetLeverageResponse();
            _getWalletBalanceResponse = factory.CreateGetWalletBalanceResponse();
            _walletFundRecordsResponce = factory.CreateWalletFundRecordsResponce();
            _assetExchangeRecordsResponse = factory.CreateAssetExchangeRecordsResponse();
            _userTradeResponse = factory.CreateUserTradeResponse();
            _placeConditionalOrdersResponse2 = factory.CreatePlaceConditionalOrderResponse();
            _SetTradingStopResponse = factory.CreateSetTradingStopResponse();
            _FullPartialTPSLResponse = factory.CreateFullPartialTPSLResponse();
            #endregion
        }
        #region [Market]
        public ErrorResponse HandleErrorResponse(string message) => _ErrorResponse.HandleSingle(message);
        public OrderBookResponse HandleOrderBook(string message) => _orderBookResponse.HandleSingle(message);
        public KlineResponse HandleKline(string message) => _klineResponse.HandleSingle(message);
        public SymbolInfoResponse HandleSymbolInfo(string message) => _symbolInfoResponse.HandleSingle(message);
        public TradingRecordsResponse HandleTradingRecords(string message) => _tradingRecordsResponse.HandleSingle(message);
        public SymbolsResponse HandleSymbols(string message) => _symbolsResponse.HandleSingle(message);
        public LiquidatedOrdersResponse HandleLiquidatedOrders(string message) => _liquidatedResponse.HandleSingle(message);
        public MarkPriceResponse HandleMarkPrice(string message) => _markPriceResponse.HandleSingle(message);
        public SymbolOpenInterestResponse HandleOpenInterest(string message) => _openInteresResponse.HandleSingle(message);
        public ServerTimeResponse HandleServerTimeResponse(string message) => _serverTimeResponse.HandleSingle(message);
        #endregion
        #region [Account]
        public PlaceOrdersResponse HandlePlaceOrder(string message) => _placeOrderResponse.HandleSingle(message);
        public GetActiveOrdersResponse HandleGetActiveOrders(string message) => _getActiveOrdersResponse.HandleSingle(message);
        public CancelActiveOrderResponse HandleCancelActiveOrder(string message) => _cancelActiveOrdersResponse.HandleSingle(message);
        public CancelAllOrdersResponse HandleCancelAllActiveOrder(string message) => _cancelAllActiveOrdersResponse.HandleSingle(message);
        // public PlaceConditionalOrderResponse HandlePlaceConditionalOrder(string message) => _placeConditionalOrdersResponse.HandleSingle(message);
        public GetConditionalOrderResponse HandleGetConditionalOrder(string message) => _getConditionalOrdersResponse.HandleSingle(message);
        public CancelConditionalOrderResponse HandleCancelConditionalOrder(string message) => _cancelConditionalOrdersResponse.HandleSingle(message);
        public CancelAllConditionalOrdersResponse HandleCancelAllConditionalOrder(string message) => _cancelAllConditionalOrdersResponse.HandleSingle(message);
        public ReplaceConditionalResponse HandleReplaceConditional(string message) => _replaceConditionalResponse.HandleSingle(message);
        public GetLastFundingRateResponse HandleGetLastFundingRate(string message) => _getLastFundingRate.HandleSingle(message);
        public MyLastFundingFeeResponse HandleMyLastFundingFee(string message) => _getMyLastFundingRate.HandleSingle(message);
        public GetRiskLimitResponse HandleGetRiskLimitResponse(string message) => _getRiskLimit.HandleSingle(message);
        public SetRiskLimitResponse HandleSetRiskLimitResponse(string message) => _setRiskLimit.HandleSingle(message);
        public MyPositionResponse HandleMyPositionResponse(string message) => _myPositions.HandleSingle(message);
        public ChangeMarginResponse HandleChangeMarginResponse(string message) => _changeMargin.HandleSingle(message);
        public SetLeverageResponse HandleSetLeverageResponse(string message) => _setLeverage.HandleSingle(message);
        public GetWalletBalanceResponse HandleGetWalletBalanceResponse(string message) => _getWalletBalanceResponse.HandleSingle(message);
        public WalletFundRecordsResponce HandleWalletFundRecordsResponce(string message) => _walletFundRecordsResponce.HandleSingle(message);
        public AssetExchangeRecordsResponse HandleAssetExchangeRecordsResponse(string message) => _assetExchangeRecordsResponse.HandleSingle(message);
        public UserTradeResponse HandleUserTradeResponse(string message) => _userTradeResponse.HandleSingle(message);
        public PlaceConditionalOrderResponse HandlePlaceConditionalOrderResponse(string message) => _placeConditionalOrdersResponse2.HandleSingle(message);
        public SetTradingStopResponse HandleSetTradingStopResponse(string message) => _SetTradingStopResponse.HandleSingle(message);
        public FullPartialTPSLResponse HandleFullPartialTPSLResponse(string message) => _FullPartialTPSLResponse.HandleSingle(message);
        #endregion
    }
}