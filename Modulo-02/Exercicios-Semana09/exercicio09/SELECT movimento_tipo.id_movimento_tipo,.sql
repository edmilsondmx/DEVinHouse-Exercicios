SELECT movimento_tipo.id_movimento_tipo, movimento_tipo.nome_movimento_tipo AS 'Tipo de Movimento', COUNT(id_movimento) AS 'Quantidade' FROM movimento
INNER JOIN movimento_tipo 
ON movimento.movimentoTipo_id = movimento_tipo.id_movimento_tipo
WHERE movimento_tipo.id_movimento_tipo = 5
GROUP BY movimento_tipo.id_movimento_tipo, movimento_tipo.nome_movimento_tipo;