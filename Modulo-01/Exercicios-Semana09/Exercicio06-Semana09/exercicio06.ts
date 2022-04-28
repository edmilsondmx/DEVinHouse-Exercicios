

class Conta{
    protected numero:number;
    protected saldo:number;
    protected estaAtiva:boolean;
    protected dono:string;

    constructor(numero:number, saldo:number, estaAtiva:boolean, dono:string){
        this.numero = numero;
        this.saldo = saldo;
        this.estaAtiva = estaAtiva;
        this.dono = dono;
    }
};

class ContaEmpresa extends Conta{
    private limiteDeDeposito:number = 1000;

    constructor(numero:number, saldo:number, estaAtiva:boolean, dono:string){
        super(numero, saldo, estaAtiva, dono)
    }

    deposito(valor:number){
        if(valor <= this.limiteDeDeposito){
            console.log(`Depósito de R$ ${valor.toFixed(2).replace(".",",")} efetuado com sucesso!`)
            this.saldo += valor
        } else {
            console.log(`Depósito de R$ ${valor.toFixed(2).replace(".",",")} está acima do máximo permitido! Não realizado!`)
        };
    };
    imprimeValorConta(){
        console.log(`Seu Saldo é de R$ ${this.saldo.toFixed(2).replace(".",",")}`);
    };

};

const teste = new ContaEmpresa(188088, 0, true, 'Edmilson Gomes');
teste.deposito(1000);
teste.deposito(400);
teste.deposito(900);
teste.deposito(200);
teste.deposito(300);
teste.deposito(700);
teste.imprimeValorConta();
