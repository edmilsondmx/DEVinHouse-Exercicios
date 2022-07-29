SELECT conta.id_conta AS 'Códido Conta', cliente.nome_completo AS 'Nome Cliente', cliente.cpf AS 'CPF', FORMAT(conta.valor, 'c', 'pt-br') AS 'Valor' FROM conta
INNER JOIN cliente
ON conta.cliente_id = cliente.id_cliente
WHERE conta.valor = (SELECT MAX(conta.valor) FROM conta);