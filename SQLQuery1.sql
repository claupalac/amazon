create view prueba2 as select pedidoId, count(productId) as t from pedido group by pedidoId


select * from prueba2