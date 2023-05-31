﻿using System;
using BybitMapper.Handlers;
using BybitMapper.Spot.RestV3.Responses;
using BybitMapper.Spot.RestV3.Responses.Account;
using BybitMapper.Spot.RestV3.Responses.Market;
using JetBrains.Annotations;

namespace BybitMapper.Spot.RestV3
{
    public sealed class SpotHandlerCompositionV3
    {
        #region [Market]
        [NotNull]
        private readonly ISingleMessageHandler<ErrorResponse> _ErrorResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CandlestickChartResponse> _candlestickChartResponse;
        [NotNull]
        private readonly ISingleMessageHandler<GetSymbolsResponse> _getSymbolsResponse;
        [NotNull]
        private readonly ISingleMessageHandler<OrderBookResponse> _orderBookResponse;
        [NotNull]
        private readonly ISingleMessageHandler<ServerTimeResponse> _serverTimeResponse;
        [NotNull]
        private readonly ISingleMessageHandler<LatestInformationSymbolResponse> _latestInformationSymbolResponse;
        #endregion
        #region [Account]
        [NotNull]
        private readonly ISingleMessageHandler<CancelSpotOrderResponse> _cancelSpotOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<CreateSpotOrderResponse> _createSpotOrderResponse;
        [NotNull]
        private readonly ISingleMessageHandler<OrderListResponse> _orderListResponse;
        [NotNull]
        private readonly ISingleMessageHandler<TradeHistoryResponse> _tradeHistoryResponse;
        [NotNull]
        private readonly ISingleMessageHandler<SpotWalletBalanceResponse> _spotWalletBalanceResponse;
        #endregion
        public SpotHandlerCompositionV3([NotNull] ISpotHandlerFactoryV3 factory)
        {
            if (factory is null) throw new ArgumentNullException(nameof(factory));
            #region [Market]
            _ErrorResponse = factory.CreateErrorResponse();
            _candlestickChartResponse = factory.CreateCandlestickChartResponse();
            _getSymbolsResponse = factory.CreateGetSymbolsResponse();
            _orderBookResponse = factory.CreateOrderBookResponse();
            _serverTimeResponse = factory.CreateServerTimeResponse();
            _latestInformationSymbolResponse = factory.CreateLatestInformationSymbolResponse();
            #endregion
            #region [Account]
            _cancelSpotOrderResponse = factory.CreateCancelSpotOrderResponse();
            _createSpotOrderResponse = factory.CreateCreateSpotOrderResponse();
            _orderListResponse = factory.CreateOrderListResponse();
            _tradeHistoryResponse = factory.CreateTradeHistoryResponse();
            _spotWalletBalanceResponse = factory.CreateSpotWalletBalanceResponse();
            #endregion
        }
        #region [Market]
        public ErrorResponse HandleErrorResponse(string message) => _ErrorResponse.HandleSingle(message);
        public LatestInformationSymbolResponse HandleLatestInformationSymbolResponse(string message) => _latestInformationSymbolResponse.HandleSingle(message);
        public CandlestickChartResponse HandleCandlestickChartResponse(string message) => _candlestickChartResponse.HandleSingle(message);
        public GetSymbolsResponse HandleGetSymbolsResponse(string message) => _getSymbolsResponse.HandleSingle(message);
        public OrderBookResponse HandleOrderBookResponse(string message) => _orderBookResponse.HandleSingle(message);
        public ServerTimeResponse HandleServerTimeResponse(string message) => _serverTimeResponse.HandleSingle(message);
        #endregion
        #region [Account]
        public CancelSpotOrderResponse HandleCancelSpotOrderResponse(string message) => _cancelSpotOrderResponse.HandleSingle(message);
        public CreateSpotOrderResponse HandleCreateSpotOrderResponse(string message) => _createSpotOrderResponse.HandleSingle(message);
        public OrderListResponse HandleOrderListResponse(string message) => _orderListResponse.HandleSingle(message);
        public TradeHistoryResponse HandleTradeHistoryResponse(string message) => _tradeHistoryResponse.HandleSingle(message);
        public SpotWalletBalanceResponse HandleSpotWalletBalanceResponse(string message) => _spotWalletBalanceResponse.HandleSingle(message);
        #endregion
    }
}
