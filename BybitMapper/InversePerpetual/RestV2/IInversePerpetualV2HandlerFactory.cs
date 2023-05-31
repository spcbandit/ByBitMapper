using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.ActiveOrders;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.ConditionalOrders;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.Funding;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.RiskLimit;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.Positions;
using BybitMapper.InversePerpetual.RestV2.Responses.Market;

using JetBrains.Annotations;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.Wallet;
using BybitMapper.InversePerpetual.RestV2.Responses;

namespace BybitMapper.InversePerpetual.RestV2
{
    public interface IInversePerpetualV2HandlerFactory
    {
        #region [Market]
        [NotNull]
        ISingleMessageHandler<ErrorResponse> CreateErrorResponse();
        [NotNull]
        ISingleMessageHandler<OrderBookResponse> CreateOrderBookResponse();
        [NotNull]
        ISingleMessageHandler<KlineResponse> CreateKlineResponse();
        [NotNull]
        ISingleMessageHandler<SymbolInfoResponse> CreateSymbolInfoResponse();
        [NotNull]
        ISingleMessageHandler<TradingRecordsResponse> CreateTradingRecordsResponse();
        [NotNull]
        ISingleMessageHandler<SymbolsResponse> CreateSymbolsResponse();
        [NotNull]
        ISingleMessageHandler<LiquidatedOrdersResponse> CreateLiquidatedOrdersResponse();
        [NotNull]
        ISingleMessageHandler<MarkPriceResponse> CreateMarkPriceKlineResponse();
        [NotNull]
        ISingleMessageHandler<SymbolOpenInterestResponse> CreateSymbolOpenInterestResponse();
        [NotNull]
        ISingleMessageHandler<ServerTimeResponse> CreateServerTimeResponse();
        #endregion
        #region [Account]
        [NotNull]
        ISingleMessageHandler<PlaceOrdersResponse> CreatePlaceOrdersResponse();
        [NotNull]
        ISingleMessageHandler<CancelActiveOrderResponse> CreateCancelActiveOrderResponse();
        [NotNull]
        ISingleMessageHandler<GetActiveOrdersResponse> CreateGetActiveOrdersResponse();
        [NotNull]
        ISingleMessageHandler<CancelAllOrdersResponse> CreateCancelAllActiveOrdersResponse();
        [NotNull]
        ISingleMessageHandler<UserTradeResponse> CreateUserTradeResponse();
        // [NotNull]
        // ISingleMessageHandler<PlaceConditionalOrderResponse> CreatePlaceConditionOrdersResponse();
        [NotNull]
        ISingleMessageHandler<GetConditionalOrderResponse> CreateGetConditionalOrderResponse();
        [NotNull]
        ISingleMessageHandler<CancelConditionalOrderResponse> CreateCancelConditionalOrderResponse();
        [NotNull]
        ISingleMessageHandler<CancelAllConditionalOrdersResponse> CreateCancelAllConditionalOrdersResponse();
        [NotNull]
        ISingleMessageHandler<ReplaceConditionalResponse> CreateReplaceConditionalOrder();
        [NotNull]
        ISingleMessageHandler<GetLastFundingRateResponse> CreateGetLastFundingRateResponse();
        [NotNull]
        ISingleMessageHandler<MyLastFundingFeeResponse> CreateMyLastFundingFeeResponse();
        [NotNull]
        ISingleMessageHandler<GetRiskLimitResponse> CreateGetRiskLimitResponse();
        [NotNull]
        ISingleMessageHandler<SetRiskLimitResponse> CreateSetRiskLimitResponse();
        [NotNull]
        ISingleMessageHandler<MyPositionResponse> CreateMyPositionResponse();
        [NotNull]
        ISingleMessageHandler<ChangeMarginResponse> CreateChangeMarginResponse();
        [NotNull]
        ISingleMessageHandler<SetLeverageResponse> CreateSetLeverageResponse();
        [NotNull]
        ISingleMessageHandler<GetWalletBalanceResponse> CreateGetWalletBalanceResponse();
        [NotNull]
        ISingleMessageHandler<WalletFundRecordsResponce> CreateWalletFundRecordsResponce();
        [NotNull]
        ISingleMessageHandler<AssetExchangeRecordsResponse> CreateAssetExchangeRecordsResponse();
        [NotNull]
        ISingleMessageHandler<PlaceConditionalOrderResponse> CreatePlaceConditionalOrderResponse();
        ISingleMessageHandler<SetTradingStopResponse> CreateSetTradingStopResponse();
        ISingleMessageHandler<FullPartialTPSLResponse> CreateFullPartialTPSLResponse();
        #endregion
    }
}
