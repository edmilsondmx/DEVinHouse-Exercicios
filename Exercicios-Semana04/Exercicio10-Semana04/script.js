const contas = [
    {id: 1, saldo: 500},
    {id: 2, saldo: 30000},
    {id: 3, saldo: 50},
];

const saque = ((valor, id) => {
    let idClient = contas.find(idClient => idClient.id === id);
    if(valor <= 0){
        console.log("Valor inválido para saque!")
    } else if(valor > idClient.saldo){
        console.log(`Saldo insuficiente.
Saldo da conta R$${idClient.saldo},00`)
    } else{
        vAtual = idClient.saldo -= valor;
        console.log(`Saque de R$${valor},00 realizado com sucesso.
Saldo Restante R$${vAtual},00`)
            
    }
    return contas
});

const deposito = ((valor, id) => {
    let idClient = contas.find(idClient => idClient.id === id);
    if(valor <= 0){
        console.log("Valor inválido para depósito!")
    } else{
        vAtual = idClient.saldo += valor;
        console.log(`Depósito de R$${valor},00 realizado com sucesso.
Saldo Atual R$${vAtual},00`)
            
    }
    return contas
});

saque(200, 1)
deposito(200, 3)
console.log(contas)
