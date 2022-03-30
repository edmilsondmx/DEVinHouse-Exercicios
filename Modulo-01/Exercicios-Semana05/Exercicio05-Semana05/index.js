class Pedidos{
    numeroPedido;
    dataPedido = (new Date().toLocaleDateString());
    estaPago = false;
    listaProdutos = [];
    nomeCliente;
    adicionarProduto = (tipoProduto) => {
        if(this instanceof Pedidos){
            return this.listaProdutos.push({tipoProduto});
        };

    }
    constructor(numeroPedido, nomeCliente){
        this.numeroPedido = numeroPedido;
        this.nomeCliente = nomeCliente;
        
    }
};

const umPedido =  new Pedidos(8452, 'Edmilson Gomes')
umPedido.adicionarProduto('mouse')
console.log(umPedido);