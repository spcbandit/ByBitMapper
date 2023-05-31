using System;
using System.Security.Authentication;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;

using NUnit.Framework;
using NUnit.Framework.Internal;

using RestSharp;
using WebSocketSharp;

using BybitMapper.Requests;
using BybitMapper.InversePerpetual.RestV2;
using BybitMapper.InversePerpetual.RestV2.Requests.Market;
using BybitMapper.InversePerpetual.RestV2.Requests.Account.ConditionalOrders;
using BybitMapper.InversePerpetual.RestV2.Requests.Account.Wallet;
using BybitMapper.InversePerpetual.RestV2.Data.Enums;
using BybitMapper.InversePerpetual.RestV2.Data;
using BybitMapper.InversePerpetual.RestV2.Requests.Account.ActiveOrders;
using BybitMapper.InversePerpetual.UserStreams.Subscriptions;
using BybitMapper.InversePerpetual.UserStreams.Data;
using BybitMapper.InversePerpetual.UserStreams.Events;
using BybitMapper.InversePerpetual.UserStreams;

namespace BybitMapperTests
{
	public class InversePerpetualTests
	{
		public InversePerpetualV2HandlerComposition RESTHandlers;

		public UserStreamsHandlerComposition WSHandler = new UserStreamsHandlerComposition(new UserStreamsHandlerFactory());

		public BybitMapper.InversePerpetual.MarketStreams.MarketStreamsHandlerComposition MarketWSHandler = new BybitMapper.InversePerpetual.MarketStreams.MarketStreamsHandlerComposition(new BybitMapper.InversePerpetual.MarketStreams.MarketStreamsHandlerFactory());

		private const string ApiKey = "2pam4sQkFE6yIz5Ily";
		
		private const string SecretKey = "Ds5eEKo5ZfmMPNSzGxTWBtiBUVXv0ivEx7dy";

		// private const string ApiKey = "sKBvMgsXbONGJQ1Zuq";
		//
		// private const string SecretKey = "HFh9Ddp27gK8FHCE2nIPHarUDG4tBQNh6C16";

        private const string pathTestApi = "https://api-testnet.bybit.com";

		private const string pathApi = "https://api.bybit.com";

		private RequestArranger requestArranger;

		private RestClient client;

		private WebSocket socket;

		public InversePerpetualTests()
		{
			client = new RestClient(pathApi);
			
			requestArranger = new RequestArranger(ApiKey, SecretKey, GetTime);

			RESTHandlers = new InversePerpetualV2HandlerComposition(new InversePerpetualV2HandlerFactory());
		}

		private long GetTime()
        {
			var request = new ServerTimeRequest();

			var message = SendTest(request);

			var response = RESTHandlers.HandleServerTimeResponse(message);

			return (long)Math.Round(response.Timestamp * 1000);
        }

		[Test]
		public void GetBalance_Success()
		{
			var request = new GetWalletBalanceRequest(null);

			var message = SendTest(request);

			var response = RESTHandlers.HandleGetWalletBalanceResponse(message);

			var list = response.CoinInfo.ToList();

			#region example

			//"result\":
			//{
			//	\"ADA\":
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
			//	},
			//	\"BIT\":
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
			//}"

			#endregion

			Assert.IsNotNull(response);

			Assert.IsNotNull(response.CoinInfo);

			Assert.AreEqual(response.RetMessage, "OK");

			Assert.AreEqual(response.RetCode, 0);
		}

		/// <summary>
		/// Тест, в котором проверяется поведение системы в случае добавления новой монеты со стороны биржи.
		/// </summary>
		[Test]
		public void ExtraCointTest()
		{
			string message = "{\"ret_code\":0,\"ret_msg\":\"OK\",\"ext_code\":\"\",\"ext_info\":\"\",\"result\":{\"FAKE\":{\"equity\":1.1,\"available_balance\":2.1,\"used_margin\":3.1,\"order_margin\":4.1,\"position_margin\":5.1,\"occ_closing_fee\":6.1,\"occ_funding_fee\":7.1,\"wallet_balance\":8.1,\"realised_pnl\":9.1,\"unrealised_pnl\":10.1,\"cum_realised_pnl\":11.1,\"given_cash\":12.1,\"service_cash\":13.1},\"ODA\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"BIT\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"BTC\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"DOT\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"EOS\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"ETH\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"LTC\":{\"equity\":0.28061,\"available_balance\":0.28061,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0.28061,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"LUNA\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"MANA\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"SOL\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0},\"USDT\":{\"equity\":0.00001521,\"available_balance\":0.00001521,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0.00001521,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":-2.46428479,\"given_cash\":0,\"service_cash\":0},\"XRP\":{\"equity\":0,\"available_balance\":0,\"used_margin\":0,\"order_margin\":0,\"position_margin\":0,\"occ_closing_fee\":0,\"occ_funding_fee\":0,\"wallet_balance\":0,\"realised_pnl\":0,\"unrealised_pnl\":0,\"cum_realised_pnl\":0,\"given_cash\":0,\"service_cash\":0}},\"time_now\":\"1667209835.956762\",\"rate_limit_status\":119,\"rate_limit_reset_ms\":1667209835945,\"rate_limit\":120}";
			
			var response = RESTHandlers.HandleGetWalletBalanceResponse(message);

			var list = response.CoinInfo.ToList();

			var coin = response.CoinInfo.Where(x => x.Key == "FAKE");

