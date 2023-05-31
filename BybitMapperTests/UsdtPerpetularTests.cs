using System;
using System.Security.Authentication;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;

using NUnit.Framework;

using RestSharp;
using WebSocketSharp;

using BybitMapper.Requests;
using BybitMapper.Perpetual.RestV2;
using BybitMapper.Perpetual.MarketStreams;
using BybitMapper.Perpetual.RestV2.Requests.Market;
using BybitMapper.Perpetual.RestV2.Responses.Market;
using BybitMapper.Perpetual.RestV2.Requests.Account;
using BybitMapper.Perpetual.RestV2.Requests.Account.ConditionalOrders;
using BybitMapper.Perpetual.RestV2.Requests.Account.Wallet;
using BybitMapper.Perpetual.RestV2.Data.Enums;

using BybitMapper.Perpetual.UserStreams.Data.Enum;
using BybitMapper.Perpetual.MarketStreams.Data.Enums;
using BybitMapper.Perpetual.RestV2.Requests.Account.Position;
using BybitMapper.Perpetual.UserStreams.Data;
using BybitMapper.Perpetual.UserStreams.Subscriptions;
using BybitMapper.Perpetual.UserStreams;

namespace BybitMapperTests
{
	public class UsdtPerpetularTests
	{
		public PerpetualHandlerComposition RESTHandlers;

		public UserStreamsPerpetualHandlerComposition WSHandler = new UserStreamsPerpetualHandlerComposition(new UserStreamsPerpetualHandlerFactory());

		//private const string ApiKey = "2pam4sQkFE6yIz5Ily";
		//
		//private const string SecretKey = "Ds5eEKo5ZfmMPNSzGxTWBtiBUVXv0ivEx7dy";

		private const string ApiKey = "sKBvMgsXbONGJQ1Zuq";

		private const string SecretKey = "HFh9Ddp27gK8FHCE2nIPHarUDG4tBQNh6C16";

        private const string pathTestApi = "https://api-testnet.bybit.com";

		private const string pathApi = "https://api.bybit.com";

		private RequestArranger requestArranger;

		private RestClient client;

		private WebSocket socket;

		public UsdtPerpetularTests()
		{
			client = new RestClient(pathApi);
			
			requestArranger = new RequestArranger(ApiKey, SecretKey, GetTime);

			RESTHandlers = new PerpetualHandlerComposition(new PerpetualHandlerFactory());
		}

		private long GetTime()
        {
			var request = new ServerTimeRequest();

			var message = SendTest(request);

			var response = RESTHandlers.HandlerServerTimeResponse(message);

			return (long)Math.Round(response.Timestamp * 1000);
        }

		[Test]
		public void GetBalance_Success()
		{
			var request = new GetWalletBalanceRequest();

			var message = SendTest(request);

			var response = RESTHandlers.HandleWalletBalanceResponse(message);

			var list = response.CoinInfo.ToList();

			#region example

			//result\":
			//{
			//	\"BTC\":
			//	{
			//		\"equity\":0,
			//		\"available_balance\":0,
			//		\"used_margin\":0,
			//		\"order_margin\":0,
			//		\"position_margin\":0,
			//		\"occ_closing_fee\":0,
			//		\"occ_funding_fee\":0,
			//		\"wallet_balance\":0,
			//		\"realised_pnl\":0,
			//		\"unrealised_pnl\":0,
			//		\"cum_realised_pnl\":0,
			//		\"given_cash\":0,\
			//		"service_cash\":0},
			//	\"EOS\":
			//	{
			//		\"equity\":0,
			//		\"available_balance\":0,
			//		\"used_margin\":0,
			//		\"order_margin\":0,
			//		\"position_margin\":0,
			//		\"occ_closing_fee\":0,
			//		\"occ_funding_fee\":0,
			//		\"wallet_balance\":0,
			//		\"realised_pnl\":0,
			//		\"unrealised_pnl\":0,
			//		\"cum_realised_pnl\":0,
			//		\"given_cash\":0,
			//		\"service_cash\":0
			//	}
			//}

			#endregion

			Assert.IsNotNull(response);

			Assert.IsNotNull(response.CoinInfo);

			Assert.AreEqual(response.RetMessage, "OK");

			Assert.AreEqual(response.RetCode, 0);
		}

