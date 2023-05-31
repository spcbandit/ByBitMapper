# Отличия rest api от версии 1:

Основное отличие - почти все параметры возвращаются типа string

#### Для всех запросов
1) В ответе сменились следующие параметры:
- ret_code → retCode
- ret_msg → retMsg
- ext_code → retExtMap(не для всех ответов)
- ext_info → retExtInfo
2) В ответе появился новый параметр time

#### Cancel Active Order
1) Сменился метод запроса с DELETE на POST
2) В запросе появился параметр orderCategory(обязательный для ордеров с TP/SL)
3) В ответе сменились следующие параметры:
- transactTime → createTime
- price → orderPrice
- origQty → orderQty
- executedQty → execQty
- type → orderType



#### Place Active Order
1) В запросе появился необязательные параметры:
- orderCategory(обязательный для ордеров с TP/SL)
- triggerPrice
2) В запросе сменились следующие параметры:
- qty → orderQty(string → number)
- type → orderType
- price → orderPrice
3) В ответе сменились следующие параметры:
- transactTime → createTime
- price → orderPrice
- origQty → orderQty
- executedQty → execQty
- type → orderType
4) В ответе добавились новые параметры:
- orderCategory
- triggerPrice
5) В ответе удалены параметры:
- accountId
- symbolName


#### Open Orders
1) В запросе появился необязательный параметр orderCategory(обязательный для ордеров с TP/SL)
2) В ответе сменились следующие параметры:
- price → orderPrice
- origQty → orderQty
- executedQty → execQty
- type → orderType
- time → createTime
3) В ответе убраны следующие параметры:
- exchangeId
- symbolName
4) объект result содержит массив list


#### Get Wallet Balance
1) В ответе удален параметр coinName


#### Trade History
1) В запросе сменились следующие параметры:
- fromTicketId → fromTradeId
- toTicketId → toTradeId
2) В ответе удалены следующие параметры:
- commission
- commissionAsset
- symbolName
- fee
- feeTokenId
- feeTokenName
3) В ответе сменились следующие параметры:
- ticketId → tradeId
- price → orderPrice
- qty → orderQty
- time → creatTime
- feeAmount → execFee(float → string)


#### Query Kline
1) В ответе сменились следующие параметры:
- startTime → t
- open → o
- high → h
- low → l
- close → c
- volume → v
2) В ответе убраны следующие параметры:
- endTime
- quoteAssetVolume
- trades
- takerBaseVolume
- takerQuoteVolume
3) В ответе появился параметр sn


#### Query Symbol
1) В ответе сменились следующие параметры:
- baseCurrency→ baseCoin
- quoteCurrency→ quoteCoin
- minTradeQuantity→ minTradeQty
- minTradeAmount→ minTradeAmt
- maxTradeQuantity→ maxTradeQty
- maxTradeAmount→ maxTradeAmt


#### Latest Information for Symbol
1) В ответе сменились следующие параметры:
- time → t
- symbol → s 
- bestBidPrice → bp
- bestAskPrice → ap
- lastPrice → lp
- openPrice → o
- highPrice → h
- lowPrice → l
- volume → v
- quoteVolume → qv

#### Order Book
Отличий нет