			Assert.IsTrue(coin.Count() != 0);

			Assert.IsTrue(coin.First().Value.Equity == 1.1m);
			Assert.IsTrue(coin.First().Value.AvailableBalance == 2.1m);
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

		[Test]
		public void GetConditionalOrder_Success()
		{
			var request = new GetConditionalOrdersRequest("BTCUSD")
			{ 
				StopOrderType = null,
				Limit = 49
			};

			var message = SendTest(request);

			var response = RESTHandlers.HandleGetConditionalOrder(message);

			Assert.IsNotNull(response);

			Assert.AreEqual(response.RetMessage, "OK");

			Assert.AreEqual(response.RetCode, 0);
		}

		[Test]
		public void CancelConditionalOrder_Success()
		{
			var request = new CancelConditionalOrderRequest("LTCUSD")
			{
				StopOrderId = "536a52cc-5f04-4d93-a59e-452023e89f1a"
			};
			
			var message = SendTest(request);
			
			var response = RESTHandlers.HandleCancelConditionalOrder(message);
			
			Assert.IsNotNull(response);
			
			Assert.AreEqual(response.RetMessage, "OK");
			
			Assert.AreEqual(response.RetCode, 0);
		}

		[Test]
		public void CancelAllConditionalOrders_Success()
		{
			var request = new CancelAllConditionalOrdersRequest("LTCUSD");

			var message = SendTest(request);

			var response = RESTHandlers.HandleCancelAllConditionalOrder(message);

			Assert.IsNotNull(response);

			Assert.AreEqual(response.RetMessage, "OK");

			Assert.AreEqual(response.RetCode, 0);
		}

		[Test]
		public void PlaceConditionOrder_Success()
		{
			socket = new WebSocket("wss://stream.bybit.com/realtime")
			{
				EmitOnPing = true
			};
			
			socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
			
			socket.OnOpen += (object sender, EventArgs e) =>
			{
				var expires = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 5000;
                var request1 = CombineStremsSubs.Create(SubType.Auth, ApiKey, SecretKey, expires);

				socket.Send(request1);

				var request2 = CombineStremsSubs.Create(SubType.Subscribe, UserEventType.StopOrder);
				
				socket.Send(request2);
			};

			socket.OnMessage += (object sender, MessageEventArgs e) =>
			{
				Debug.Print("Message");

				var response1 = MarketWSHandler.HandleDefaultEvent(e.Data);

				if(response1.WSEventType == BybitMapper.InversePerpetual.MarketStreams.Data.EventType.StopOrder)
				{
					
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

			var request = new PlaceConditionalOrderRequest(OrderSideType.Sell, "LTCUSD", 
				OrderType.Market, 5.0m, 60.2m, 60.21m, TimeInForceType.GoodTillCancel);

			var message2 = SendTest(request);

			var response2 = RESTHandlers.HandlePlaceConditionalOrderResponse(message2);

			Assert.IsNotNull(response2);
			
			Assert.IsNotNull(response2.Result);
			
			Assert.AreEqual(response2.RetMsg, "OK");
			
			Assert.AreEqual(response2.RetCode, 0);

			Task.Delay(20000).Wait();
		}

		[Test]
		public void StopOrdersWebSocketTest()
		{
			socket = new WebSocket("wss://stream.bybit.com/realtime")
			{
				EmitOnPing = true
			};
			
			socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
			
			socket.OnOpen += (object sender, EventArgs e) =>
			{
                var expires = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 5000;
                var request1 = CombineStremsSubs.Create(SubType.Auth, ApiKey, SecretKey, expires);
                socket.Send(request1);
                var request2 = CombineStremsSubs.Create(SubType.Subscribe, UserEventType.StopOrder);
                socket.Send(request2);
			};

			socket.OnMessage += (object sender, MessageEventArgs e) =>
			{
				Debug.Print("Message");

				var response1 = MarketWSHandler.HandleDefaultEvent(e.Data);

				if(response1.WSEventType == BybitMapper.InversePerpetual.MarketStreams.Data.EventType.StopOrder)
				{
					var order = WSHandler.HandleStopOrderEvent(e.Data);
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

			Task.Delay(2000000).Wait();
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

		[Test]
		public void Cancel()
		{
			
			
			 // var request = new PlaceOrderRequest("BTCUSDT", 1, CreateSpotOrderSideType.Sell, CreateSpotOrderType.Limit)
			 // {
			 // 	OrderPrice = 1
			 // };

			 
			 var request = new PlaceOrderRequest(
				 OrderSideType.Sell,
				 "",
				 OrderType.Limit,
				 1,
				 null,
				 TimeInForceType.Unrecognized,
				 null,
				 100000,
				 null,
				 null,
				 null
				 );
			
			//var message = SendTest(request);
			var message = "{\"ret_code\":10001,\"ret_msg\":\"params error: symbol invalid \",\"result\":{},\"ext_code\":\"\",\"ext_info\":\"\",\"time_now\":\"1675936903.604555\",\"rate_limit_status\":99,\"rate_limit\":100,\"rate_limit_reset_ms\":1675936903603}";
			 //var response = RESTHandlers.HandlePlaceOrder(message);
			 var response1 = RESTHandlers.HandleErrorResponse(message);
			
			//var response = RESTHandlers.HandlePlaceOrder(message);
			//var response1 = RESTHandlers.HandleErrorResponse(message);
			
		}
	}
}