		[Test]
		public void CancelAllConditionalOrders_Success()
		{
			var request = new FullPartialPositionTPSLSwitchRequest("BTCUSDT", TpSlModeType.Partial);

			var message = SendTest(request);

			var response = RESTHandlers.HandleCancelAllConditionalOrdersResponse(message);

			Assert.IsNotNull(response);

			Assert.AreEqual(response.RetMessage, "OK");

			Assert.AreEqual(response.RetCode, 0);
		}
		
		[Test]
		public void GetConditionalOrder_Success()
		{
			var request = new GetConditionalOrderRequest("ETHUSDT");

			var message = SendTest(request);

			var response = RESTHandlers.HandleGetConditionalOrderResponse(message);

			Assert.IsNotNull(response);

			Assert.AreEqual(response.RetMessage, "OK");

			Assert.AreEqual(response.RetCode, 0);
		}

		[Test]
		public void CancelConditionalOrder_Success()
		{
			var request = new CancelConditionalOrderRequest("ETHUSDT")
			{
				OrderId = "30d291bc-0a47-4770-80ee-e3b13b27ef2d"
			};

			var message = SendTest(request);

			var response = RESTHandlers.HandleCancelConditionalOrderResponse(message);

			Assert.IsNotNull(response);

			Assert.AreEqual(response.RetMessage, "OK");

			Assert.AreEqual(response.RetCode, 0);
		}

		[Test]
		public void StopOrdersWebSocketTest()
		{
			socket = new WebSocket("wss://stream.bybit.com/realtime_private")
			{
				EmitOnPing = true
			};
			
			socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
			
			socket.OnOpen += (object sender, EventArgs e) =>
			{
                var expires = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 5000;
                var request1 = CombineStremsSubsPerpetualUser.Create(SubType.Auth, ApiKey, SecretKey, expires);

				socket.Send(request1);

				var request2 = CombineStremsSubsPerpetualUser.Create(SubType.Subscribe, UserEventType.StopOrder);
				
				socket.Send(request2);
			};

			socket.OnMessage += (object sender, MessageEventArgs e) =>
			{
				Debug.Print("Message");

				var response1 = WSHandler.HandleStopOrderPerpetualEvent(e.Data);

				
			};

			socket.OnError += (object sender, ErrorEventArgs e) =>
			{
				Debug.Print("Error");
			};

			socket.OnClose += (object sender, CloseEventArgs e) =>
			{
				Debug.Print("Close");
			};

			socket.Connect();

			Task.Delay(160000).Wait();
		}

		[Test]
		public void PlaceConditionOrder_Success()
		{
			socket = new WebSocket("wss://stream.bybit.com/realtime_private")
			{
				EmitOnPing = true
			};
			
			socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
			
			socket.OnOpen += (object sender, EventArgs e) =>
			{
                var expires = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 5000;
                var request1 = CombineStremsSubsPerpetualUser.Create(SubType.Auth, ApiKey, SecretKey, expires);

				socket.Send(request1);

				var request2 = CombineStremsSubsPerpetualUser.Create(SubType.Subscribe, UserEventType.Execution);

				socket.Send(request2);

				var request3 = CombineStremsSubsPerpetualUser.Create(SubType.Subscribe, UserEventType.Order);
				
				socket.Send(request3);

				var request4 = CombineStremsSubsPerpetualUser.Create(SubType.Subscribe, UserEventType.StopOrder);
				
				socket.Send(request4);
			};

			socket.OnMessage += (object sender, MessageEventArgs e) =>
			{
				Debug.Print("Message");

				var response1 = WSHandler.HandlePositionPerpetualEvent(e.Data);

				switch(response1.Topic)
				{
					case UserEventType.Order:
						CancelAllConditionalOrders_Success();
						Assert.Pass();
						return;
				}
			};

			socket.OnError += (object sender, ErrorEventArgs e) =>
			{
				Debug.Print("Error");
			};

			socket.OnClose += (object sender, CloseEventArgs e) =>
			{
				Debug.Print("Close");
			};

			socket.Connect();

			Task.Delay(6000).Wait();

			var request = new PlaceConditionalOrderRequest(OrderSideType.Sell, "BTCUSDT", 
				OrderType.Market, 0.001m, 20700, 20701, TimeInForceType.GoodTillCancel, 
				TriggerPriceType.LastPrice, false, true);
			
			var message2 = SendTest(request);
			
			var response2 = RESTHandlers.HandlePlaceConditionalOrderResponse(message2);
			
			Assert.IsNotNull(response2);
			
			Assert.IsNotNull(response2.Result);
			
			Assert.AreEqual(response2.RetMessage, "OK");
			
			Assert.AreEqual(response2.RetCode, 0);
			
			Task.Delay(20000).Wait();
		}

