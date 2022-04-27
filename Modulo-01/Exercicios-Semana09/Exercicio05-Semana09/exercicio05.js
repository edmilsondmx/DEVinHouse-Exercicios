var Animal = /** @class */ (function () {
    function Animal(nome, raca, pelagem, peso) {
        this.nome = nome;
        this.raca = raca;
        this.corPelagem = pelagem;
        this.peso = peso;
    }
    return Animal;
}());
var thor = new Animal("thor", "Pitbull", "Bege", 30);
console.log(thor);
