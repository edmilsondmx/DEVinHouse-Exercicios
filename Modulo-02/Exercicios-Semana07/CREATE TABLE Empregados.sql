CREATE TABLE Empregados
(
    id_emp int PRIMARY KEY IDENTITY(1,1),
    nome_emp VARCHAR(200) NOT NULL,
    endereco VARCHAR(200) NOT NULL,
    idade int NOT NULL,
)