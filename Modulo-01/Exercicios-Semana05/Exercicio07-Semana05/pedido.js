export default class Pedidos{
    numeroPedido;
    dataPedido = (new Date().toLocaleDateString());
    estaPago = false;
    listaProdutos = [];
    nomeCliente;
    adicionarProduto(produto){
        if(produto instanceof Produto){
            return this.listaProdutos.push(produto);
        };
    };

    calcularTotal(){
        let vTotal = 0;
        this.listaProdutos.forEach(produto =>{
            vTotal += produto.quantidade * produto.preco;
        });
        return `O valor total é: R$ ${vTotal.toFixed(2)}`
    };
    
    constructor(numeroPedido, nomeCliente){
        this.numeroPedido = numeroPedido;
        this.nomeCliente = nomeCliente;
        
    };
};


export class Produto{
    constructor(nome, preco, estoque, quantidade){
        this.nome = nome;
        this.preco = preco;
        this.emEstoque = estoque;
        this.quantidade = quantidade;
    };
};