using BybitMapper.Handlers;
using BybitMapper.Perpetual.RestV2.Responses;
using BybitMapper.Perpetual.RestV2.Responses.Account.ActiveOrders;
using BybitMapper.Perpetual.RestV2.Responses.Account.ConditionalOrders;
using BybitMapper.Perpetual.RestV2.Responses.Account.Funding;
using BybitMapper.Perpetual.RestV2.Responses.Account.Position;
using BybitMapper.Perpetual.RestV2.Responses.Account.RiskLimit;
using BybitMapper.Perpetual.RestV2.Responses.Account.Wallet;
using BybitMapper.Perpetual.RestV2.Responses.Market;

namespace BybitMapper.Perpetual.RestV2
{
    /// <summary>
    /// Фабрика Account Data Endpoints и Market Data Endpoints для USDT Perpetual
    /// </summary>
    public sealed class PerpetualHandlerFactory : IPerpetualHandlerFactory
    {
        #region [market]
        public ISingleMessageHandler<GetLastFundingRateResponse> CreateGetLastFundingRateResponse() => new BaseJsonHandler<GetLastFundingRateResponse>();
        public ISingleMessageHandler<LatestInformationSymbolResponse> CreateLatestInformationSymbolResponse() => new BaseJsonHandler<LatestInformationSymbolResponse>();
        public ISingleMessageHandler<LiquidatedOrdersResponse> CreateLiquidatedOrdersResponse() => new BaseJsonHandler<LiquidatedOrdersResponse>();
        public ISingleMessageHandler<OpenInterestResponse> CreateOpenInterestResponse() => new BaseJsonHandler<OpenInterestResponse>();
        public ISingleMessageHandler<OrderBookResponse> CreateOrderBookResponse() => new BaseJsonHandler<OrderBookResponse>();
        public ISingleMessageHandler<PublicTradingRecordsResponce> CreatePublicTradingRecordsResponce() => new BaseJsonHandler<PublicTradingRecordsResponce>();
        public ISingleMessageHandler<QueryKlineResponse> CreateQueryKlineResponse() => new BaseJsonHandler<QueryKlineResponse>();
        public ISingleMessageHandler<QueryMarkPriceKlineResponse> CreateQueryMarkPriceKlineResponse() => new BaseJsonHandler<QueryMarkPriceKlineResponse>();
        public ISingleMessageHandler<QuerySymbolResponse> CreateQuerySymbolResponse() => new BaseJsonHandler<QuerySymbolResponse>();
        public ISingleMessageHandler<ServerTimeResponse> CreateServerTimeResponse() => new BaseJsonHandler<ServerTimeResponse>();
        
        #endregion

        #region [Account]
        //ActiveOrders
        public ISingleMessageHandler<CancelActiveOrderResponse> CreateCancelActiveOrderResponse() => new BaseJsonHandler<CancelActiveOrderResponse>();
        public ISingleMessageHandler<PositionModeSwitchResponse> CreatePositionModeSwitchResponse() => new BaseJsonHandler<PositionModeSwitchResponse>();
        public ISingleMessageHandler<CancelAllActiveOrdersResponse> CreateCancelAllActiveOrdersResponse() => new BaseJsonHandler<CancelAllActiveOrdersResponse>();
        public ISingleMessageHandler<GetActiveOrderResponse> CreateGetActiveOrderResponse() => new BaseJsonHandler<GetActiveOrderResponse>();
        public ISingleMessageHandler<PlaceActiveOrderResponse> CreatePlaceActiveOrderResponse() => new BaseJsonHandler<PlaceActiveOrderResponse>();
        public ISingleMessageHandler<QueryActiveOrderResponse> CreateQueryActiveOrderResponse() => new BaseJsonHandler<QueryActiveOrderResponse>();
        public ISingleMessageHandler<ReplaceActiveOrderResponse> CreateReplaceActiveOrderResponse() => new BaseJsonHandler<ReplaceActiveOrderResponse>();

