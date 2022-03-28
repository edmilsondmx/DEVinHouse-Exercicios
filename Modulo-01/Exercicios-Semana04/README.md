# DEVinHouse-Exercicios
 Exercícios do curso DEVinHouse - Turma NDD - Semana 04 - JavaScript

<h2>[M1S04] - Ex 1 - Dado uma idade exibe a classificação dela</h2>
<p>Utilizando estrutura condicional **exiba (console.log)** a descrição da classificação da **idade (variável)** da pessoa de acordo com os dados abaixo:
</p>
<ul>
    <li>Jovens - Indivíduos de até 15 anos;</li>
    <li>Adultos - Indivíduos com idade entre 16 até 64 anos;</li>
    <li>Idosos - Indivíduos de 65 anos em diante.</li>
</ul>

<h2>[M1S04] - Ex 2 - Realize as operações matemáticas básicas</h2>
<p>Crie uma **função **que receba como **parâmetro dois números e a operação a ser realizada**;</p>
<ul>
    <li> Utilizando a estrutura condicional **switch** faça a validação e realize a operação desejada (soma, subtração, divisão ou multiplicação) com os dois números passados por parâmetro e exiba o resultado utilizando console.log.</li>
    <li>Caso seja passada uma operação diferente das 4 à cima  deve exibir utilizando console.log que a operação não está disponível.</li>
    <li>Chame essa função 5 vezes passando em cada uma uma operação como argumento e na ultima passando uma operação inválida.</li>
</ul>

<h2>[M1S04] - Ex 3 - Numero é par</h2>
<p>Dado um número verifique se ele é par, caso seja exibe a mensagem de que ele é par, caso não exibe a mensagem de que ele é impar. Para exibir a mensagem pode ser usado console.log</p>

<h2>[M1S04] - Ex 4 - Tabuada do 2</h2>
<p>Utilizando estrutura de repetição realize a tabuada do número 2 e exibe ela no console.log da seguinte forma:</p>
<p>2 x 0 = 0</p>
<p>2 x 1 = 2</p>
<p>....</p>
<p>2 x 10 = 20</p>

<h2>[M1S04] - Ex 5 - Percorra um array exiba seus valores</h2>
<p>Dado o array abaixo percorra ele e exiba o animal e sua raça utilizando console.log.</p>
var animais = [
  { animal: 'Cachorro', raca: 'Akita' },
  { animal: 'Cachorro', raca: 'Boxer' },
  { animal: 'Cachorro', raca: 'Dálmata' },
  { animal: 'Cachorro', raca: 'Pastor alemão' },
  { animal: 'Gato', raca: 'Persa' },
  { animal: 'Gato', raca: 'Sphynx' },
  { animal: 'Gato', raca: 'Siamês' },
]

<h2>[M1S04] - Ex 6 - Execute o código enquanto o valor seja verdadeiro</h2>
<ul>
    <li>Cria uma variável impares que inicia com 0;</li>
    <li>Crie uma variável contador que inicia com 0;</li>
    <li>Utilizando a estrutura de repetição **while** executa o código enquanto a variável impares for menor que 10;</li>
    <li>A variável contador deve ser incrementado dentro do while toda vez que ele for iterado;</li>
    <li> A variável impares só deve ser incrementada dentro do while quando o contador for um número ímpar;</li>
    <li>A cada iteração do while imprima o valor de contador e de impares usando console.log.</li>
</ul>

<h2>[M1S04] - Ex 7 - Converter temperatura de Fahrenheit para Celsius</h2>
<p>Dado o array abaixo realize a conversão da temperatura de  Fahrenheit para Celsius.</p>
<p>Utilizando console.log exiba o valor do array original e do novo array convertido.</p>
<p>**array:** [ 0, 32, 45, 50, 75, 80, 99, 120 ];</p>
<p>**formula:** Math.round( ( elem - 32 ) * 5 / 9 );</p>

<h2>[M1S04] - Ex 8 - Manipulando arrays</h2>
<p>Dado o array de cidades abaixo, filtre apenas as cidades com mais de 200000 habitantes</p>
<p>Após o filtro ordene por ordem decrescente de acordo com a população (primeiro cidades mais populosas)</p>
**cidades:** [
  { nome: 'Patos de Minas', populacao: 153585 },
  { nome: 'Lages', populacao: 157349 },
  { nome: 'Ibiúna', populacao: 79479 },
  { nome: 'Maringá', populacao: 403063 },
  { nome: 'Curitiba', populacao: 1963726 },
  { nome: 'Florianópolis', populacao: 508826 },
  { nome: 'Pato Branco', populacao: 84779 },
];

<h2>[M1S04] - Ex 9 - Verificar se array contem item</h2>
<p>Dado o array de cidades abaixo verificar se o array contém pelo menos uma cidade com o nome Florianópolis.</p>
<p>Deve ser retornado true filtrando por 'Florianópolis' ou 'florianópolis'.</p>
const cidades = [
  { nome: 'Patos de Minas', populacao: 153585 },
  { nome: 'Lages', populacao: 157349 },
  { nome: 'Ibiúna', populacao: 79479 },
  { nome: 'Maringá', populacao: 403063 },
  { nome: 'Curitiba', populacao: 1963726 },
  { nome: 'Florianópolis', populacao: 508826 },
  { nome: 'Pato Branco', populacao: 84779 },
];

<h2>[M1S04] - Ex 10 - Conta bancaria</h2>
<ol>
    <li>Declare como variável em seu código o array de contas de clientes abaixo;</li>
    <li>Crie uma função para sacar dinheiro que deve receber como parâmetro o valor a ser sacado e o id da conta;</li>
    <ol type="1">
        <li>Se o valor for menor ou igual zero deve exibir a mensagem de valor inválido e não realizar nenhuma operação;</li>
        <li>Se o valor for maior que o saldo em conta deve exibir a mensagem de saldo insuficiente e exibir o saldo atual;</li>
        <li>Se o valor for maior que zero e menor que o saldo em conta deve exibir a mensagem informado que o saque ocorreu com sucesso e o saldo atual da conta após o saque, além de atualizar o array com esse novo valor;</li>
    </ol>
    <li>Criar função para depositar dinheiro que deve receber como parâmetro o valor a ser depositado e o id da conta;</li>
    <ol type="1">
        <li>Se o valor for menor ou igual zero deve exibir a mensagem de valor inválido e não realizar nenhuma operação;</li>
        <li>Se o valor for maior que zero deve exibir a mensagem informado que o deposito ocorreu com sucesso e o saldo atual da conta após o deposito, além de atualizar o array com esse novo valor;</li>
    </ol>
    <li>Chamar as duas funções criadas para validar os cenários;</li>
</ol>

**contasClientes :** [
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