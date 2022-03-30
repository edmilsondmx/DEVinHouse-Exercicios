class Pedidos{
    numeroPedido;
    dataPedido = (new Date().toLocaleDateString());
    estaPago = false;
    listaProdutos = [];
    nomeCliente;
    constructor(numeroPedido, nomeCliente){
        this.numeroPedido = numeroPedido;
        this.nomeCliente = nomeCliente;
        
    }
};

const umPedido =  new Pedidos(8452, 'Edmilson Gomes')
console.log(umPedido);