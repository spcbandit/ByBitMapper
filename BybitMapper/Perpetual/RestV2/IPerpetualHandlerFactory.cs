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

namespace BybitMapper.Perpetual.RestV2
{
    /// <summary>
    /// Интерфейс фабрики Account Data Endpoints и Market Data Endpoints для USDT Perpetual
    /// </summary>
    public interface IPerpetualHandlerFactory
    {
        #region [Market]
        [NotNull]
        ISingleMessageHandler<GetLastFundingRateResponse> CreateGetLastFundingRateResponse();
        [NotNull]
        ISingleMessageHandler<LatestInformationSymbolResponse> CreateLatestInformationSymbolResponse();
        [NotNull]
        ISingleMessageHandler<LiquidatedOrdersResponse> CreateLiquidatedOrdersResponse();
        [NotNull]
        ISingleMessageHandler<OpenInterestResponse> CreateOpenInterestResponse();
        [NotNull]
        ISingleMessageHandler<OrderBookResponse> CreateOrderBookResponse();
        [NotNull]
        ISingleMessageHandler<PublicTradingRecordsResponce> CreatePublicTradingRecordsResponce();
        [NotNull]
        ISingleMessageHandler<QueryKlineResponse> CreateQueryKlineResponse();
        [NotNull]
        ISingleMessageHandler<QueryMarkPriceKlineResponse> CreateQueryMarkPriceKlineResponse();
        [NotNull]
        ISingleMessageHandler<QuerySymbolResponse> CreateQuerySymbolResponse();
        [NotNull]
        ISingleMessageHandler<ServerTimeResponse> CreateServerTimeResponse();
        
        #endregion
        #region [Account]
        #region [ActiveOrders]
        [NotNull]
        ISingleMessageHandler<CancelActiveOrderResponse> CreateCancelActiveOrderResponse();
        [NotNull]
        ISingleMessageHandler<CancelAllActiveOrdersResponse> CreateCancelAllActiveOrdersResponse();
        [NotNull]
        ISingleMessageHandler<GetActiveOrderResponse> CreateGetActiveOrderResponse();
        [NotNull]
        ISingleMessageHandler<PlaceActiveOrderResponse> CreatePlaceActiveOrderResponse();
        [NotNull]
        ISingleMessageHandler<QueryActiveOrderResponse> CreateQueryActiveOrderResponse();
        [NotNull]
        ISingleMessageHandler<ReplaceActiveOrderResponse> CreateReplaceActiveOrderResponse();
        #endregion
        #region [ConditionalOrders]
        [NotNull]
        ISingleMessageHandler<CancelAllConditionalOrdersResponse> CreateCancelAllConditionalOrdersResponse();
        [NotNull]
        ISingleMessageHandler<CancelConditionalOrderResponse> CreateCancelConditionalOrderResponse();
        [NotNull]
        ISingleMessageHandler<GetConditionalOrderResponse> CreateGetConditionalOrderResponse();
        [NotNull]
        ISingleMessageHandler<PlaceConditionalOrderResponse> CreatePlaceConditionalOrderResponse();
        [NotNull]
        ISingleMessageHandler<QueryConditionalOrderResponse> CreateQueryConditionalOrderResponse();
        [NotNull]
        ISingleMessageHandler<ReplaceConditionalOrderResponse> CreateReplaceConditionalOrderResponse();
        #endregion
        #region [Funding]
        [NotNull]
        ISingleMessageHandler<MyLastFundingFeeResponse> CreateMyLastFundingFeeResponse();
        [NotNull]
        ISingleMessageHandler<PredictedFundingRateMyFundingFeeResponse> CreatePredictedFundingRateMyFundingFeeResponse();
        #endregion
        #region [Position]
        [NotNull]
        ISingleMessageHandler<AddReduceMarginResponse> CreateAddReduceMarginResponse();
        [NotNull]
        ISingleMessageHandler<PositionModeSwitchResponse> CreatePositionModeSwitchResponse();
        [NotNull]
        ISingleMessageHandler<ClosedProfitLossResponse> CreateClosedProfitLossResponse();
        [NotNull]
        ISingleMessageHandler<FullPartialPositionTPSLSwitchResponce> CreateFullPartialPositionTPSLSwitchResponce();
        [NotNull]
        ISingleMessageHandler<MyPositionResponse> CreateMyPositionResponse();
        [NotNull]
        ISingleMessageHandler<SetAutoAddMarginResponse> CreateSetAutoAddMarginResponse();
        [NotNull]
        ISingleMessageHandler<SetAutoAddMarginResponse> CreateCrossIsolatedMarginSwitch();
        [NotNull]
        ISingleMessageHandler<SetAutoAddMarginResponse> CreateSetLeverage();
        [NotNull]
        ISingleMessageHandler<SetTradingStopResponse> CreateSetTradingStop();
        [NotNull]
        ISingleMessageHandler<UserTradeRecordsResponse> CreateUserTradeRecordsResponse();
        #endregion
        #region [RiskLimit]
        [NotNull]
        ISingleMessageHandler<GetRiskLimitResponse> CreateGetRiskLimitResponse();
        [NotNull]
        ISingleMessageHandler<SetRiskLimitResponse> CreateSetRiskLimitResponse();
        #endregion
        #region [Wallet]
        [NotNull]
        ISingleMessageHandler<GetWalletBalanceResponse> CreateGetWalletBalanceResponse();
        [NotNull]
        ISingleMessageHandler<WalletFundRecordsResponce> CreateWalletFundRecordsResponce();
        [NotNull]
        ISingleMessageHandler<AssetExchangeRecordsResponse> CreateAssetExchangeRecordsResponse();
        #endregion
        [NotNull]
        ISingleMessageHandler<APIKeyInfoResponse> CreateAPIKeyInfoResponse();
        #endregion
    }
}
