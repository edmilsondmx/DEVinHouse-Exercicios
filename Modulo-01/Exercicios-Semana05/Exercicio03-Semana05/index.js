class Produto{
    constructor(nome, preco, estoque, quantidade){
        this.nome = nome;
        this.preco = `R$ ${preco}`;
        this.emEstoque = estoque;
        this.quantidade = quantidade;
    };
};

const mouse = new Produto('mouse', 15.99, 'sim', 25)
console.log(mouse)