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
using BybitMapper.UsdcPerpetual.RestV2;
using BybitMapper.UsdcPerpetual.RestV2.Data.Enums;
using BybitMapper.UsdcPerpetual.RestV2.Requests.Market;
using BybitMapper.UsdcPerpetual.RestV2.Requests.Account;
using BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Wallet;
using BybitMapper.UsdcPerpetual.RestV2.Requests.Account.Order;
using BybitMapper.UsdcPerpetual.RestV2.Responses.Market;

using BybitMapper.UsdcPerpetual.UserStreams.Subscriptions;
using BybitMapper.UsdcPerpetual.MarketStreams.Data.Enum;
using BybitMapper.UsdcPerpetual.MarketStreams;

namespace BybitMapperTests
{
	public class UsdcPerpetularTests
	{
		public UsdcPepetualHandlerComposition RESTHandlers;

		public MarketStreamsUsdcPerpetualHandlerComposition WSHandler = new MarketStreamsUsdcPerpetualHandlerComposition(new MarketStreamsUsdcPerpetualHandlerFactory());

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

		public UsdcPerpetularTests()
		{
			client = new RestClient(pathApi);
			
			requestArranger = new RequestArranger(ApiKey, SecretKey, GetTime);

			RESTHandlers = new UsdcPepetualHandlerComposition(new UsdcPepetualHandlerFactory());
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
			var request = new WalletInfoRequest();

			var message = SendTest(request);

			var response = RESTHandlers.HandleWalletInfoResponse(message);

			#region example

			//	\"result\":
			//	{
			//		\"walletBalance\":\"0.0000\",
			//		\"accountMM\":\"0.0000\",
			//		\"bonus\":\"0.0000\",
			//		\"accountIM\":\"0.0000\",
			//		\"totalSessionRPL\":\"\",
			//		\"equity\":\"0.0000\",
			//		\"totalRPL\":\"-0.0094\",
			//		\"marginBalance\":\"0.0000\",
			//		\"availableBalance\":\"0.0000\",
			//		\"totalSessionUPL\":\"\"
			//		},

			#endregion

			Assert.IsNotNull(response);

			Assert.IsNotNull(response.Result);

			Assert.AreEqual(response.RetMsg, "Success.");

			Assert.AreEqual(response.RetCode, 0);
		}

		/// <summary>
		/// Тест, который проверяет, что данные в объекте WalletInfoData заполняются корректно.
		/// </summary>
		[Test]
		public void TestGetBalanceParams()
		{
			var message = "{\"result\":{\"walletBalance\":\"1.1000\",\"accountMM\":\"2.1000\",\"bonus\":\"3.1000\",\"accountIM\":\"4.1000\",\"totalSessionRPL\":\"5.1000\",\"equity\":\"6.1000\",\"totalRPL\":\"7.1\",\"marginBalance\":\"8.1000\",\"availableBalance\":\"9.1000\",\"totalSessionUPL\":\"10.1\"},\"retCode\":0,\"retMsg\":\"Success.\"}";

			var response = RESTHandlers.HandleWalletInfoResponse(message);

			Assert.IsNotNull(response);

			Assert.IsNotNull(response.Result);

			Assert.AreEqual(response.RetMsg, "Success.");

			Assert.AreEqual(response.RetCode, 0);

			Assert.AreEqual(response.Result.WalletBalance, 1.1m);
			Assert.AreEqual(response.Result.AccountMM, 2.1m);
			Assert.AreEqual(response.Result.Bonus, 3.1m);
			Assert.AreEqual(response.Result.AccountIM, 4.1m);
			Assert.AreEqual(response.Result.TotalSessionRPL, 5.1m);
			Assert.AreEqual(response.Result.Equity, 6.1m);
			Assert.AreEqual(response.Result.TotalRPL, 7.1m);
			Assert.AreEqual(response.Result.MarginBalance, 8.1m);
			Assert.AreEqual(response.Result.AvailableBalance, 9.1m);
			Assert.AreEqual(response.Result.TotalSessionUPL, 10.1m);
		}

		[Test]
		public void CancelAllActiveOrders_Success()
		{
			var request = new CancelAllActiveOrdersRequest("ETHPERP", OrderFilterType.Order);

			var message = SendTest(request);

			var response = RESTHandlers.HandleCancelAllActiveOrdersResponse(message);
			
			Assert.IsNotNull(response);

			Assert.AreEqual(response.RetCode, 0);
		}

