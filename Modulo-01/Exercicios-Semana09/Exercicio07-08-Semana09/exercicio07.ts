import { Pessoa } from './exercicio08'


class Aluno implements Pessoa{
    nome: string;
    idade: number;
    rua: string;

    matricula:number;
    cadeiras:string[];

    constructor(nome:string, idade:number, rua:string, matricula:number, cadeiras:string[]){
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.matricula = matricula;
        this.cadeiras = cadeiras;
    }

    cadastrar() {
        console.log(aluno01)
    };
};
const aluno01 = new Aluno("Edmilson", 32, "dos Programadores", 18181808, ["Javascript", "Angular", "C#", ".Net Core"]);
aluno01.cadastrar();

class Funcionario implements Pessoa{
    nome: string;
    idade: number;
    rua: string;

    identificador:number;
    setor:string;

    constructor(nome:string, idade:number, rua:string, identificador:number, setor:string){
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.identificador = identificador;
        this.setor = setor;
    }
    cadastrar(){
        console.log(funcionario01)
    };
};

const funcionario01 = new Funcionario('Edmilson', 32, "dos Programadores", 800180, "Desenvolvimento");

funcionario01.cadastrar()