        //ConditionalOrders
        public ISingleMessageHandler<CancelAllConditionalOrdersResponse> CreateCancelAllConditionalOrdersResponse() => new BaseJsonHandler<CancelAllConditionalOrdersResponse>();
        public ISingleMessageHandler<CancelConditionalOrderResponse> CreateCancelConditionalOrderResponse() => new BaseJsonHandler<CancelConditionalOrderResponse>();
        public ISingleMessageHandler<GetConditionalOrderResponse> CreateGetConditionalOrderResponse() => new BaseJsonHandler<GetConditionalOrderResponse>();
        public ISingleMessageHandler<PlaceConditionalOrderResponse> CreatePlaceConditionalOrderResponse() => new BaseJsonHandler<PlaceConditionalOrderResponse>();
        public ISingleMessageHandler<QueryConditionalOrderResponse> CreateQueryConditionalOrderResponse() => new BaseJsonHandler<QueryConditionalOrderResponse> ();
        public ISingleMessageHandler<ReplaceConditionalOrderResponse> CreateReplaceConditionalOrderResponse() => new BaseJsonHandler<ReplaceConditionalOrderResponse>();
        //Funding
        public ISingleMessageHandler<MyLastFundingFeeResponse> CreateMyLastFundingFeeResponse() => new BaseJsonHandler<MyLastFundingFeeResponse>();
        public ISingleMessageHandler<PredictedFundingRateMyFundingFeeResponse> CreatePredictedFundingRateMyFundingFeeResponse() => new BaseJsonHandler<PredictedFundingRateMyFundingFeeResponse>();
        //Position
        public ISingleMessageHandler<AddReduceMarginResponse> CreateAddReduceMarginResponse() => new BaseJsonHandler<AddReduceMarginResponse>();
        public ISingleMessageHandler<ClosedProfitLossResponse> CreateClosedProfitLossResponse() => new BaseJsonHandler<ClosedProfitLossResponse>();
        public ISingleMessageHandler<FullPartialPositionTPSLSwitchResponce> CreateFullPartialPositionTPSLSwitchResponce() => new BaseJsonHandler<FullPartialPositionTPSLSwitchResponce>();
        public ISingleMessageHandler<MyPositionResponse> CreateMyPositionResponse() => new BaseJsonHandler<MyPositionResponse>();
        public ISingleMessageHandler<SetAutoAddMarginResponse> CreateSetAutoAddMarginResponse() => new BaseJsonHandler<SetAutoAddMarginResponse>();
        public ISingleMessageHandler<SetAutoAddMarginResponse> CreateCrossIsolatedMarginSwitch() => new BaseJsonHandler<SetAutoAddMarginResponse>();
        public ISingleMessageHandler<SetAutoAddMarginResponse> CreateSetLeverage() => new BaseJsonHandler<SetAutoAddMarginResponse>();
        public ISingleMessageHandler<SetTradingStopResponse> CreateSetTradingStop() => new BaseJsonHandler<SetTradingStopResponse>();
        public ISingleMessageHandler<UserTradeRecordsResponse> CreateUserTradeRecordsResponse() => new BaseJsonHandler<UserTradeRecordsResponse>();
        //RiskLimit
        public ISingleMessageHandler<GetRiskLimitResponse> CreateGetRiskLimitResponse() => new BaseJsonHandler<GetRiskLimitResponse>();
        public ISingleMessageHandler<SetRiskLimitResponse> CreateSetRiskLimitResponse() => new BaseJsonHandler<SetRiskLimitResponse>();
        //wallet
        public ISingleMessageHandler<GetWalletBalanceResponse> CreateGetWalletBalanceResponse() => new BaseJsonHandler<GetWalletBalanceResponse>();
        public ISingleMessageHandler<WalletFundRecordsResponce> CreateWalletFundRecordsResponce() => new BaseJsonHandler<WalletFundRecordsResponce>();
        public ISingleMessageHandler<AssetExchangeRecordsResponse> CreateAssetExchangeRecordsResponse() => new BaseJsonHandler<AssetExchangeRecordsResponse>();
        //API
        public ISingleMessageHandler<APIKeyInfoResponse> CreateAPIKeyInfoResponse() => new BaseJsonHandler<APIKeyInfoResponse>();
        #endregion
    }
}
