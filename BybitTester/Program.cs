//using BybitMapper.InversePerpetual.RestV2.Requests.Account.ActiveOrders;
//using BybitMapper.InversePerpetual.RestV2.Requests.Market;
//using BybitMapper.Perpetual.RestV2.Data.Enums;
//using BybitMapper.Perpetual.RestV2.Requests;
//using BybitMapper.Perpetual.RestV2.Requests.Account.ActiveOrders;
//using BybitMapper.Perpetual.RestV2.Requests.Account.ConditionalOrders;
//using BybitMapper.Perpetual.RestV2.Requests.Account.Funding;
//using BybitMapper.Perpetual.RestV2.Requests.Account.Position;
//using BybitMapper.Perpetual.RestV2.Requests.Account.RiskLimit;
//using BybitMapper.Perpetual.RestV2.Requests.Account.Wallet;
//using BybitMapper.Perpetual.RestV2.Requests.Market;
//using BybitMapper.Spot.RestV1.Data.Enums;
//using BybitMapper.Spot.RestV1.Requests.Account;
//using BybitMapper.Spot.RestV1.Requests.Market;
using BybitMapper.InversePerpetual.RestV2.Requests.Market;
using BybitMapper.Perpetual.RestV2.Requests.Account.Wallet;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Order;
using BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Positions;
using BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Wallet;
using BybitMapper.UsdcPerpetual.RestV2.Requests.Market;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using BybitMapper.Spot.RestV1.Data.ObjectDTO.Account;

