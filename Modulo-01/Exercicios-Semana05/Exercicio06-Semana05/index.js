import Pedidos, { Produto } from "./pedido.js";

const umPedido = new Pedidos(5052, 'Edmilson Gomes');

const umProduto = new Produto('mouse', 15.99, 50, 5)
const outroProduto = new Produto('teclado', 25.55, 50, 4)

umPedido.adicionarProduto(umProduto)
umPedido.adicionarProduto(outroProduto)

console.log(umPedido)
console.log(umPedido.calcularTotal())