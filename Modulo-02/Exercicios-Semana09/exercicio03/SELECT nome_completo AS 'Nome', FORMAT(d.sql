SELECT nome_completo AS 'Nome', FORMAT(data_nascimento, 'd', 'pt-br') AS 'Data de Nascimento', DATEDIFF(yy, data_nascimento, GETDATE()) AS 'Idade' FROM cliente
WHERE data_nascimento = (SELECT MIN(data_nascimento) FROM cliente);