namespace BybitTester
{
    class Program
    {
        static void Main(string[] args)
        { 
            TesterByBit tester = new TesterByBit(false);
            #region [PublicRestPoints]

            //TesterByBit bit = new TesterByBit(true);
            //Done
            //var markets = tester.RESTHandlers.HandleKline(tester.SendTest(new KlineRequest(tester.Symbol, BybitMapper.InversePerpetual.RestV2.Data.KlineIntervalType.OneDay, DateTime.Now.AddDays(-1), 100)));
            //Done:
            //var result = tester.RESTHandlers.HandleLiquidatedOrders(tester.SendTest(new LiquidatedOrdersRequest(tester.Symbol,null,200,null,null)));
            //Done
            //var result = tester.RESTHandlers.HandleMarkPrice(tester.SendTest(new MarkPriceRequest(tester.Symbol, BybitMapper.InversePerpetual.RestV2.Data.KlineIntervalType.FiveMinute, DateTime.Now.AddDays(-1), null)));
            //Done
            //var result = tester.RESTHandlers.HandleOrderBook(tester.SendTest(new OrderBookRequest(tester.Symbol)));
            //Done
            // var result = tester.RESTHandlers.HandleServerTimeResponse(tester.SendTest(new ServerTimeRequest()));
            //Done
            //var result = tester.RESTHandlers.HandleSymbolInfo(tester.SendTest(new SymbolInfoRequest()));
            //Done
            //var result = tester.RESTHandlers.HandleOpenInterest(tester.SendTest(new SymbolOpenInterestRequest(tester.Symbol, BybitMapper.InversePerpetual.RestV2.Data.Enums.PeriodType.FiveMinute, null)));
            //Done
            //var result = tester.RESTHandlers.HandleSymbols(tester.SendTest(new SymbolsRequest()));
            //Done
            //var result = tester.RESTHandlers.HandleTradingRecords(tester.SendTest(new TradingRecordsRequest(tester.Symbol,null,null)));
            #endregion
            #region [PrivateRestPoints]
            //Func<long> GetTime = () =>
            //{
            //    return (long)Math.Round(tester.RESTHandlers.HandleServerTimeResponse(tester.SendTest(new ServerTimeRequest())).Timestamp * 1000);
            //};
            //------------------------------------------------------
            //            Артём Каминский[вчера, 16:43]
            //w0mUA06cibAmsrqimC
            //b0L3VbQxxBDcx11tXFsZ07PfYFSxxJexGV11
            //------------------------------------------------------

            //
            //
            //
            //
            // TesterByBit testerPrivate = new TesterByBit("vcs5Jptx3XE7yXAY5Q", "zW63AWFCKfdPwtujNzohmgdSQZAkh2eLWiA2", GetTime, true);
            // TesterByBit testerPrivate = new TesterByBit("w0mUA06cibAmsrqimC", "b0L3VbQxxBDcx11tXFsZ07PfYFSxxJexGV11", GetTime, true);
            // TesterByBit testerPrivate = new TesterByBit("SUB9e9ixzurzB5n0fa", "6MbzMLZoTWqVoveMZ85A9sSpLPMZrUfQ683s", GetTime, true);
            ////var resp = testerPrivate.SendTest(new MyPositionRequest(null));
            ////var pos = testerPrivate.RESTHandlers.HandleMyPositionResponse(resp); 
            ////var balance = testerPrivate.RESTHandlers.HandleGetWalletBalanceResponse(testerPrivate.SendTest(new GetWalletBalanceRequest("BTC")));
            //var result = testerPrivate.RESTHandlers.HandlePlaceOrder(

            //testerPrivate.SendTest(new PlaceOrderRequest(BybitMapper.InversePerpetual.RestV2.Data.OrderSideType.Buy, tester.Symbol, BybitMapper.InversePerpetual.RestV2.Data.Enums.OrderType.Limit, 1m, 30000, BybitMapper.InversePerpetual.RestV2.Data.Enums.TimeInForceType.PostOnly, null, null, null, null, null)
            //{
            //    Headers = new Dictionary<string, string>
            //        {
            //            { "Referer", "CScalp" }
            //        }
            //});
            // var resExchange = testerPrivate.SendTest(new AssetExchangeRecordsRequest(null, null, null));
            // var exchange = testerPrivate.RESTHandlers.HandleAssetExchangeRecordsResponse(resExchange);
            // var orders = testerPrivate.RESTHandlers.HandleGetActiveOrders(testerPrivate.SendTest(new GetActiveOrdersRequest(null,null,"BTCUSD",null,null,null,new List<BybitMapper.InversePerpetual.RestV2.Data.Enums.OrderStatusType> { BybitMapper.InversePerpetual.RestV2.Data.Enums.OrderStatusType.Created, BybitMapper.InversePerpetual.RestV2.Data.Enums.OrderStatusType.Cancelled, BybitMapper.InversePerpetual.RestV2.Data.Enums.OrderStatusType.Filled, BybitMapper.InversePerpetual.RestV2.Data.Enums.OrderStatusType.PartiallyFilled })));
            // var cancel = testerPrivate.RESTHandlers.HandleCancelActiveOrder(testerPrivate.SendTest(new CancelActiveOrderRequest("BTCUSD", result.Result.OrderId, null)));
            //var cancelall = testerPrivate.RESTHandlers.HandleCancelAllActiveOrder(testerPrivate.SendTest(new CancelAllActiveOrdersRequest("BTCUSD")));
            //var trades = testerPrivate.RESTHandlers.HandleUserTradeResponse(testerPrivate.SendTest(new UserTradesRequest("BTCUSD",null,null,null,null,null, DateTime.UtcNow.AddDays(-12))));
            #endregion

            #region[PiblicSpotPoints]
            //TesterByBit tester = new TesterByBit();

            //var respp = new BybitMapper.Spot.RestV1.Requests.Market.LatestInformationSymbolRequest();
            //respp.Symbol = "BTCUSDT";
            //var pairSettingss = tester.SPOTHandlers.HandleLatestInformationSymbolResponse(tester.SendTest(respp));

            //var respp = tester.SendTest(new BybitMapper.Spot.RestV1.Requests.Market.ServerTimeRequest());
            //var pairSettingss = tester.SPOTHandlers.HandleServerTimeResponse(respp);

            //var respp = tester.SendTest(new CandlestickChartRequest("ETHUSDT", CandlestickType.OneMinute));
            //var pairSettingss = tester.SPOTHandlers.HandleCandlestickChartResponse(respp);
            //Done
            //var respp = tester.SendTest(new GetSimbolsRequest());
            //var pairSettingss = tester.SPOTHandlers.HandleGetSimbolsResponse(respp);
            //Done
            //var respp = tester.SendTest(new OrderBookRequest("BTCUSDT"));
            //var pairSettingss = tester.SPOTHandlers.HandleOrderBookResponse(respp);
            //Done
            #endregion
            #region[PrivateSpotPoints]
            //TesterByBit tester = new TesterByBit(true);
            //Func<long> GetTime = () =>
            //{
            //    return tester.SPOTHandlers.HandleServerTimeResponse(tester.SendTest(new BybitMapper.Spot.RestV1.Requests.Market.ServerTimeRequest())).Result.ServerTimeLong;
            //};
            //TesterByBit testerPrivate = new TesterByBit("AgNYY1xevp0m9XJse5", "uC9auVfjds5C38CnquMN6mMSk7blEac0R3a8", GetTime, true);
            //var respp = testerPrivate.SendTest(new SpotWalletBalanceRequest());
            //var pairSettingss = testerPrivate.SPOTHandlers.HandleSpotWalletBalanceResponse(respp);

            //var respp = testerPrivate.SendTest(new CreateSpotOrderRequest("BTCUSDT", 11m, CreateSpotOrderSideType.Buy, CreateSpotOrderType.Market));
            //var pairSettingss = testerPrivate.SPOTHandlers.HandleCreateSpotOrderResponse(respp);
            //Done
            //var respp2 = testerPrivate.SendTest(new OrderListRequest());
            //var pairSettingss2 = testerPrivate.SPOTHandlers.HandleOrderListResponse(respp2);
            //Done
            //var respp_ = testerPrivate.SendTest(new CancelSpotOrderRequest());
            //var pairSettingss_ = testerPrivate.SPOTHandlers.HandleCancelSpotOrderResponse(respp_);
            //Done
            //var respp = testerPrivate.SendTest(new TradeHistoryRequest());
            //var pairSettingss = testerPrivate.SPOTHandlers.HandleTradeHistoryResponse(respp);
            //Done
            #endregion
            //var resp = testerPrivate.SendTest(new MyPositionRequest(null));
            //var pos = testerPrivate.RESTHandlers.HandleMyPositionResponse(resp);

            #region [PublicRestPointsPerpetual]

            //TesterByBit tester = new TesterByBit();

            //Done
            //var result = tester.TestHandler.HandleOrderBookResponse(tester.SendTest(new BybitMapper.Perpetual.RestV2.Requests.Market.OrderBookRequest(tester.Symbol)));
            //Done
            //var result4 = tester.TestHandler.HandleQuerySymbolResponse(tester.SendTest(new QuerySymbolRequest()));
            //done
            //var result = tester.TestHandler.HandleOpenInterestResponse(tester.SendTest(new OpenInterestRequest(tester.Symbol, PeriodType.FiveMinute)));
            //done
            //var result12 = tester.PRestHandler.HandleLatestInformationSymbolResponse(tester.SendTest(new BybitMapper.Perpetual.RestV2.Requests.Market.LatestInformationSymbolRequest()));
            //string test = "BTCUSDT";
            //done
            //var result = tester.TestHandler.HandleGetLastFundingRateResponse(tester.SendTest(new GetLastFundingRateRequest(test)));
            //done
            //var result1 = tester.TestHandler.HandlePublicTradingRecordsResponce(tester.SendTest(new PublicTradingRecordsRequest(test)));
            //done
            //var result2 = tester.TestHandler.HandleQueryKlineResponse(tester.SendTest(new QueryKlineRequest(test, IntervalType.FiveMinute, DateTime.Now.AddDays(-1))));

            //Это не будет работать, тк 
            //Liquidated Orders [abandoned] This endpoint is now offline. Please replace with the liquidation websocket.
            //var result = tester.TestHandler.HandleLiquidatedOrdersResponse(tester.SendTest(new BybitMapper.Perpetual.RestV2.Requests.Market.LiquidatedOrdersRequest(tester.Symbol, null, 200, null, null)));
            //null
            //var result3 = tester.TestHandler.HandleQueryMarkPriceKlineResponse(tester.SendTest(new QueryMarkPriceKlineRequest(test, IntervalType.FiveMinute, DateTime.Now)));
            #endregion
            #region [PrivateRestPointsPerpetual]
            //var response = "{\"topic\":\"execution\",\"data\":[{\"symbol\":\"PEOPLEUSDT\",\"side\":\"Buy\",\"order_id\":\"33f0c049-608c-43bd-8d08-23ccd7042d3b\",\"exec_id\":" +
            //               "\"c10f2e26-83b9-5d25-9b54-945c77b8074a\",\"order_link_id\":\"x-CScalpdP7lF1vkbUqKutugfyFkg\",\"price\":0.0837,\"order_qty\":1,\"exec_type\":\"Trade\",\"exec_qty\":1," +
            //               "\"exec_fee\":0.00006278,\"leaves_qty\":0,\"is_maker\":false,\"trade_time\":\"2022-02-09T12:53:27.349479Z\"}]}";
            //Func<long> GetTime = () =>
            //{
            //    return (long)Math.Round(tester.RESTHandlers.HandleServerTimeResponse(tester.SendTest(new BybitMapper.InversePerpetual.RestV2.Requests.Market.ServerTimeRequest())).Timestamp * 1000);
            //}; 
            //TesterByBit testerPrivate = new TesterByBit("zJzaErgNc7WlqIS26E", "1qcywPsLyX0ansrKAfOW3ohifWFqTEZ8mzY0", GetTime, true);
            //var resultEx = testerPrivate.PerpetualUHandler.HandleExecutionEvent(response);
            //var resultOr = testerPrivate.PerpetualUHandler.HandleOrderEvent(response);
            //Console.ReadKey();
            // TesterByBit testerPrivate = new TesterByBit("zJzaErgNc7WlqIS26E", "1qcywPsLyX0ansrKAfOW3ohifWFqTEZ8mzY0", GetTime, true);
            //
            // var responce = testerPrivate.SPOTHandlers.HandleOrderListResponse(
            //     "{\"ret_code\":0,\"ret_msg\":\"\",\"ext_code\":null,\"ext_info\":null,\"result\":[{\"accountId\":\"14392007\",\"exchangeId\":\"301\",\"symbol\":\"IZIUSDT\",\"symbolName\":\"IZIUSDT\",\"orderLinkId\":\"x-CScalpUuQzBrQ92UeTOxBOWEOdg\",\"orderId\":\"1050910053917276416\",\"price\":\"0.2678\",\"origQty\":\"1000.42\",\"executedQty\":\"0\",\"cummulativeQuoteQty\":\"0\",\"avgPrice\":\"0\",\"status\":\"NEW\",\"timeInForce\":\"GTC\",\"type\":\"LIMIT\",\"side\":\"SELL\",\"stopPrice\":\"0.0\",\"icebergQty\":\"0.0\",\"time\":\"1640014240909\",\"updateTime\":\"1640014240913\",\"isWorking\":true}]}");
            // var res = responce.Result[0].CreatedAt;
            // var res2 = res;


            //done
            #region [ActiveOrders]
            // PlaceActiveOrderRequest order = new PlaceActiveOrderRequest(SideType.Buy,"BTCUSDT", OrderType.Limit, 0.001m, TimeInForceType.PostOnly, false, false);
            // order.Price = 30000;
            // order.PositionIdx = PositionIdxType.Buy;

            // var placeActiveOrder = testerPrivate.PRestHandler.HandlePlaceActiveOrderResponse(testerPrivate.SendTest(order));
            //done история ордеров
            //var getActiveOrder = testerPrivate.PRestHandler.HandleGetActiveOrderResponse(testerPrivate.SendTest(new GetActiveOrderRequest("BTCUSDT")));
            //done 
            //CancelActiveOrderRequest orderId = new CancelActiveOrderRequest("BTCUSDT");
            //orderId.OrderId = "d1edd1a0-e651-465d-aef9-439d06b8cb05";
            //var сancelActiveOrder = testerPrivate.PRestHandler.HandleCancelActiveOrderResponse(testerPrivate.SendTest(orderId));
            //done все ордера отменяются
            //var сancelAllActiveOrders = testerPrivate.PRestHandler.HandleCancelAllActiveOrdersResponse(testerPrivate.SendTest(new CancelAllActiveOrdersRequest("BTCUSDT")));
            //done
            //ReplaceActiveOrderRequest replaceOrder = new ReplaceActiveOrderRequest("BTCUSDT");
            //replaceOrder.OrderId = "87ddaa87-3e17-4d27-986e-75429a353baf";
            //replaceOrder.PRPrice = 31000;
            //replaceOrder.PRQty = 0.001m;
            //var replaceActiveOrder = testerPrivate.PRestHandler.HandleReplaceActiveOrderResponse(testerPrivate.SendTest(replaceOrder));
            //список активных заказов
            //var queryOrder = new QueryActiveOrderRequest("BTCUSDT");
            //var queryActiveOrder = testerPrivate.PRestHandler.HandleQueryActiveOrderResponse(testerPrivate.SendTest(queryOrder));
            #endregion
            #region [ConditionalOrders]
            //var placeConditionalOrder = testerPrivate.PRestHandler.HandlePlaceConditionalOrderResponse(testerPrivate.SendTest(new PlaceConditionalOrderRequest(SideType.Buy,"BTCUSDT",OrderType.Limit,0.001m,30000,0,TimeInForceType.PostOnly,false,false)));
            //var getConditionalOrder = testerPrivate.PRestHandler.HandleGetConditionalOrderResponse(testerPrivate.SendTest(new GetConditionalOrderRequest("BTCUSDT")));
            //var cancelConditionalOrder = testerPrivate.PRestHandler.HandleCancelConditionalOrderResponse(testerPrivate.SendTest(new CancelConditionalOrderRequest("BTCUSDT")));
            //var cancelAllConditionalOrders = testerPrivate.PRestHandler.HandleCancelAllConditionalOrdersResponse(testerPrivate.SendTest(new CancelAllConditionalOrdersRequest("BTCUSDT")));
            //var replaceConditionalOrder = testerPrivate.PRestHandler.HandleReplaceConditionalOrderResponse(testerPrivate.SendTest(new ReplaceConditionalOrderRequest("BTCUSDT")));
            //var queryConditionalOrder = testerPrivate.PRestHandler.HandleQueryConditionalOrderResponse(testerPrivate.SendTest(new QueryConditionalOrderRequest("BTCUSDT")));
            #endregion
            //6 done   3 ???
            #region [Position]
            //done
            //var myPosition = testerPrivate.PRestHandler.HandleMyPositionResponse(testerPrivate.SendTest(new MyPositionRequest("BTCUSDT")));
            //done
            //var setAutoAddMargin = testerPrivate.PRestHandler.HandleSetAutoAddMarginResponse(testerPrivate.SendTest(new SetAutoAddMarginRequest("BTCUSDT",SideType.Sell,false)));
            //done // fix tp sl mode?
            //var fullPartialPositionTPSLSwitch = testerPrivate.PRestHandler.HandleFullPartialPositionTPSLSwitchResponce(testerPrivate.SendTest(new FullPartialPositionTPSLSwitchRequest("BTCUSDT", TpSlModeType.Partial)));
            //done если autoMargin false
            //var setLeverage = testerPrivate.PRestHandler.HandleSetLeverageResponse(testerPrivate.SendTest(new SetAutoAddMarginRequest("BTCUSDT",SideType.Sell,true)));
            //done list trading records
            // var request = new UserTradeRecordsRequest("BTCUSDT");
            // request.StartTime = DateTime.UtcNow.AddDays(-1);
            // var userTradeRecords = testerPrivate.PRestHandler.HandleUserTradeRecordsResponse(testerPrivate.SendTest(request));
            // var res = userTradeRecords;
            // //done
            //var closedProfitLoss = testerPrivate.PRestHandler.HandleClosedProfitLossResponse(testerPrivate.SendTest(new ClosedProfitLossRequest("BTCUSDT")));


            //message: position is in crossMargin
            //var addReduceMargin = testerPrivate.PRestHandler.HandleAddReduceMarginResponse(testerPrivate.SendTest(new AddReduceMarginRequest("BTCUSDT", SideType.Sell, 0.001m)));
            //message: "buy or sell leverage less than 1"
            //var crossIsolatedMarginSwitch = testerPrivate.PRestHandler.HandleCrossIsolatedMarginSwitchResponse(testerPrivate.SendTest(new CrossIsolatedMarginSwitchRequest("BTCUSDT",false,1,0)));
            //message: not modified
            //var setTradingStop = testerPrivate.PRestHandler.HandleSetTradingStopResponse(testerPrivate.SendTest(new SetTradingStopRequest("BTCUSDT",SideType.Buy)));
            #endregion
            #region [RiskLimit]
            //var getRiskLimit = testerPrivate.PRestHandler.HandleGetRiskLimitResponse(testerPrivate.SendTest(new GetRiskLimitRequest("BTCUSDT")));
            //var setRiskLimit = testerPrivate.PRestHandler.HandleSetRiskLimitResponse(testerPrivate.SendTest(new SetRiskLimitRequest("BTCUSDT")));
            #endregion
            #region [Funding]
            //var getLastFundingRate = testerPrivate.PRestHandler.HandleGetLastFundingRateResponse(testerPrivate.SendTest(new GetLastFundingRateRequest("BTCUSDT")));
            //var handleMyLastFundingFee = testerPrivate.PRestHandler.HandleMyLastFundingFeeResponse(testerPrivate.SendTest(new MyLastFundingFeeRequest("BTCUSDT")));
            //var predictedFundingRateMyFundingFee = testerPrivate.PRestHandler.HandlePredictedFundingRateMyFundingFeeResponse(testerPrivate.SendTest(new PredictedFundingRateMyFundingFeeRequest("BTCUSDT")));
            #endregion
            //done
            #region [Wallet]
            //var wallet = new GetWalletBalanceRequest();
            //wallet.Coin = "BTC";
            //var walletBalance = testerPrivate.PRestHandler.HandleWalletBalanceResponse(testerPrivate.SendTest(wallet));
            #endregion
            //done
            #region [APIKeyInfo]
            //var aPIKeyInfo = testerPrivate.PRestHandler.HandleAPIKeyInfoResponse(testerPrivate.SendTest(new APIKeyInfoRequest()));
            #endregion
            #endregion

            #region [PublicUsdcPerpetual]

            //TesterByBit tester = new TesterByBit(true);
            //var result1 = tester.UsdcPRestHandler.HandleLatestSymbolInfoReponse(tester.SendTest(new LatestSymbolInfoRequest("BTCPERP")));
            //var p = 3434;
            //Done
            //var result1 = tester.UsdcPRestHandler.HandleContractInfoResponce(tester.SendTest(new ContractInfoRequest()));
            //var result2 = tester.UsdcPRestHandler.HandleOrderBookResponse(tester.SendTest(new OrderBookRequest("BTCPERP")));
            //прилетает респонс с нулевым массивом
            //var result3 = tester.UsdcPRestHandler.HandleQueryKlineResponse(tester.SendTest(new QueryKlineRequest("BTCPERP",IntervalType.OneMinute,DateTime.Today.AddDays(-1))));

            #endregion

            #region [PrivateUsdcPerpetual]
            //TesterByBit tester = new TesterByBit(false);
            //Func<long> GetTime = () =>
            //{
            //    return (long)Math.Round(tester.UsdcPRestHandler.HandleServerTimeResponse(tester.SendTest(new BybitMapper.UsdcPerpetual.RestV2.Requests.Market.ServerTimeRequest())).Timestamp * 1000);
            //};

            //TesterByBit testerPrivate = new TesterByBit("", "", GetTime, true);
            //tester = new TesterByBit(true);
            //done
            //var walletBalance = testerPrivate.UsdcPRestHandler.HandleWalletInfoResponse(testerPrivate.SendTest(new BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Wallet.WalletInfoRequest()));
            //done
            //var queryOrderHistoryReq = new QueryOrderHistoryRequest(BybitMapper.UsdcPerpetual.RestV2.Data.Enums.CategoryType.Perpetual);

            //var queryOrderHistory = testerPrivate.UsdcPRestHandler.HandleQueryOrderHistoryResponse(testerPrivate.SendTest(queryOrderHistoryReq));
            //done
            //var tradeHistoryReq = new TradeHistoryRequest(CategoryType.Perpetual, DateTime.Now.AddDays(-100), 10);
            //var tradeHistoryReq = new TradeHistoryRequest(CategoryType.Perpetual, 10);
            //var queryOrderHistory = testerPrivate.UsdcPRestHandler.HandleTradeHistoryResponse(testerPrivate.SendTest(tradeHistoryReq));

            //done
            //var positionReq = new QueryMyPositionsRequest(CategoryType.Perpetual);
            //var position = testerPrivate.UsdcPRestHandler.HandleQueryMyPositionsResponse(testerPrivate.SendTest(positionReq));
            //done
            //var placeOrderReq = new PlaceOrderRequest("BTCPERP", OrderType.Limit, OrderFilterType.Order, SideType.Buy, 0.001m);
            //placeOrderReq.OrderPrice = 10000m;
            //var placeOrder = testerPrivate.UsdcPRestHandler.HandlePlaceOrderResponse(testerPrivate.SendTest(placeOrderReq));
            //done
            //var cancelOrderReq = new CancelOrderRequest("BTCPERP", OrderFilterType.Order);
            //cancelOrderReq.OrderId = "97b7edbe-6710-4238-82a3-28fb0c2c3d11";
            //var cancelOrder = testerPrivate.UsdcPRestHandler.HandleCancelOrderResponse(testerPrivate.SendTest(cancelOrderReq));


            #endregion

            var res = tester.SPOTHandlers.HandleErrorResponse(
                "{\"ret_code\":-1137,\"ret_msg\":\"Order volume decimal too long\",\"result\":{},\"ext_code\":\"\",\"ext_info\":null,\"time_now\":\"1662130670.943059\"}");
            Console.ReadKey();
        }
    }
}
