CREATE TABLE Cliente
(
    id_cliente int PRIMARY KEY IDENTITY(1,1),
    nome_completo VARCHAR(100) NOT NULL,
    primeiro_nome VARCHAR(30) NOT NULL,
    sobrenome VARCHAR(70) NOT NULL,
    cpf int NOT NULL,
    data_nascimento VARCHAR(10) NOT NULL
);