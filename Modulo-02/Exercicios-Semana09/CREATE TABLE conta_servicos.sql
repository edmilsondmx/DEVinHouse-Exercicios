CREATE TABLE conta_servicos
(
    id_servicos int PRIMARY KEY IDENTITY(1,1),
    id_categoria int,
    nome_categoria VARCHAR(60) NOT NULL,
    quantidade int DEFAULT '1',
    taxa int NOT NULL,

    CONSTRAINT fk_conta_categoria_conta_servicos FOREIGN KEY(id_categoria) REFERENCES conta_categoria(id_categoria)

);