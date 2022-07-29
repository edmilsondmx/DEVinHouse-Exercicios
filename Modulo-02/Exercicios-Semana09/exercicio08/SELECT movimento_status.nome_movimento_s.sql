SELECT movimento_status.nome_movimento_status AS 'Movimento', COUNT(*) AS 'Quantidade' FROM movimento
INNER JOIN movimento_status
ON movimento.movimentoStatus_id = movimento_status.id_movimento_status
WHERE movimento_status.nome_movimento_status = 'falha'
GROUP BY movimento_status.nome_movimento_status;