		[Test]
		public void PlaceOrder_Success()
		{
			socket = new WebSocket("wss://stream.bybit.com/trade/option/usdc/private/v1")
			{
				EmitOnPing = true
			};
			
			socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
			
			socket.OnOpen += (object sender, EventArgs e) =>
			{
                var expires = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 5000;
                var request1 = CombineStremsSubsUsdcPerpetualUser.Create(SubType.Auth, ApiKey, SecretKey, expires);

				socket.Send(request1);

				var request2 = CombineStremsSubsUsdcPerpetualUser.Create(SubType.Subscribe, UserEventType.Execution);

				socket.Send(request2);

				var request3 = CombineStremsSubsUsdcPerpetualUser.Create(SubType.Subscribe, UserEventType.Order);
				
				socket.Send(request3);
			};

			socket.OnMessage += (object sender, MessageEventArgs e) =>
			{
				Debug.Print("Message");

				var response1 = WSHandler.HandleDefaultEvent(e.Data);

				switch(response1.PerpetualEventType)
				{
					case EventPerpetualType.Order:
						CancelAllActiveOrders_Success();	// Почему-то не срабатывает здесь.
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

			var request = new PlaceOrderRequest("ETHPERP", OrderType.Limit, 
				OrderFilterType.StopOrder, SideType.Buy, 0.01m)
			{
				TimeInForce = TimeInForceType.GoodTillCancel,
				OrderPrice = 1520,
			};
			
			var message2 = SendTest(request);
			
			var response2 = RESTHandlers.HandlePlaceOrderResponse(message2);
			
			Assert.IsNotNull(response2);
			
			Assert.IsNotNull(response2.Result);
			
			Assert.AreEqual(response2.RetCode, 0);
			
			Task.Delay(20000).Wait();
		}

		[Test]
		public void PlaceStopOrder_Success()
		{
			// Market Buy:
			var request1 = new PlaceOrderRequest("ETHPERP", OrderType.Market, 
				OrderFilterType.Order, SideType.Buy, 0.01m);

			var message1 = SendTest(request1);

			var response1 = RESTHandlers.HandlePlaceOrderResponse(message1);

			// Stop Order:
			var request2 = new PlaceOrderRequest("ETHPERP", OrderType.Limit, 
				OrderFilterType.StopOrder, SideType.Sell, 0.01m)
			{
				BasePrice = 2000,
				OrderPrice = 1900,
				TakeProfit = 1900,
				TimeInForce = TimeInForceType.GoodTillCancel,
				ReduceOnly = true,
			};

			var message2 = SendTest(request2);
			
			var response2 = RESTHandlers.HandlePlaceOrderResponse(message2);

			Task.Delay(10000).Wait();
			
			// Market Sell:
			var request3 = new PlaceOrderRequest("ETHPERP", OrderType.Market, 
				OrderFilterType.Order, SideType.Sell, 0.01m);
			
			var message3 = SendTest(request3);
			
			var response3 = RESTHandlers.HandlePlaceOrderResponse(message3);

			Assert.AreEqual(response2.RetCode, 0);
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
		public void TestOrder()
		{
			
			socket = new WebSocket("wss://stream.bybit.com/trade/option/usdc/private/v1")
			{
				EmitOnPing = true
			};
			
			socket.SslConfiguration.EnabledSslProtocols = SslProtocols.Tls12;
			
			socket.OnOpen += (object sender, EventArgs e) =>
			{
				var expires = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() + 5000;
				var request1 = CombineStremsSubsUsdcPerpetualUser.Create(SubType.Auth, ApiKey, SecretKey, expires);

				socket.Send(request1);

				var request2 = CombineStremsSubsUsdcPerpetualUser.Create(SubType.Subscribe, UserEventType.Execution);

				socket.Send(request2);

				var request3 = CombineStremsSubsUsdcPerpetualUser.Create(SubType.Subscribe, UserEventType.Order);
				
				socket.Send(request3);
			};

			socket.OnMessage += (object sender, MessageEventArgs e) =>
			{
				Debug.Print("Message");

				var response1 = WSHandler.HandleDefaultEvent(e.Data);

				switch(response1.PerpetualEventType)
				{
					case EventPerpetualType.Order:
						CancelAllActiveOrders_Success();	// Почему-то не срабатывает здесь.
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

			var request = new PlaceOrderRequest("ETHPERP", OrderType.Limit, 
				OrderFilterType.StopOrder, SideType.Buy, 0.01m)
			{
				TimeInForce = TimeInForceType.GoodTillCancel,
				OrderPrice = 1520,
			};
			
			var message2 = SendTest(request);
			
			var response2 = RESTHandlers.HandlePlaceOrderResponse(message2);
			
		}
	}
}

