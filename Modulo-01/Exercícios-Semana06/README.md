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

<h2>[M1S06] - Ex 6 - Busca CEP Parte 1</h2>
<p>Crie uma página html para buscar os CEP através do endereço contendo:</p>
<ul>
    <li>1 input para UF</li>
    <li>1 input para cidade</li>
    <li>1 input para  logradouro/rua</li>
    <li>1 button para consultar</li>  
</ul>
<p>Crie uma função assíncrona para realizar a busca na api</p>
<ul>
    <li>Utilize o endereço da api https://viacep.com.br/ws/UF/CIDADE/RUA/json/ substituindo os UF, CIDADE e RUA pelos campos que o usuário informou nos inputs</li>
    <li>Exiba o resultado no console</li> 
</ul>
<p>Adicione o evento de clique no botão de consulta para a função criada</p>

<h2>[M1S06] - Ex 7 - Busca CEP Parte 2</h2>
<p>Após implementar o Ex 6, vamos adicionar tratativas na função criada;</p>
<ul>
    <li>Valide se todos os campos estão preenchidos, caso não estejam exiba alerta informando os campos que ainda precisam ser preenchidos</li>
    <li>Caso o uf tenha mais ou menos de 2 caracteres exiba alerta informando que o UF é inválido</li>
    <li>Em ambos os casos não deve ser realizada a busca na api</li>
</ul>

<h2>[M1S06] - Ex 8 - Busca CEP Parte 3</h2>
<p>Após implementar o Ex 7, vamos adicionar tratativas na função criada;</p>
<p>Caso o retorno da api seja um erro deve ser exibido um alerta para o usuário</p>
<p>Caso de sucesso mas não retorne nenhum cep deve ser exibido um elemento <p> com a informação de que nenhum registro foi encontrado</p>
<p>Caso a api retorne os resultados deve ser criada uma tabela contendo </p>
<ul>
    <li>cep</li>
    <li>logradouro</li>
    <li>complemento</li>
    <li>bairro</li>
    <li>localidade</li>
    <li>uf</li>
    <li>ddd</li>
</ul>

<h2>[M1S06] - Ex 9 - Manipulação de DOM</h2>
<p>Utilize o seguinte HTML como base para o seu exercício:</p>
<pre><code>
    <!DOCTYPE html>
    <html>
    <head>
        <meta charset="UTF-8" />
        <title>Document</title>
    </head>
    <body>
        <h1>Titulo</h1>
        <p>subtítulo</p>
        <p id="descricao">Lista de afazeres</p>
        <ul>
        <li class="itens">Ex 1</li>
        <li class="itens">Ex 2</li>
        <li class="itens">Ex 3</li>
        <li class="itens">Ex 4</li>
        </ul>
    </body>
    </html>
</code></pre>
<p>No arquivo js crie uma função e adicione as seguintes variáveis:</p>
<ul>
    <li>titulo: conterá a primeira tag h1;</li>
    <li>descricao: conterá a tag com id = descricao;</li>
    <li>listaItens: conterá todas as tags com classe = itens;</li>
    <li>Atribua para as variáveis os elementos solicitados utilizando querySelector e querySelectorAll </li>
    <li>Imprima os valores das variáveis utilizando console.log</li>
</ul>
<p>Importe o arquivo js em sua página html</p>
<p>Vincule a função criada com o evento de onload do body da página </p>


