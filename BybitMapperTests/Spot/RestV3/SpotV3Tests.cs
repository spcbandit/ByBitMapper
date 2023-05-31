using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Authentication;
using System.Threading;
using System.Threading.Tasks;
using BybitMapper.Requests;
using BybitMapper.Spot.MarketStreamsV3;
using BybitMapper.Spot.MarketStreamsV3.Data;
using BybitMapper.Spot.RestV3;
using BybitMapper.Spot.RestV3.Data.Enums;
using BybitMapper.Spot.RestV3.Requests.Account;
using BybitMapper.Spot.RestV3.Requests.Market;
using BybitMapper.Spot.RestV3.Responses.Account;
using BybitMapper.Spot.RestV3.Responses.Market;
using BybitMapper.Spot.UserStreamsV3;
using BybitMapper.Spot.UserStreamsV3.Enums;
using BybitMapper.Spot.UserStreamsV3.Subscriptions;
using NUnit.Framework;
using RestSharp;
using WebSocketSharp;
using EventType = BybitMapper.Spot.MarketStreamsV3.Data.EventType;
using SubType = BybitMapper.Spot.UserStreamsV3.Enums.SubType;

namespace BybitMapperTests
{
    public class SpotV3Tests
    {
		public SpotHandlerCompositionV3 RESTHandlers;

		public MarketStreamsHandlerCompositionV3 MarketV3StreamsHandler = 
            new MarketStreamsHandlerCompositionV3(new MarketStreamsHandlerFactoryV3());

        public UserStreamsHandlerCompositionV3 UserV3StreamsHandler =
            new UserStreamsHandlerCompositionV3(new UserStreamsHandlerFactoryV3());

        private const string ApiKey = "2pam4sQkFE6yIz5Ily";
        
        private const string SecretKey = "Ds5eEKo5ZfmMPNSzGxTWBtiBUVXv0ivEx7dy";

  //       private const string ApiKey = "sKBvMgsXbONGJQ1Zuq";
  //
		// private const string SecretKey = "HFh9Ddp27gK8FHCE2nIPHarUDG4tBQNh6C16";

        private const string ApiTestnetKey = "MxFNcjLnOUfYZNH8Rw";

        private const string SecretTestnetKey = "QA1f39m8LLRR5Y4K9v81pyCxxGifBqgCXv04";

		private const string pathTestnetApi = "https://api-testnet.bybit.com";

		private const string pathApi = "https://api.bybit.com";

        private const string pathPublicMainnetWss = "wss://stream.bybit.com/spot/public/v3";

        private const string pathPrivateMainnetWss = "wss://stream.bybit.com/spot/private/v3";

        private const string pathPublicTestnetWss = "wss://stream-testnet.bybit.com/spot/public/v3";

        private const string pathPrivateTestnetWss = "wss://stream-testnet.bybit.com/spot/private/v3";

        private RequestArranger requestArranger;

		private RestClient client;

		private WebSocket socket;

        private const string testedSymbol = "ADAUSDT";

        private const decimal testedSymbolQty = 2;

        public SpotV3Tests()
		{
			client = new RestClient(pathApi);

			requestArranger = new RequestArranger(ApiKey, SecretKey, GetTime);

			RESTHandlers = new SpotHandlerCompositionV3(new SpotHandlerFactoryV3());
        }

		private long GetTime()
		{
			var request = new ServerTimeRequest();
            var message = SendTest(request);
            var response = RESTHandlers.HandleServerTimeResponse(message);
            return (long)response.Result.ServerTime;
		}

		#region [REST API]

        [Test]
        public void RestPublicGetServerTime_Success()
        {
			this.GetTime();
        }

        /// <summary>
        /// Тест, в котором проверяется корректность получения списка инструментов
        /// </summary>
        [Test]
        public void RestPublicGetSymbolsInfo_Success()
        {
            var request = new GetSymbolsRequest();
            var message = SendTest(request);
            var response = RESTHandlers.HandleGetSymbolsResponse(message);
            var list = response.Result.List.ToList();

            Assert.IsNotNull(list);

            var first = list.FirstOrDefault();
            Assert.IsNotNull(first);
            Assert.IsNotNull(first.Alias);
            Assert.IsNotNull(first.BaseCoin);
            Assert.IsNotNull(first.Name);
            Assert.IsNotNull(first.Category);
            Assert.IsNotNull(first.QuoteCoin);
            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);
        }

