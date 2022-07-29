USE Banking;
INSERT INTO movimento (movimentoTipo_id, conta_id, valor, movimentoStatus_id, cadastrado_em, atualizado_em)
VALUES 
(1, 5, 1000, 1, CONVERT(datetime, '2021-05-22 13:21:30', 20)  , CONVERT(datetime,'2021-06-13 09:25:35', 20));