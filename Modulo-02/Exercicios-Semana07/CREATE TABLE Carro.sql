CREATE TABLE Carro
(
    id_carro INT PRIMARY KEY IDENTITY(1,1),
    marca VARCHAR(70) NOT NULL,
    modelo VARCHAR(70) NOT NULL,
    data_fabricacao DATETIME NOT NULL,
    cor VARCHAR(30) NOT NULL,
    potencia VARCHAR(20) NOT NULL,
    placa int NOT null
)