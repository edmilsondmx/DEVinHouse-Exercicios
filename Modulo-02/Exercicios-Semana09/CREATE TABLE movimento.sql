CREATE TABLE movimento
(
    id_movimento int PRIMARY KEY IDENTITY(1,1),
    id_tipo int,
    id_conta int NOT NULL,
    valor DECIMAL NOT NULL,
    id_status int,
    cadastrado_em DATETIME,
    atualizado_em DATETIME,

    CONSTRAINT fk_movimento_status_movimento FOREIGN KEY (id_status) REFERENCES movimento_status(id_movimento_status),
    CONSTRAINT fk_movimento_tipo_movimento FOREIGN KEY (id_tipo) REFERENCES movimento_tipo(id_movimento_tipo)
)