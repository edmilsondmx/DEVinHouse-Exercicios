SELECT conta_categoria.nome_categoria AS 'Categoria', conta_servicos.nome_categoria AS 'Serviços' from conta_categoria
INNER JOIN conta_servicos 
ON conta_categoria.id_categoria = conta_servicos.contaCategoria_id
WHERE conta_categoria.nome_categoria = 'premium';