		/// <summary>
		/// Тест, в котором проверяется поведение системы в случае добавления новой монеты со стороны биржи.
		/// </summary>
		[Test]
		public void ExtraCointTest()
		{
			string message = "{\"ret_code\":0,\"ret_msg\":\"OK\",\"ext_code\":\"\",\"ext_info\":\"\",\"result\":{\"FAKE\":{\"equity\":1.1,\"available_balance\":2.1,\"used_margin\":3.1,\"order_margin\":4.1,\"position_margin\":5.1,\"occ_closing_fee\":6.1,\"occ_funding_fee\":7.1,\"wallet_balance\":8.1,\"realised_pnl\":9.1,\"unrealised_pnl\":10.1,\"cum_realised_pnl\":11.1,\"given_cash\":12.1,\"service_cash\":13.1},\"ODA\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"BIT\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"BTC\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"DOT\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"EOS\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"ETH\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"LTC\":{\"equity\":0.28061,\"available_balance\":0.28061,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0.28061,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"LUNA\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"MANA\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"SOL\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"USDT\":{\"equity\":0.00001521,\"available_balance\":0.00001521,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0.00001521,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":-2.46428479,\"given_cash\":0,\"service_cash\":0},\"XRP\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0}},\"time_now\":\"1667209835.956762\",\"rate_limit_status\":119,\"rate_limit_reset_ms\":1667209835945,\"rate_limit\":120}";
			
			var response = RESTHandlers.HandleWalletBalanceResponse(message);

			var list = response.CoinInfo.ToList();

			var coin = response.CoinInfo.Where(x => x.Key == "FAKE");

			Assert.IsTrue(coin.Count() != 0);

			Assert.IsTrue(coin.First().Value.Equity == 1.1m);
			Assert.IsTrue(coin.First().Value.AvailableBalnce == 2.1m);
			Assert.IsTrue(coin.First().Value.UsedMargin == 3.1m);
			Assert.IsTrue(coin.First().Value.OrderMargin == 4.1m);
			Assert.IsTrue(coin.First().Value.PositionMargin == 5.1m);
			Assert.IsTrue(coin.First().Value.OccClosingFee == 6.1m);
			Assert.IsTrue(coin.First().Value.OccFundingFee == 7.1m);
			Assert.IsTrue(coin.First().Value.WalletBalance == 8.1m);
			Assert.IsTrue(coin.First().Value.RealisedPnl == 9.1m);
			Assert.IsTrue(coin.First().Value.UnrealisedPnl == 10.1m);
			Assert.IsTrue(coin.First().Value.CumRealisedPnl == 11.1m);
			Assert.IsTrue(coin.First().Value.GivenCash == 12.1m);
			Assert.IsTrue(coin.First().Value.ServiceCash == 13.1m);
		}

		public string SendTest(RequestPayload payload)
		{
		    var request = requestArranger.Arrange(payload);
		    var req = new RestRequest(request.Query, MapRequestMethod(request.Method));
		
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
	}
}
