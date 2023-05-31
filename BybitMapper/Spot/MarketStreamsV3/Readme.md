# Отличия публичной части WebSocket от версии 1

Основное отличие - почти все параметры возвращаются типа string
Вместо realtime → tickers
Вместо depth → orderbook

#### trade.{symbol}(в старой версии trade)
1) В ответе удалены следующие параметры:
- symbol
- symbolName
- topic
- binary
- f
2) Параметр symbol передается в endpoint(trade.{symbol})
3) В ответе сменился параметр
sendTime → ts и его тип string → long
4) Нет массива, всё приходит в виде объекта


#### tickers.{symbol}(в старой версии realtimes)
1) В ответе удалены следующие параметры:
- symbol
- topic
- sn
- e
2) Параметр symbol передается в endpoint(tickers.{symbol})
3) В ответе сменились следующие параметры:
symbolName → s 
sendTime → ts (также тип string → long)
4) Нет массива, всё приходит в виде объекта

#### kline.{interval}.{symbol}(в старой версии kline)
1) В ответе удалены следующие параметры:
- symbol
- symbolName
- topic
- klineType
- binary
- sn
- f
2) Интервал задается параметром в endpoint. Перечисление interval можно найти на вкладке Enums.
3) Параметр symbol передается в endpoint(kline.{interval}.{symbol})
4) В ответе сменилися параметр и его тип sendTime → ts (string → long)
5) Нет массива, всё приходит в виде объекта

#### orderbook.40.{symbol}(в старой версии depth)
1) Глубина - 40. Возможно настраивается???
2) В ответе удалены следующие параметры:
- symbol
- symbolName
- topic
- binary
- e
- v
- f
- o
3) Параметр symbol передается в endpoint(kline.{interval}.{symbol})
4) В ответе сменилися параметр и его тип sendTime → ts (string → long)