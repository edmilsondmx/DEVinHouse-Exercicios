# DEVinHouse-Exercicios
 Exercícios do curso DEVinHouse - Turma NDD - Semana 06 - JavaScript - DOM

<h2>[M1S06] - Ex 1 - Manipulando DOM</h2>
<p>- Crie uma página html e adicione um título h1 com a descrição "Título da página";</p>
<p>- Adicione um botão com a descrição "Alterar título" e adicione o evento de click nele para uma função javascript;</p>
<p>- Crie a função javascript para alterar o título, nela deve ser buscado o elemento h1 e alterado o texto para "Título da página alterado";</p>

<h2>[M1S06] - Ex 2 - Manipulando DOM</h2>
<p>Crie um uma página html contendo:</p>
<ul>
    <li>2 inputs do tipo number;</li>
    <li>1 select com as options Somar, Subtrair, Dividir, Multiplicar</li>
    <li>1 button com o texto Calcular</li>
</ul>
<p>Crie uma função JavaScript para efetuar as operações:</p>
<ul>
    <li>Deve ser obtido os valores dos inputs</li>
    <li>Deve ser obtida a operação desejada de acordo com o valor do select</li>
    <li>Deve ser adicionado um elemento do tipo via JavaScript para exibir o resultado do cálculo</li>
    <li>Adicione o evento de click no botão calcular</li>
</ul>

<h2>[M1S06] - Ex 3 - Busca Endereço Parte 1</h2>
<p>Crie uma página html para buscar o endereço através do cep contendo:</p>
<ul>
    <li>1 input para receber o CEP</li>
    <li>1 button para buscar o endereço</li>
</ul>
<p>Crie uma função assíncrona que deve realizar o fetch do endereço do cep</p>
<ul>
    <li>Utilize este endpoint: https://viacep.com.br/ws/01001000/json/</li>
    <li>Substitua o 01001000 pelo cep digitado no input</li>
    <li>Faça a chamada utilizando Fetch e aguarde o resultado</li>
    <li>Exiba o resultado no console.log</li>
</ul>
<p>Adicione no button o evento de click para chamar a função criada.</p>

<h2>[M1S06] - Ex 4 - Busca Endereço Parte 2</h2>
<p>Após implementar o Ex 3, vamos adicionar tratativas na função criada;</p>
<ul>
    <li> Quando o usuário clicar no botão de buscar sem ter informado um valor no input exibir modal de alerta (alert) informando que o campo precisa ser preenchido</li>
    <li> Quando o usuário preencher o campo com menos ou mais de 8 caracteres deve ser exibido modal de alerta (alert) informando que o campo foi preenchido com um cep inválido</li>
    <li>Em ambos os casos à cima não deve ser realizada a consulta na api de cep</li>
</ul>

<h2>[M1S06] - Ex 5 - Busca Endereço Parte 3</h2>
<p>Após implementar o Ex 4, vamos adicionar tratativas na função criada;</p>
<ul>
    <li> Caso a api retorne erro deve ser exibido um alerta para o usuário informando que não foi possível consultar o cep</li>
    <li>Caso a api retorne sucesso deve ser adicionado um elemento <p> com o endereço formatado ex: logradouro, complemento - bairro - localidade/uf</li>
    
</ul>



