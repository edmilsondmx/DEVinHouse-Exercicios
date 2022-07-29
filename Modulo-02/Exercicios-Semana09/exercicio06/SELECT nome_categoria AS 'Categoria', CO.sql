SELECT nome_categoria AS 'Categoria', COUNT(id_cliente) AS 'Quantidade de Clientes' FROM cliente
INNER JOIN conta ON cliente.id_cliente = conta.cliente_id
INNER JOIN conta_categoria ON conta.contaCategoria_id = conta_categoria.id_categoria
WHERE conta_categoria.nome_categoria = 'ouro'
GROUP BY nome_categoria;

