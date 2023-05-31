# Отличия приватной части WebSocket от версии 1

Основное отличие - почти все параметры возвращаются типа string
Вместо ExecutionReport -> Order
Появился stopOrder - для сделок со стопом
Объекты находятся в массиве Data

#### outboundAccountInfo
1) объекты находятся в массиве Data

#### order
1) объекты находятся в массиве Data
2) Разныe endpoint'ы

#### stopOrder
1) объекты находятся в массиве Data
2) Разныe endpoint'ы

#### ticketInfo
1) объекты находятся в массиве Data