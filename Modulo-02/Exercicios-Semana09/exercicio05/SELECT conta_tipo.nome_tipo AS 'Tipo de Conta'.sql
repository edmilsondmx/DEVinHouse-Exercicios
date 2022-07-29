SELECT conta_tipo.nome_tipo AS 'Tipo de Conta', COUNT(*) AS 'Quantidade' FROM conta
INNER JOIN conta_tipo
ON conta.contaTipo_id = conta_tipo.id_tipo
WHERE conta_tipo.nome_tipo = 'conta-salário'
GROUP BY conta_tipo.nome_tipo;
