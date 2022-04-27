

class Animal{
    nome:string;
    raca:string;
    corPelagem:string;
    peso:number;

    constructor(nome:string, raca:string, pelagem:string, peso:number){
        this.nome = nome;
        this.raca = raca;
        this.corPelagem = pelagem;
        this.peso = peso
    }
}

const thor = new Animal("thor", "Pitbull", "Bege", 30)

console.log(thor)