		/// <summary>
		/// Тест, в котором проверяется корретность работы списка асков и бидов для инструмента
		/// </summary>
        [Test]
        public void RestPublicGetOrderBook_Success()
        {
            var testedSymbol = "XRPUSDT";
            var request = new OrderBookRequest(testedSymbol);
            var message = SendTest(request);
            var response = RESTHandlers.HandleOrderBookResponse(message);
            var askList = response.Result.Asks.ToList();
            var bidList = response.Result.Bids.ToList();

            Assert.IsNotNull(askList);
            Assert.IsNotNull(bidList);

            Assert.IsTrue(askList.Count > 0);
            Assert.IsTrue(bidList.Count > 0);

            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);
		}

        /// <summary>
        /// Тест, в котором проверяется корректность получения истории
        /// по указанному инструменту и указанному таймфрейму
        /// </summary>
		[Test]
        public void RestPublicGetCandlestick_Success()
        {
            var request = new CandlestickChartRequest("ADAUSDC", CandlestickType.FourHour);

            var message = SendTest(request);
            var response = RESTHandlers.HandleCandlestickChartResponse(message);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Result);

            Assert.IsTrue(response.Result.List.Count > 0);

            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);

            var first = response.Result.List.FirstOrDefault();

            Assert.IsNotNull(first);
            Assert.IsNotNull(first.Timestamp);
            Assert.IsNotNull(first.Name);
            Assert.IsNotNull(first.Alias);
            Assert.IsNotNull(first.ClosePrice);
            Assert.IsNotNull(first.HighestPrice);
            Assert.IsNotNull(first.LowestPrice);
            Assert.IsNotNull(first.OpenPrice);
            Assert.IsNotNull(first.Volume);
            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);
        }

        /// <summary>
		/// Тест, в котором проверяется поведение системы в случае добавления новой монеты со стороны биржи.
		/// </summary>
		[Test]
        public void RestPublicExtraCointTest_Sucess()
        {
            var message = "{\"retCode\":0,\"retMsg\":\"OK\",\"result\":{\"balances\":[{\"coin\":\"USDC\",\"coinId\":\"USDC\",\"coinName\":\"USDC\",\"total\":\"0.000684\",\"free\":\"0.000684\",\"locked\":\"0\"},{\"coin\":\"USDT\",\"coinId\":\"USDT\",\"coinName\":\"USDT\",\"total\":\"0.0000453\",\"free\":\"0.0000453\",\"locked\":\"0\"},{\"coin\":\"FAKE\",\"coinId\":\"FAKE\",\"coinName\":\"FAKE\",\"total\":\"1.1\",\"free\":\"2.2\",\"locked\":\"3.3\"},]},\"ext_code\":\"\",\"ext_info\":null,\"time_now\":\"1667295471.745933\"}";

            var response = RESTHandlers.HandleSpotWalletBalanceResponse(message);
            var coin = response.BalancesResult.BalancesData.Where(x => x.CoinId == "FAKE");

            Assert.IsNotNull(response);
            Assert.IsNotNull(coin);

            Assert.IsTrue(coin.Count() != 0);
            Assert.IsTrue(coin.First().Total == 1.1m);
            Assert.IsTrue(coin.First().Free == 2.2m);
            Assert.IsTrue(coin.First().Locked == 3.3m);

            Assert.IsNotNull(response.BalancesResult);

            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);
        }

        /// <summary>
        /// Тест для получения последней рыночной информации о инструментах
        /// </summary>
        [Test]
        public void RestPublicLatestSymbolInfo_Success()
        {
            var request = new LatestInformationSymbolRequest();
            var message = SendTest(request);
            var response = RESTHandlers.HandleLatestInformationSymbolResponse(message);
            var list = response.Result.List.ToList();

            Assert.IsNotNull(list);

            var first = list.FirstOrDefault();

            Assert.IsNotNull(first);
            Assert.IsNotNull(first.Timestamp);
            Assert.IsNotNull(first.Name);
            Assert.IsNotNull(first.LastTradedPrice);
            Assert.IsNotNull(first.BestAskPrice);
            Assert.IsNotNull(first.BestBidPrice);
            Assert.IsNotNull(first.Open);
            Assert.IsNotNull(first.High);
            Assert.IsNotNull(first.Low);
            Assert.IsNotNull(first.Volume);
            Assert.IsNotNull(first.QuoteVolume);
            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);
        }

        /// <summary>
        /// Тест, в котором проверяется корректность обработки списка заявок.
        /// В споте возвращается объект ордера.
        /// </summary>
		[Test]
        public void RestPrivateGetOpenOrders_Success()
        {
            //OpenTestOrders();

            var request = new OrderListRequest();
            request.Symbol = testedSymbol;
            request.OrderCategory = 1;

            var message = SendTest(request);
            var response = RESTHandlers.HandleOrderListResponse(message);

            foreach (var VARIABLE in response.Result.List)
            {
                var req = new CancelSpotOrderRequest(VARIABLE.OrderId){OrderCategory = OrderCategoryType.Tpsl};
                var res = SendTest(req);
                var resp = RESTHandlers.HandleCancelSpotOrderResponse(res);
                Console.WriteLine(resp.RetMessage);
                Thread.Sleep(1000);
            }
            
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Result);
            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);
		}

        /// <summary>
        /// Тест, в котором проверяется корректность получения торговой истории.
        /// Возвращается список торговых операций.
        /// </summary>
		[Test]
        public void RestPrivateGetTradeHistory_Success()
        {
            OpenTestOrders();

            var request = new TradeHistoryRequest();
            var message = SendTest(request);
            var response = RESTHandlers.HandleTradeHistoryResponse(message);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Result);
            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);
        }

        /// <summary>
        /// Тест, в котором проверяется корректность обработки списка баланса разных монет.
        /// В споте возвращается объект balances, который внутри содержит список баланса монет.
        /// </summary>
		[Test]
        public void RestPrivateGetWalletBalances_Success()
        {
            var request = new SpotWalletBalanceRequest();
            var message = SendTest(request);
            var response = RESTHandlers.HandleSpotWalletBalanceResponse(message);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.BalancesResult);
            Assert.IsNotNull(response.BalancesResult.BalancesData);
            Assert.IsTrue(response.BalancesResult.BalancesData.Count > 0);
            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);
		}

        /// <summary>
        /// Тест, в котором проверяется корректность выставления ордера на продажу.
        /// </summary>
		[Test]
        public void RestPrivatePlaceOrder_Success()
        {
            var symbolsList = GetSymbolsDataFromRequest().Result.List.ToList();
            var symbolsListFirst = symbolsList.FirstOrDefault(x => x.Name == testedSymbol);

            Assert.IsNotNull(symbolsListFirst);

            var latestSymbolsList = GetLatestInformationSymbolFromRequest().Result.List.ToList();
            var latestSymbolsFirst = latestSymbolsList.FirstOrDefault(x => x.Name == symbolsListFirst.Name);

            Assert.IsNotNull(latestSymbolsFirst);

            double bestAskPrice = double.Parse(latestSymbolsFirst.BestAskPrice, CultureInfo.InvariantCulture);

            var createSpotOrderResponse = PlaceOrderFromRequest(symbolsListFirst.Name, testedSymbolQty, CreateSpotOrderSideType.Buy, CreateSpotOrderType.Market, (decimal)bestAskPrice);

            Assert.IsNotNull(createSpotOrderResponse);
            Assert.IsNotNull(createSpotOrderResponse.Result.OrderId);
            Assert.IsNotNull(createSpotOrderResponse.Result.OrderPrice);
            Assert.IsNotNull(createSpotOrderResponse.Result.OrderQty);

        }

        /// <summary>
        /// Тест, в котором проверяется корректность выставления лимитного ордера на покупку.
        /// </summary>
        [Test]
        public void RestPrivatePlaceLimitOrder_Success()
        {
            var symbolsList = GetSymbolsDataFromRequest().Result.List.ToList();
            var symbolsListFirst = symbolsList.FirstOrDefault(x => x.Name == testedSymbol);

            Assert.IsNotNull(symbolsListFirst);

            var latestSymbolsList = GetLatestInformationSymbolFromRequest().Result.List.ToList();
            var latestSymbolsFirst = latestSymbolsList.FirstOrDefault(x => x.Name == symbolsListFirst.Name);

            Assert.IsNotNull(latestSymbolsFirst);

            double bestAskPrice = double.Parse(latestSymbolsFirst.BestAskPrice, CultureInfo.InvariantCulture);

            var createSpotOrderResponse = PlaceOrderFromRequest(symbolsListFirst.Name, symbolsListFirst.MinTradeQty, CreateSpotOrderSideType.Buy, 
                CreateSpotOrderType.Limit, (decimal)bestAskPrice);

            Assert.IsNotNull(createSpotOrderResponse);
            Assert.IsNotNull(createSpotOrderResponse.Result.OrderId);
            Assert.IsNotNull(createSpotOrderResponse.Result.OrderId);
            Assert.AreEqual(createSpotOrderResponse.Result.TypeEnum, SpotOrderResultTypeType.Limit);
            Assert.IsNotNull(createSpotOrderResponse.Result.OrderQty);
        }


		/// <summary>
		/// Тест, в котором проверяется корректность выставления ордера со стопом.
		/// </summary>
		[Test]
        public void RestPrivatePlaceSlOrder_Success()
        {
            var symbolsList = GetSymbolsDataFromRequest().Result.List.ToList();
            var symbolsListFirst = symbolsList.FirstOrDefault(x => x.Name == testedSymbol);

            Assert.IsNotNull(symbolsListFirst);

            var latestSymbolsList = GetLatestInformationSymbolFromRequest().Result.List.ToList();
            var latestSymbolsFirst = latestSymbolsList.FirstOrDefault(x => x.Name == symbolsListFirst.Name);

            Assert.IsNotNull(latestSymbolsFirst);

            var bestAskPrice = double.Parse(latestSymbolsFirst.BestBidPrice, CultureInfo.InvariantCulture);
            var stopLoss = bestAskPrice - (bestAskPrice * 0.1);

            var request = new CreateSpotOrderRequest(symbolsListFirst.Name, symbolsListFirst.MinTradeQty,
                CreateSpotOrderSideType.Buy, CreateSpotOrderType.Market, Convert.ToDecimal(stopLoss));

            var message = SendTest(request);

            var response = RESTHandlers.HandleCreateSpotOrderResponse(message);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.Result.OrderId);
            Assert.IsNotNull(response.Result.OrderPrice);
            Assert.IsNotNull(response.Result.TriggerPrice);
            Assert.IsNotNull(response.Result.OrderQty);

            Assert.AreEqual(response.Result.OrderCategory, 1);
            Assert.AreEqual(response.Result.TypeEnum, SpotOrderResultTypeType.Market);
            Assert.AreEqual(response.RetMessage, "OK");
            Assert.AreEqual(response.RetCode, 0);
        }

		[Test]
        public void RestPrivateCancelOrder_Success()
        {
            var symbolsList = GetSymbolsDataFromRequest().Result.List.ToList();
            var symbolsListFirst = symbolsList.FirstOrDefault(x => x.Name == testedSymbol);

            Assert.IsNotNull(symbolsListFirst);

            var latestSymbolsList = GetLatestInformationSymbolFromRequest().Result.List.ToList();
            var latestSymbolsFirst = latestSymbolsList.FirstOrDefault(x => x.Name == symbolsListFirst.Name);

            Assert.IsNotNull(latestSymbolsFirst);

            double bestAskPrice = double.Parse(latestSymbolsFirst.BestAskPrice, CultureInfo.InvariantCulture);

            var createSpotOrderResponse = PlaceOrderFromRequest(symbolsListFirst.Name, symbolsListFirst.MinTradeQty, CreateSpotOrderSideType.Buy,
                CreateSpotOrderType.Limit, (decimal)bestAskPrice);

            Assert.IsNotNull(createSpotOrderResponse);
            Assert.IsNotNull(createSpotOrderResponse.Result.OrderId);
            Assert.IsNotNull(createSpotOrderResponse.Result.OrderId);
            Assert.AreEqual(createSpotOrderResponse.Result.TypeEnum, SpotOrderResultTypeType.Limit);
            Assert.IsNotNull(createSpotOrderResponse.Result.OrderQty);

            var cancelSpotOrderRequest = new CancelSpotOrderRequest(createSpotOrderResponse.Result.OrderId);
            var cancelSpotOrderMessage = SendTest(cancelSpotOrderRequest);
            var cancelSpotOrderResponse = RESTHandlers.HandleCancelSpotOrderResponse(cancelSpotOrderMessage);

            Assert.IsNotNull(cancelSpotOrderResponse);
            Assert.IsNotNull(cancelSpotOrderResponse.Result.OrderId);
            Assert.IsNotNull(cancelSpotOrderResponse.Result.OrderPrice);
            Assert.IsNotNull(cancelSpotOrderResponse.Result.OrderQty);

            Assert.AreEqual(cancelSpotOrderResponse.Result.TypeEnum, SpotOrderResultTypeType.Limit);
            Assert.AreEqual(cancelSpotOrderResponse.RetMessage, "OK");
            Assert.AreEqual(cancelSpotOrderResponse.RetCode, 0);
        }

        /// <summary>
        /// Метод, выставлющий заявки
        /// </summary>
        /// <param name="count">Количество заявок</param>
        private void OpenTestOrders(int count = 3, CreateSpotOrderType orderType = CreateSpotOrderType.Market)
        {
            var symbolsList = GetSymbolsDataFromRequest().Result.List;
            Assert.IsNotNull(symbolsList);
            var symbolsListFirst = symbolsList.FirstOrDefault(x => x.Name == testedSymbol);

            Assert.IsNotNull(symbolsListFirst);

            var latestInformationSymbolRequest = new LatestInformationSymbolRequest();
            var latestSymbolMessage = SendTest(latestInformationSymbolRequest);
            var latestSymbolResponse = RESTHandlers.HandleLatestInformationSymbolResponse(latestSymbolMessage);
            var latestSymbolsList = latestSymbolResponse.Result.List.ToList();
            var latestSymbolsFirst = latestSymbolsList.FirstOrDefault(x => x.Name == symbolsListFirst.Name);

            Assert.IsNotNull(latestSymbolsFirst);

            var bestAskPrice = double.Parse(latestSymbolsFirst.BestAskPrice, CultureInfo.InvariantCulture);

            for (var index = 0; index < count; index++)
            {
                var createSpotOrderResponse = PlaceOrderFromRequest(symbolsListFirst.Name, testedSymbolQty, CreateSpotOrderSideType.Buy, orderType, (decimal)bestAskPrice);

                Assert.IsNotNull(createSpotOrderResponse);
                Assert.IsNotNull(createSpotOrderResponse.Result.OrderId);
                Assert.IsNotNull(createSpotOrderResponse.Result.OrderPrice);
                Assert.IsNotNull(createSpotOrderResponse.Result.OrderQty);
            }

            Task.Delay(5000);
        }

        /// <summary>
        /// Метод, размещающий заявки
        /// </summary>
        /// <param name="Name">Инструмент</param>
        /// <param name="qty">Объем</param>
        /// <param name="side">В какую сторону открывать сделки</param>
        /// <param name="type">Тип заявки(лимитная/рыночная)</param>
        /// <param name="orderPrice">Цена</param>
        /// <returns></returns>
        private CreateSpotOrderResponse PlaceOrderFromRequest(string Name, decimal qty, CreateSpotOrderSideType side,  CreateSpotOrderType type, decimal orderPrice)
        {
            var createSpotOrderRequest = new CreateSpotOrderRequest(Name, qty, side, type)
            {
                OrderPrice = orderPrice
            };

            var createSpotOrderMessage = SendTest(createSpotOrderRequest);
            var createSpotOrderResponse = RESTHandlers.HandleCreateSpotOrderResponse(createSpotOrderMessage);

            Assert.NotNull(createSpotOrderResponse);
            Assert.NotNull(createSpotOrderResponse.Result);

            Assert.AreEqual(createSpotOrderResponse.RetMessage, "OK");
            Assert.AreEqual(createSpotOrderResponse.RetCode, 0);

            return createSpotOrderResponse;
        }

        /// <summary>
        /// Метод для получения информацию о инструментах
        /// </summary>
        /// <returns></returns>
        private GetSymbolsResponse GetSymbolsDataFromRequest()
        {
            var symbolsRequest = new GetSymbolsRequest();
            var symbolsMessage = SendTest(symbolsRequest);
            var symbolsResponse = RESTHandlers.HandleGetSymbolsResponse(symbolsMessage);

            Assert.NotNull(symbolsResponse);
            Assert.NotNull(symbolsResponse.Result);
            Assert.NotNull(symbolsResponse.Result.List);

            Assert.IsTrue(symbolsResponse.Result.List.Count > 0);

            Assert.AreEqual(symbolsResponse.RetCode, 0);
            Assert.AreEqual(symbolsResponse.RetMessage, "OK");

            return symbolsResponse;
        }

        /// <summary>
        /// Получение последней рыночной информации об инструменте
        /// </summary>
        /// <returns></returns>
        private LatestInformationSymbolResponse GetLatestInformationSymbolFromRequest()
        {
            var latestInformationSymbolRequest = new LatestInformationSymbolRequest();
            var latestSymbolMessage = SendTest(latestInformationSymbolRequest);
            var latestSymbolResponse = RESTHandlers.HandleLatestInformationSymbolResponse(latestSymbolMessage);

            Assert.NotNull(latestSymbolResponse);
            Assert.NotNull(latestSymbolResponse.Result);
            Assert.NotNull(latestSymbolResponse.Result.List);

            Assert.IsTrue(latestSymbolResponse.Result.List.Count > 0);

            Assert.AreEqual(latestSymbolResponse.RetCode, 0);
            Assert.AreEqual(latestSymbolResponse.RetMessage, "OK");

            return latestSymbolResponse;
        }
        
        /// <summary>
        /// Тест, получающий ошибку MAE
        /// </summary>
        /// <param name="Name">Инструмент</param>
        /// <param name="qty">Объем</param>
        /// <param name="side">В какую сторону открывать сделки</param>
        /// <param name="type">Тип заявки(лимитная/рыночная)</param>
        /// <param name="orderPrice">Цена</param>
        /// <returns></returns>
        [Test]
        public void HandleErrorResponseTest()
        {
            var bestAskPrice = double.Parse("100000", CultureInfo.InvariantCulture);
            var stopLoss = bestAskPrice - (bestAskPrice * 0.1);
            var request = new CreateSpotOrderRequest("", 100000,
                CreateSpotOrderSideType.Buy, CreateSpotOrderType.Market, Convert.ToDecimal(stopLoss));
            var message = SendTest(request);
            var response = RESTHandlers.HandleErrorResponse(message);
        }
        
        /// <summary>
        /// Тест, размещающий заявки MAE1
        /// </summary>
        /// <param name="Name">Инструмент</param>
        /// <param name="qty">Объем</param>
        /// <param name="side">В какую сторону открывать сделки</param>
        /// <param name="type">Тип заявки(лимитная/рыночная)</param>
        /// <param name="orderPrice">Цена</param>
        /// <returns></returns>
        [Test]
        public void HandleCreateSpotOrderResponseTest()
        {
            
            var createSpotOrderRequest = new CreateSpotOrderRequest("ADAUSDT", 10m, CreateSpotOrderSideType.Sell, CreateSpotOrderType.Market)
            {
                OrderPrice = 100000m
            };
            var createSpotOrderMessage = SendTest(createSpotOrderRequest);
            var createSpotOrderResponse = RESTHandlers.HandleCreateSpotOrderResponse(createSpotOrderMessage);
            
            /*
            var createSpotOrderRequest = new CancelSpotOrderRequest("1353000976753181952")
            {
            };
            var createSpotOrderMessage = SendTest(createSpotOrderRequest);
            var createSpotOrderResponse = RESTHandlers.HandleCancelSpotOrderResponse(createSpotOrderMessage);   
            */
            /*
            var createSpotOrderRequest = new TradeHistoryRequest()
            {
            };
            var createSpotOrderMessage = SendTest(createSpotOrderRequest);
            var createSpotOrderResponse = RESTHandlers.HandleTradeHistoryResponse(createSpotOrderMessage);  */     
        }
        
        //MAE
        [Test]
        public void HandleTradeHistoryResponseTest()
        {
            //OpenTestOrders();

            var request = new TradeHistoryRequest();
            var message = SendTest(request);
            var responsde = RESTHandlers.HandleTradeHistoryResponse(message);
        }
        #endregion


        #region [WebSocket]

        /// <summary>
        /// Тест для получения пинга
        /// </summary>
        [Test]
        public void WssPublicPingInfo_Success()
        {
            socket = new WebSocket(pathPublicTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                socket.Send("{\"op\":\"ping\"}");
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                Assert.NotNull(e.Data);
                Assert.True(e.Data.Contains("pong"));

                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();
            Task.Delay(2000).Wait();
        }

        /// <summary>
        /// Тест для получения данных о инструменте 
        /// Глубина: по 40 асков и бидов.
        /// </summary>
        [Test]
        public void WssPublicGetDepth_Success()
        {
            socket = new WebSocket(pathPublicTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var request1 = BybitMapper.Spot.MarketStreamsV3.Subscriptions.CombineStreamsSubs.Create(testedSymbol, PublicEndpointType.Depth, BybitMapper.Spot.MarketStreamsV3.Data.SubType.Subscribe);

                socket.Send(request1);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                var response = MarketV3StreamsHandler.HandleDefaultEvent(e.Data);
                if (response.WSEventType == EventType.Depth)
                {
                    var depthDataEvent = MarketV3StreamsHandler.HandleDepthEvent(e.Data);
                    Assert.IsNotNull(depthDataEvent);
                    Assert.IsNotNull(depthDataEvent.Timestamp);
                    Assert.IsNotNull(depthDataEvent.Data);

                    Assert.IsTrue(depthDataEvent.Data.Ask.Count > 0);
                    Assert.IsTrue(depthDataEvent.Data.Bid.Count > 0);

                    Assert.NotNull(depthDataEvent.Data.Timestamp);
                    Assert.NotNull(depthDataEvent.Data.TradingPair);

                    var _firstAsk = depthDataEvent.Data.Ask.FirstOrDefault();
                    var _firstBid = depthDataEvent.Data.Bid.FirstOrDefault();

                    Assert.NotNull(_firstAsk);
                    Assert.NotNull(_firstBid);

                    Assert.NotNull(_firstAsk.Price);
                    Assert.NotNull(_firstAsk.Quantity);

                    Assert.NotNull(_firstBid.Price);
                    Assert.NotNull(_firstBid.Quantity);
                }

                Debug.Print("Message: \"" + e.Data + "\"");

                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();
            Task.Delay(5000).Wait();
        }

        /// <summary>
        /// Тест, показывающий сделки в стакане
        /// </summary>
        [Test]
        public void WssPublicGetTrade_Success()
        {
            socket = new WebSocket(pathPublicTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var request1 = BybitMapper.Spot.MarketStreamsV3.Subscriptions.CombineStreamsSubs.Create(testedSymbol, PublicEndpointType.Trade, BybitMapper.Spot.MarketStreamsV3.Data.SubType.Subscribe);

                socket.Send(request1);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                var response = MarketV3StreamsHandler.HandleDefaultEvent(e.Data);
                if (response.WSEventType == EventType.Trade)
                {
                    var depthDataEvent = MarketV3StreamsHandler.HandleTradeEvent(e.Data);
                    Assert.IsNotNull(depthDataEvent);
                    Assert.IsNotNull(depthDataEvent.Timestamp);
                    Assert.IsNotNull(depthDataEvent.Data);
                    Assert.IsNotNull(depthDataEvent.Data.Quantity);
                    Assert.IsNotNull(depthDataEvent.Data.Price);
                    Assert.IsNotNull(depthDataEvent.Data.Time);
                    Assert.IsNotNull(depthDataEvent.Data.TradeId);
                }
                Debug.Print("Message: \"" + e.Data + "\"");

                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();
            Task.Delay(5000).Wait();
        }

        /// <summary>
        /// Тест, показывающий 24-часовую статистику торговой пары.
        /// </summary>
        [Test]
        public void WssPublicGetTickers_Success()
        {
            socket = new WebSocket(pathPublicTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var request1 = BybitMapper.Spot.MarketStreamsV3.Subscriptions.CombineStreamsSubs.Create(testedSymbol, PublicEndpointType.Tickers, BybitMapper.Spot.MarketStreamsV3.Data.SubType.Subscribe);

                socket.Send(request1);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                var response = MarketV3StreamsHandler.HandleDefaultEvent(e.Data);
                if (response.WSEventType == EventType.Tickers)
                {
                    var depthDataEvent = MarketV3StreamsHandler.HandleTickerInfoEvent(e.Data);
                    Assert.IsNotNull(depthDataEvent);
                    Assert.IsNotNull(depthDataEvent.Timestamp);
                    Assert.IsNotNull(depthDataEvent.Data);
                    Assert.IsNotNull(depthDataEvent.Data.Change);
                    Assert.IsNotNull(depthDataEvent.Data.ClosePrice);
                    Assert.IsNotNull(depthDataEvent.Data.HighPrice);
                    Assert.IsNotNull(depthDataEvent.Data.LowPrice);
                    Assert.IsNotNull(depthDataEvent.Data.OpenPrice);
                    Assert.IsNotNull(depthDataEvent.Data.QuoteVolume);
                    Assert.IsNotNull(depthDataEvent.Data.Symbol);
                    Assert.IsNotNull(depthDataEvent.Data.Timestamp);
                    Assert.IsNotNull(depthDataEvent.Data.Volume);
                }
                Debug.Print("Message: \"" + e.Data + "\"");

                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();
            Task.Delay(5000).Wait();
        }


        /// <summary>
        /// Отписка от получения данных о инструменте.
        /// </summary>
        [Test]
        public void WssPublicGetUnsubscribeDepth_Success()
        {
            socket = new WebSocket(pathPublicTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var request1 = BybitMapper.Spot.MarketStreamsV3.Subscriptions.CombineStreamsSubs.Create(testedSymbol, PublicEndpointType.Depth, BybitMapper.Spot.MarketStreamsV3.Data.SubType.Unsubscribe);

                socket.Send(request1);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();
            Task.Delay(5000).Wait();
        }


        /// <summary>
        /// Отписка от сделок в стакане.
        /// </summary>
        [Test]
        public void WssPublicGetUnsubscribeTrade_Success()
        {
            socket = new WebSocket(pathPublicTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var request1 = BybitMapper.Spot.MarketStreamsV3.Subscriptions.CombineStreamsSubs.Create(testedSymbol, PublicEndpointType.Trade, BybitMapper.Spot.MarketStreamsV3.Data.SubType.Unsubscribe);

                socket.Send(request1);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();
            Task.Delay(5000).Wait();
        }


        /// <summary>
        /// Отписка от статистики торговой пары.
        /// </summary>
        [Test]
        public void WssPublicGetUnsubscribeTickers_Success()
        {
            socket = new WebSocket(pathPublicTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var request1 = BybitMapper.Spot.MarketStreamsV3.Subscriptions.CombineStreamsSubs.Create(testedSymbol, PublicEndpointType.Tickers, BybitMapper.Spot.MarketStreamsV3.Data.SubType.Unsubscribe);

                socket.Send(request1);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();
            Task.Delay(5000).Wait();
        }

        /// <summary>
        /// Тест сокетов, в котором происходит авторизация в приватной части
        /// </summary>
        [Test]
        public void WssPrivateAuth_Success()
        {
            socket = new WebSocket(pathPrivateTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var expires = GetTimestamp();
                var request1 = CombineStreamsSubs.Login(ApiTestnetKey, SecretTestnetKey, expires);

                socket.Send(request1);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                Debug.Print("Message: \"" + e.Data + "\"");

                Assert.IsNotNull(e.Data);

                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();
            Task.Delay(5000).Wait();
        }

        /// <summary>
        /// Тест сокетов, в котором размещается ордер и информация обновляется по сокету
        /// Сперва создается сокет, потом происходит авторизация, после чего подписываемся на событие
        /// Далее создается создается ордер 
        /// </summary>
        [Test]
        public void WssPrivateGetOrder_Success()
        {
            socket = new WebSocket(pathPrivateTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var expires = GetTimestamp();
                var authRequest = CombineStreamsSubs.Login(ApiTestnetKey, SecretTestnetKey, expires);
                socket.Send(authRequest);
                var orderRequest = CombineStreamsSubs.Create(SubType.Subscribe, PrivateEndpointType.Order);
                socket.Send(orderRequest);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                var response = UserV3StreamsHandler.HandleDefaultEvent(e.Data);
                if (response.WSEventType == BybitMapper.Spot.UserStreamsV3.Enums.EventType.Order)
                {
                    var orderDataEvent = UserV3StreamsHandler.HandleOrderEvent(e.Data);
                    Assert.IsNotNull(orderDataEvent);
                    Assert.IsNotNull(orderDataEvent.Timestamp);
                    Assert.IsNotNull(orderDataEvent.Topic);
                    Assert.IsNotNull(orderDataEvent.Type);

                    Assert.IsTrue(orderDataEvent.Data.Count > 0);

                    var firstData = orderDataEvent.Data.FirstOrDefault();

                    Assert.IsNotNull(firstData.Order);
                    Assert.IsNotNull(firstData.AccountId);
                    Assert.IsNotNull(firstData.OrderId);
                }
                
                Debug.Print("Message: \"" + e.Data + "\"");

                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();

            Task.Delay(6000).Wait();

            var symbolsRequest = new GetSymbolsRequest();
            var symbolsMessage = SendTest(symbolsRequest);
            var symbolsResponse = RESTHandlers.HandleGetSymbolsResponse(symbolsMessage);
            var symbolsList = symbolsResponse.Result.List.ToList();
            var symbolsListFirst = symbolsList.FirstOrDefault(x => x.Name == testedSymbol);

            Assert.IsNotNull(symbolsListFirst);

            var latestInformationSymbolRequest = new LatestInformationSymbolRequest();
            var latestSymbolMessage = SendTest(latestInformationSymbolRequest);
            var latestSymbolResponse = RESTHandlers.HandleLatestInformationSymbolResponse(latestSymbolMessage);
            var latestSymbolsList = latestSymbolResponse.Result.List.ToList();
            var latestSymbolsFirst = latestSymbolsList.FirstOrDefault(x => x.Name == symbolsListFirst.Name);

            Assert.IsNotNull(latestSymbolsFirst);

            double bestAskPrice = double.Parse(latestSymbolsFirst.BestAskPrice, CultureInfo.InvariantCulture);

            var createSpotOrderResponse = PlaceOrderFromRequest(symbolsListFirst.Name, testedSymbolQty, CreateSpotOrderSideType.Buy, CreateSpotOrderType.Market, (decimal)bestAskPrice);


            Assert.IsNotNull(createSpotOrderResponse);
            Assert.IsNotNull(createSpotOrderResponse.Result);
            Assert.AreEqual(createSpotOrderResponse.RetCode, 0);

            Task.Delay(10000).Wait();
        }

        /// <summary>
        /// Тест сокетов, в котором размещается отложенная заявка, а затем она отменяется(вся информация обновляется по сокету)
        /// Сперва создается сокет, потом происходит авторизация, после чего подписываемся на событие изменения состояния заявки
        /// Далее создается создается лимитная заявка, после чего она отменяется 
        /// </summary>
        [Test]
        public void WssPrivateGetCancelOrder_Success()
        {
            socket = new WebSocket(pathPrivateTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var expires = GetTimestamp();
                var authRequest = CombineStreamsSubs.Login(ApiTestnetKey, SecretTestnetKey, expires);
                socket.Send(authRequest);
                var orderRequest = CombineStreamsSubs.Create(SubType.Subscribe, PrivateEndpointType.Order);
                socket.Send(orderRequest);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                var response = UserV3StreamsHandler.HandleDefaultEvent(e.Data);
                if (response.WSEventType == BybitMapper.Spot.UserStreamsV3.Enums.EventType.Order)
                {
                    var orderDataEvent = UserV3StreamsHandler.HandleOrderEvent(e.Data);
                    Assert.IsNotNull(orderDataEvent);
                    Assert.IsNotNull(orderDataEvent.Timestamp);
                    Assert.IsNotNull(orderDataEvent.Topic);
                    Assert.IsNotNull(orderDataEvent.Type);

                    Assert.IsTrue(orderDataEvent.Data.Count > 0);

                    var firstData = orderDataEvent.Data.FirstOrDefault();

                    Assert.IsNotNull(firstData.Order);
                    Assert.IsNotNull(firstData.AccountId);
                    Assert.IsNotNull(firstData.OrderId);
                }
                Debug.Print("Message: \"" + e.Data + "\"");

                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();

            Task.Delay(2000).Wait();

            var symbolsRequest = new GetSymbolsRequest();
            var symbolsMessage = SendTest(symbolsRequest);
            var symbolsResponse = RESTHandlers.HandleGetSymbolsResponse(symbolsMessage);
            var symbolsList = symbolsResponse.Result.List.ToList();
            var symbolsListFirst = symbolsList.FirstOrDefault(x => x.Name == testedSymbol);

            Assert.IsNotNull(symbolsListFirst);

            var latestInformationSymbolRequest = new LatestInformationSymbolRequest();
            var latestSymbolMessage = SendTest(latestInformationSymbolRequest);
            var latestSymbolResponse = RESTHandlers.HandleLatestInformationSymbolResponse(latestSymbolMessage);
            var latestSymbolsList = latestSymbolResponse.Result.List.ToList();
            var latestSymbolsFirst = latestSymbolsList.FirstOrDefault(x => x.Name == symbolsListFirst.Name);

            Assert.IsNotNull(latestSymbolsFirst);

            double bestAskPrice = double.Parse(latestSymbolsFirst.BestAskPrice, CultureInfo.InvariantCulture);
            double buyPrice = bestAskPrice - (bestAskPrice * 0.2);

            var createSpotOrderResponse = PlaceOrderFromRequest(symbolsListFirst.Name, testedSymbolQty, CreateSpotOrderSideType.Buy, CreateSpotOrderType.Limit, (decimal)buyPrice);

            Assert.IsNotNull(createSpotOrderResponse);
            Assert.IsNotNull(createSpotOrderResponse.Result);
            Assert.AreEqual(createSpotOrderResponse.RetCode, 0);

            Task.Delay(2000).Wait();

            var cancelSpotOrderRequest = new CancelSpotOrderRequest(createSpotOrderResponse.Result.OrderId);
            var cancelSpotOrderMessage = SendTest(cancelSpotOrderRequest);
            var cancelSpotOrderResponse = RESTHandlers.HandleCancelSpotOrderResponse(cancelSpotOrderMessage);

            Assert.IsNotNull(cancelSpotOrderResponse);
            Assert.IsNotNull(cancelSpotOrderResponse.Result.OrderId);
            Assert.IsNotNull(cancelSpotOrderResponse.Result.OrderPrice);
            Assert.IsNotNull(cancelSpotOrderResponse.Result.OrderQty);

            Assert.AreEqual(cancelSpotOrderResponse.Result.TypeEnum, SpotOrderResultTypeType.Limit);
            Assert.AreEqual(cancelSpotOrderResponse.RetMessage, "OK");
            Assert.AreEqual(cancelSpotOrderResponse.RetCode, 0);

            Task.Delay(5000).Wait();
        }

        /// <summary>
        /// В этой тесте возвращается информация о совершенных сделках со стопом
        /// </summary>
        [Test]
        public void WssPrivateGetStopOrder_Success()
        {
            socket = new WebSocket(pathPrivateTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var expires = GetTimestamp();
                var authRequest = CombineStreamsSubs.Login(ApiTestnetKey, SecretTestnetKey, expires);
                socket.Send(authRequest);
                var orderRequest = CombineStreamsSubs.Create(SubType.Subscribe, PrivateEndpointType.StopOrder);
                socket.Send(orderRequest);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                var response = UserV3StreamsHandler.HandleDefaultEvent(e.Data);
                if (response.WSEventType == BybitMapper.Spot.UserStreamsV3.Enums.EventType.StopOrder)
                {
                    var orderDataEvent = UserV3StreamsHandler.HandleStopOrderEvent(e.Data);
                    Assert.IsNotNull(orderDataEvent);
                    Assert.IsNotNull(orderDataEvent.Timestamp);
                    Assert.IsNotNull(orderDataEvent.Topic);
                    Assert.IsNotNull(orderDataEvent.Type);

                    Assert.IsTrue(orderDataEvent.Data.Count > 0);

                    var firstData = orderDataEvent.Data.FirstOrDefault();

                    Assert.IsNotNull(firstData.Order);
                    Assert.IsNotNull(firstData.MarketPriceOnPlace);
                    Assert.IsNotNull(firstData.OrderCreateTime);
                    Assert.IsNotNull(firstData.OrderTriggerTime);
                    Assert.IsNotNull(firstData.OrderId);
                    Assert.IsNotNull(firstData.NewOrderId);
                }

                Debug.Print("Message: \"" + e.Data + "\"");

                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();

            Task.Delay(6000).Wait();
            var symbolsList = GetSymbolsDataFromRequest().Result.List.ToList();
            var symbolsListFirst = symbolsList.FirstOrDefault(x => x.Name == testedSymbol);

            Assert.IsNotNull(symbolsListFirst);

            var latestSymbolsList = GetLatestInformationSymbolFromRequest().Result.List.ToList();
            var latestSymbolsFirst = latestSymbolsList.FirstOrDefault(x => x.Name == symbolsListFirst.Name);

            Assert.IsNotNull(latestSymbolsFirst);

            var bestAskPrice = double.Parse(latestSymbolsFirst.BestBidPrice, CultureInfo.InvariantCulture);
            var stopLoss = bestAskPrice - (bestAskPrice * 0.1);

            var request = new CreateSpotOrderRequest(symbolsListFirst.Name, symbolsListFirst.MinTradeQty,
                CreateSpotOrderSideType.Buy, CreateSpotOrderType.Market, Convert.ToDecimal(stopLoss));

            var message = SendTest(request);

            var orderResponse = RESTHandlers.HandleCreateSpotOrderResponse(message);

            Assert.IsNotNull(orderResponse);
            Assert.IsNotNull(orderResponse.Result.OrderId);
            Assert.IsNotNull(orderResponse.Result.OrderPrice);
            Assert.IsNotNull(orderResponse.Result.TriggerPrice);
            Assert.IsNotNull(orderResponse.Result.OrderQty);

            Assert.AreEqual(orderResponse.Result.OrderCategory, 1);
            Assert.AreEqual(orderResponse.Result.TypeEnum, SpotOrderResultTypeType.Market);
            Assert.AreEqual(orderResponse.RetMessage, "OK");
            Assert.AreEqual(orderResponse.RetCode, 0);

            Task.Delay(20000).Wait();
        }

        /// <summary>
        /// Тест, выводящий данные о сделках
        /// </summary>
        [Test]
        public void WssPrivateGetTicketInfo_Success()
        {
            socket = new WebSocket(pathPrivateTestnetWss)
            {
                EmitOnPing = true
            };

            socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;

            socket.OnOpen += (object sender, EventArgs e) =>
            {
                var expires = GetTimestamp();
                var authRequest = CombineStreamsSubs.Login(ApiTestnetKey, SecretTestnetKey, expires);
                socket.Send(authRequest);
                var orderRequest = CombineStreamsSubs.Create(SubType.Subscribe, PrivateEndpointType.TicketInfo);
                socket.Send(orderRequest);
            };

            socket.OnMessage += (object sender, MessageEventArgs e) =>
            {
                var response = UserV3StreamsHandler.HandleDefaultEvent(e.Data);
                if (response.WSEventType == BybitMapper.Spot.UserStreamsV3.Enums.EventType.TicketInfo)
                {
                    var orderDataEvent = UserV3StreamsHandler.HandleTicketInfoEvent(e.Data);
                    Assert.IsNotNull(orderDataEvent);
                    Assert.IsNotNull(orderDataEvent.Timestamp);
                    Assert.IsNotNull(orderDataEvent.Topic);
                    Assert.IsNotNull(orderDataEvent.Type);

                    Assert.IsTrue(orderDataEvent.Data.Count > 0);

                    var firstData = orderDataEvent.Data.FirstOrDefault();

                    Assert.IsNotNull(firstData.Timestamp);
                    Assert.IsNotNull(firstData.AccountId);
                    Assert.IsNotNull(firstData.OrderId);
                    Assert.IsNotNull(firstData.EventTime);
                    Assert.IsNotNull(firstData.Price);
                    Assert.IsNotNull(firstData.Quantity);
                    Assert.IsNotNull(firstData.TransactionId);
                }

                Debug.Print("Message: \"" + e.Data + "\"");

                if (e.Data.Contains("error"))
                {
                    Assert.Fail();
                }
            };

            socket.OnError += (object sender, ErrorEventArgs e) =>
            {
                Debug.Print("Error");
                Assert.Fail();
            };

            socket.OnClose += (object sender, CloseEventArgs e) =>
            {
                Debug.Print("Close");
            };

            socket.Connect();

            Task.Delay(6000).Wait();

            var symbolsRequest = new GetSymbolsRequest();
            var symbolsMessage = SendTest(symbolsRequest);
            var symbolsResponse = RESTHandlers.HandleGetSymbolsResponse(symbolsMessage);
            var symbolsList = symbolsResponse.Result.List.ToList();
            var symbolsListFirst = symbolsList.FirstOrDefault(x => x.Name == testedSymbol);

            Assert.IsNotNull(symbolsListFirst);

            var latestInformationSymbolRequest = new LatestInformationSymbolRequest();
            var latestSymbolMessage = SendTest(latestInformationSymbolRequest);
            var latestSymbolResponse = RESTHandlers.HandleLatestInformationSymbolResponse(latestSymbolMessage);
            var latestSymbolsList = latestSymbolResponse.Result.List.ToList();
            var latestSymbolsFirst = latestSymbolsList.FirstOrDefault(x => x.Name == symbolsListFirst.Name);

            Assert.IsNotNull(latestSymbolsFirst);


            double bestAskPrice = double.Parse(latestSymbolsFirst.BestAskPrice, CultureInfo.InvariantCulture);

            var createSpotOrderResponse = PlaceOrderFromRequest(symbolsListFirst.Name, testedSymbolQty, CreateSpotOrderSideType.Buy, CreateSpotOrderType.Market, (decimal)bestAskPrice);

            Assert.IsNotNull(createSpotOrderResponse);
            Assert.IsNotNull(createSpotOrderResponse.Result);
            Assert.AreEqual(createSpotOrderResponse.RetCode, 0);

            Task.Delay(20000).Wait();
        }
        #endregion

        #region Helpers

        public string SendTest(RequestPayload payload)
		{   
			var request = requestArranger.Arrange(payload);
			var req = new RestRequest(request.Query, MapRequestMethod(request.Method));//MAE

			if (request.Body != null)
			{
				req.RequestFormat = DataFormat.Json;
				req.AddJsonBody(request.Body);
			}

			if (request.Headers != null)
			{
				foreach (var header in request.Headers)
				{
					req.AddHeader(header.Key, header.Value);
				}
			}
			var result = client.Execute(req)?.Content;
			return (result);
		}

        private static Method MapRequestMethod(RequestMethod method)
        {
            switch (method)
            {
                case RequestMethod.GET:
                    return Method.GET;
                case RequestMethod.POST:
                    return Method.POST;
                case RequestMethod.PUT:
                    return Method.PUT;
                case RequestMethod.DELETE:
                    return Method.DELETE;
                default:
                    throw new NotImplementedException();
            }
        }

        private long GetTimestamp()
        {
            return GetTime() + 5000;
        }

        #endregion
    }
}
