import Pedidos, { Produto } from "./pedido.js";

const todosProdutos = [];

todosProdutos.push(new Produto('mouse', 15.99, 50, 3));
todosProdutos.push(new Produto('teclado', 25.99, 50, 5));
todosProdutos.push(new Produto('camera', 49.99, 50, 2));
todosProdutos.push(new Produto('headphone', 122.99, 50, 6));
todosProdutos.push(new Produto('monitor', 555.99, 50, 1));

const pedido1 = new Pedidos(20220001, 'Edmilson Gomes')
const pedido2 = new Pedidos(20220002, 'Pedro Izaac')


function jogarProduto(){
    for(let i = 0; i < todosProdutos.length; i++){
        if(i < 3){
            pedido1.adicionarProduto(todosProdutos[i]);
        } else{
            pedido2.adicionarProduto(todosProdutos[i]);
        };
    };
};
jogarProduto()

function mostraPedido(pedido){
    console.log(`Pedido: ${pedido.numeroPedido} - Cliente: ${pedido.nomeCliente}`)
    pedido.listaProdutos.forEach(produto => {
        console.log(`Produto: ${produto.nome} | Quantidade: ${produto.quantidade} un | Valor un: R$ ${produto.preco.toLocaleString()} | Total: R$ ${(produto.preco * produto.quantidade).toLocaleString()} `);
    });
    console.log(pedido.calcularTotal())
};
mostraPedido(pedido1)
console.log('===========================')
mostraPedido(pedido2)