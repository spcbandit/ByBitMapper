﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using BybitMapper.Extensions;
using BybitMapper.Spot.UserStreams.Enums;

namespace BybitMapper.Spot.UserStreams.Events
{
    public enum SideTicket
    {
        [EnumMember(Value = "")]
        None,
        [EnumMember(Value = "BUY")]
        Buy,
        [EnumMember(Value = "SELL")]
        Sell
    }

    public class TicketInfoEvent
    {
        [JsonConstructor]
        public TicketInfoEvent(string side, string eventType, long eventTime, string tradingPair, decimal quantity, ulong timestamp, double price, string transactionId, string orderId, string userGeneratedOrderId, string orderIdOfTheOpponent, long accountId, long _accountId)
        {
            SideStr = side;
            EventType = eventType;
            EventTime = eventTime;
            TradingPair = tradingPair;
            Quantity = quantity;
            Timestamp = timestamp;
            Price = price;
            TransactionId = transactionId;
            OrderId = orderId;
            UserGeneratedOrderId = userGeneratedOrderId;
            OrderIdOfTheOpponent = orderIdOfTheOpponent;
            AccountId = accountId;
            _AccountId = _accountId;     
        }

        [JsonProperty("e")]
        public string EventType { get; }
        [JsonProperty("E")]
        public long EventTime { get; }
        [JsonProperty("s")]
        public string TradingPair { get; }
        [JsonProperty("q")]
        public decimal Quantity { get; set; }
        [JsonProperty("t")]
        public ulong Timestamp { get; }
        public long TimestampLong { get { return (long)Timestamp; } }
        [JsonProperty("p")]
        public double Price { get; set; }
        [JsonProperty("T")]
        public string TransactionId { get; }
        [JsonProperty("o")]
        public string OrderId { get; }
        [JsonProperty("c")]
        public string UserGeneratedOrderId { get; }
        [JsonProperty("O")]
        public string OrderIdOfTheOpponent { get; }
        [JsonProperty("a")]
        public long AccountId { get; }
        [JsonProperty("A")]
        public long _AccountId { get; }      
        
        [JsonProperty("S")]
        public string SideStr { get; set; }      
        public SideTicket SideType {
            get
            {
                if (SideStr is "BUY")
                {
                    return SideTicket.Buy;
                }
                else if (SideStr is "SELL")
                {
                    return SideTicket.Sell;
                }
                else
                {
                    return SideTicket.None;
                }
            }
        }      
    }
}
