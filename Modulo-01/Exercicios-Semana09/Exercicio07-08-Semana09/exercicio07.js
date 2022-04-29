;
var Aluno = /** @class */ (function () {
    function Aluno(nome, idade, rua, matricula, cadeiras) {
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.matricula = matricula;
        this.cadeiras = cadeiras;
    }
    Aluno.prototype.cadastrar = function () {
        console.log(aluno01);
    };
    ;
    return Aluno;
}());
;
var aluno01 = new Aluno("Edmilson", 32, "dos Programadores", 18181808, ["Javascript", "Angular", "C#", ".Net Core"]);
aluno01.cadastrar();
var Funcionario = /** @class */ (function () {
    function Funcionario(nome, idade, rua, identificador, setor) {
        this.nome = nome;
        this.idade = idade;
        this.rua = rua;
        this.identificador = identificador;
        this.setor = setor;
    }
    Funcionario.prototype.cadastrar = function () {
        console.log(funcionario01);
    };
    ;
    return Funcionario;
}());
;
var funcionario01 = new Funcionario('Edmilson', 32, "dos Programadores", 800180, "Desenvolvimento");
funcionario01.cadastrar();
