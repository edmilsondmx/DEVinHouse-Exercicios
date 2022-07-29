CREATE TABLE conta
(
    id_conta int PRIMARY KEY IDENTITY(1,1),
    id_cliente int, --fk cliente
    id_categoria int, --fk conta_categoria
    valor DECIMAL NOT NULL,

    CONSTRAINT fk_cliente_conta FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
    CONSTRAINT fk_conta_categoria_conta FOREIGN KEY(id_categoria) REFERENCES conta_categoria(id_categoria)
);