using BybitMapper.Handlers;
using BybitMapper.InversePerpetual.RestV2.Data.ObjectDTO;
using BybitMapper.InversePerpetual.RestV2.Responses;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.ActiveOrders;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.ConditionalOrders;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.Funding;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.Positions;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.RiskLimit;
using BybitMapper.InversePerpetual.RestV2.Responses.Account.Wallet;
using BybitMapper.InversePerpetual.RestV2.Responses.Market;

namespace BybitMapper.InversePerpetual.RestV2
{
    public sealed class InversePerpetualV2HandlerFactory : IInversePerpetualV2HandlerFactory
    {
        #region [market]
        public ISingleMessageHandler<ErrorResponse> CreateErrorResponse() => new BaseJsonHandler<ErrorResponse>();
        public ISingleMessageHandler<OrderBookResponse> CreateOrderBookResponse() => new BaseJsonHandler<OrderBookResponse>();
        public ISingleMessageHandler<KlineResponse> CreateKlineResponse() => new BaseJsonHandler<KlineResponse>();
        public ISingleMessageHandler<SymbolInfoResponse> CreateSymbolInfoResponse() => new BaseJsonHandler<SymbolInfoResponse>();
        public ISingleMessageHandler<TradingRecordsResponse> CreateTradingRecordsResponse() => new BaseJsonHandler<TradingRecordsResponse>();
        public ISingleMessageHandler<SymbolsResponse> CreateSymbolsResponse() => new BaseJsonHandler<SymbolsResponse>();
        public ISingleMessageHandler<LiquidatedOrdersResponse> CreateLiquidatedOrdersResponse() => new BaseJsonHandler<LiquidatedOrdersResponse>();
        public ISingleMessageHandler<MarkPriceResponse> CreateMarkPriceKlineResponse() => new BaseJsonHandler<MarkPriceResponse>();
        public ISingleMessageHandler<SymbolOpenInterestResponse> CreateSymbolOpenInterestResponse() => new BaseJsonHandler<SymbolOpenInterestResponse>();
        public ISingleMessageHandler<ServerTimeResponse> CreateServerTimeResponse() => new BaseJsonHandler<ServerTimeResponse>();
        #endregion
        #region [Account]
        public ISingleMessageHandler<PlaceOrdersResponse> CreatePlaceOrdersResponse() => new BaseJsonHandler<PlaceOrdersResponse>();
        public ISingleMessageHandler<GetActiveOrdersResponse> CreateGetActiveOrdersResponse() => new BaseJsonHandler<GetActiveOrdersResponse>();
        public ISingleMessageHandler<CancelActiveOrderResponse> CreateCancelActiveOrderResponse() => new BaseJsonHandler<CancelActiveOrderResponse>();
        public ISingleMessageHandler<CancelAllOrdersResponse> CreateCancelAllActiveOrdersResponse() => new BaseJsonHandler<CancelAllOrdersResponse>();
        // public ISingleMessageHandler<PlaceConditionalOrderResponse> CreatePlaceConditionOrdersResponse() => new BaseJsonHandler<PlaceConditionalOrderResponse>();
        public ISingleMessageHandler<GetConditionalOrderResponse> CreateGetConditionalOrderResponse() => new BaseJsonHandler<GetConditionalOrderResponse>();
        public ISingleMessageHandler<CancelConditionalOrderResponse> CreateCancelConditionalOrderResponse() => new BaseJsonHandler<CancelConditionalOrderResponse>();
        public ISingleMessageHandler<CancelAllConditionalOrdersResponse> CreateCancelAllConditionalOrdersResponse() => new BaseJsonHandler<CancelAllConditionalOrdersResponse>();
        public ISingleMessageHandler<ReplaceConditionalResponse> CreateReplaceConditionalOrder() => new BaseJsonHandler<ReplaceConditionalResponse>();
        public ISingleMessageHandler<GetLastFundingRateResponse> CreateGetLastFundingRateResponse() => new BaseJsonHandler<GetLastFundingRateResponse>();
        public ISingleMessageHandler<MyLastFundingFeeResponse> CreateMyLastFundingFeeResponse() => new BaseJsonHandler<MyLastFundingFeeResponse>();
        public ISingleMessageHandler<GetRiskLimitResponse> CreateGetRiskLimitResponse() => new BaseJsonHandler<GetRiskLimitResponse>();
        public ISingleMessageHandler<SetRiskLimitResponse> CreateSetRiskLimitResponse() => new BaseJsonHandler<SetRiskLimitResponse>();
        public ISingleMessageHandler<MyPositionResponse> CreateMyPositionResponse() => new BaseJsonHandler<MyPositionResponse>();
        public ISingleMessageHandler<ChangeMarginResponse> CreateChangeMarginResponse() => new BaseJsonHandler<ChangeMarginResponse>();
        public ISingleMessageHandler<SetLeverageResponse> CreateSetLeverageResponse() => new BaseJsonHandler<SetLeverageResponse>();
        public ISingleMessageHandler<GetWalletBalanceResponse> CreateGetWalletBalanceResponse() => new BaseJsonHandler<GetWalletBalanceResponse>();
        public ISingleMessageHandler<WalletFundRecordsResponce> CreateWalletFundRecordsResponce() => new BaseJsonHandler<WalletFundRecordsResponce>();
        public ISingleMessageHandler<AssetExchangeRecordsResponse> CreateAssetExchangeRecordsResponse() => new BaseJsonHandler<AssetExchangeRecordsResponse>();
        public ISingleMessageHandler<UserTradeResponse> CreateUserTradeResponse() => new BaseJsonHandler<UserTradeResponse>();
        public ISingleMessageHandler<PlaceConditionalOrderResponse>CreatePlaceConditionalOrderResponse() => new BaseJsonHandler<PlaceConditionalOrderResponse>();
        public ISingleMessageHandler<SetTradingStopResponse>CreateSetTradingStopResponse() => new BaseJsonHandler<SetTradingStopResponse>();
        public ISingleMessageHandler<FullPartialTPSLResponse>CreateFullPartialTPSLResponse() => new BaseJsonHandler<FullPartialTPSLResponse>();
        #endregion
    }
}