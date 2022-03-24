const contasClientes = [
    {
      id: 1,
      saldo: 500,
    },
    {
      id: 2,
      saldo: 30000,
    },
    {
      id: 3,
      saldo: 50,
    },
];


function saque(valor, id){
    const iden = id - 1;
    if(valor <= 0){
        console.log("Valor inválido!");
    } else if(valor > contasClientes[iden].saldo){
        console.log(`Saldo insuficiente. \nSaldo atual R$ ${contasClientes[iden].saldo},00`);
    } else{
        const saldoAtual = contasClientes[iden].saldo - valor;
        console.log(`Saque de R$${valor},00 realizado com sucesso! \nSaldo atual R$ ${saldoAtual},00!`);
        contasClientes[iden]["saldo"] = saldoAtual
    };


};


function deposito(valor, id){
    const iden = id - 1;
    if(valor <= 0){
        console.log("Valor inválido!");
    } else{
        const saldoAtual = contasClientes[iden].saldo + valor;
        console.log(`Depósito de R$${valor},00 realizado com sucesso!\nSaldo atual R$${saldoAtual},00!`);
        contasClientes[iden]["saldo"] = saldoAtual
    };
};

saque(200,1);
deposito(200,3);
console.log(contasClientes);
