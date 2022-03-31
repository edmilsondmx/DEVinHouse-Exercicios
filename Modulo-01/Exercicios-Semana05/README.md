# DEVinHouse-Exercicios
 Exercícios do curso DEVinHouse - Turma NDD - Semana 05 - JavaScript

<h2>[M1S05] - Ex 1 - Criando módulos</h2>
<p>Crie dois módulos JavaScript: um deles deve conter uma função "saudacao", exportada de forma nomeada, que retorna apenas uma string "Olá!". Chame este módulo de *saudacao.js*</p>
<p>O outro deve importar a função do módulo saudacao.js e exibir o resultado da chamada da função saudacao( ) em um console.log. Este módulo deve se chamar *index.js*</p>
<p>Em um arquivo HTML, importe o index.js com uma importação do tipo módulo. A saudação deve ser exibida no console do navegador quando o projeto html é aberto.</p>

<h2>[M1S05] - Ex 2 - Criando módulos</h2>
<p>Crie um terceiro módulo JavaScript que contenha uma função, e esta função deverá receber um nome como argumento. Quando chamada, esta função deve retornar a string <code>`Olá, ${ nome }! Seja muito bem vindo!`</code>.  O módulo javascript deve se chamar *saudacao-especial.js* e a função deve ser exportada de forma "default" (padrão).</p>
<p>No módulo index.js, importe a função do módulo saudacao-especial.js, nomeando a importação como "saudacaoEspecial", e exiba o resultado da chamada da função saudacaoEspecial( ... ) em um console.log. Passe como argumento o seu nome.</p>
<p>A saudação deve ser exibida corretamente no console do navegador quando o projeto é aberto.</p>

<h2>[M1S05] - Ex 3 - Criando classes</h2>
<p>Crie uma classe para um Produto, com as seguintes propriedades: <strong>nome</strong>, <strong>preco</strong>, <strong>emEstoque</strong>, <strong>quantidade</strong>.</p>
<p>Todas essas propriedades precisam ser recebidas no construtor da classe.</p>

<h2>[M1S05] - Ex 4 - Criando classes</h2>
<p>Crie uma classe Pedidos, com as propriedades numeroPedido, dataPedido, estaPago, listaProdutos e nomeCliente.</p>
<p>Utilize o método construtor para que, a cada instancia dessa classe, um número do pedido e o nome do cliente seja informado, a <strong>dataPedido</strong> seja a data atual <code>( new Date( ).toLocaleDateString( ))</code>, o <strong>estaPago</strong> seja falso e a <strong>listaProdutos</strong> seja um array vazio.</p>

<h2>[M1S05] - Ex 5 - Criando métodos</h2>
<p>Dentro da classe Pedido, adicione um método <strong>adicionarProduto</strong>, que recebe como argumento um objeto do tipo Produto ( <em>caso deseje</em>, você pode realizar uma validação utilizando o operador <em>instanceof</em>).</p>
<p>Este método deve adicionar (<strong>push</strong>) à propriedade listaProdutos o produto passado como argumento.</p>

<h2>[M1S05] - Ex 6 - Criando métodos</h2>
<p>Dentro da classe Pedido, crie outro método, chamado **calcularTotal**, que deve iterar sobre a **listaProdutos** e retornar o valor total do pedido. Lembre-se de multiplicar a quantidade de cada produto pelo seu valor quando realizar a soma (quantidade e valor são propriedades da classe Produto!).</p>

<h2>[M1S05] - Ex 7 - Instanciando classes</h2>
<p>Crie 5 instâncias de produtos, com as características que desejar.</p>
<p>Crie 2 instâncias de pedidos. O primeiro pedido deve ter o número '20220001' e o nome do cliente à sua escolha. O segundo pedido deve ser o '20220002'.</p>
<p>Utilizando o método **adicionarProduto**, adicione 3 dos 5 produtos ao pedido '20220001' e, o restante, ao pedido '20220002'.</p>

<h2>[M1S05] - Ex 8 - Chamando métodos de classe</h2>
<p>Estas classes criadas durante os exercícios estão prontas para serem utilizadas em uma aplicação real. Por exemplo: podemos criar um sistema de pedidos, e, através da propriedade **listaProdutos**, podemos realizar uma iteração nos produtos de determinado pedido e imprimir cada um deles em tela.</p>
<p>Podemos chamar o método **calcularTotal** para exibir em tela o valor total de um determinado pedido.</p>
<p>A princípio, vamos apenas exibir essas informações no console. Usando o método de array **forEach**, faça um console.log em cada um dos produtos de cada um dos pedidos. O texto de saída pode ser qualquer um, à seu critério. Por exemplo:
</p>
<p><code>` Produto: ${produto.nome} | Valor un: ${produto.preco} | Total: ${produto.preco * produto.quantidade} ` </code></p>
<p>Faça também um console.log para exibir o valor total de cada pedido. Exemplo:</p>
<p><code>`Preço total do pedido: R$ ${pedido.calcularTotal( )}`</code></p>




