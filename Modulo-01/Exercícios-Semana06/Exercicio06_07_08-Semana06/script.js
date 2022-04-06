const uf = document.getElementById('uf');
const cidade = document.getElementById('cidade');
const rua = document.getElementById('rua');
const botao = document.getElementById('btn');
const res = document.getElementById('res')
const tabela = document.getElementById('table')
const paragrafo = document.createElement('p')
const thead = document.createElement('thead')


botao.addEventListener('click', buscar);
async function buscar(){
    if(uf.value.length === 0 || uf.value.length > 2){
        alert(`ERRO: Preencha o campo UF corretamente!`);
    } else if(cidade.value.length === 0){
        alert(`ERRO: Preencha o campo Cidade!`);
    } else if(rua.value.length === 0){
        alert(`ERRO: Preencha o campo Rua!`);
    } else {
        try{
            const response = await fetch(`https://viacep.com.br/ws/${uf.value}/${cidade.value}/${rua.value}/json/`);
            const numCep = await response.json();
            if(numCep[0] == undefined){
                paragrafo.textContent = 'ERRO: Não foi possível encontrar CEP!'
                thead.innerHTML = "";
                
            } else{
                paragrafo.textContent = ''
                thead.innerHTML = `
                <tbody><td>CEP: </td><td>${numCep[0].cep}<td><tbody>
                <tbody><td>Logradouro: </td><td>${numCep[0].logradouro}<td><tbody>
                <tbody><td>Complemento: </td><td>${numCep[0]?.complemento}<td><tbody>
                <tbody><td>Bairro: </td><td>${numCep[0].bairro}<td><tbody>
                <tbody><td>Localidade: </td><td>${numCep[0].localidade}<td><tbody>
                <tbody><td>UF: </td><td>${numCep[0].uf}<td><tbody>
                <tbody><td>DDD: </td><td>${numCep[0].ddd}<td></tbody>`
                thead.style.border = '1px solid black';
            };
        } catch(err){
            alert('ERRO: ',err);
        };
    };
    tabela.appendChild(thead);
    res.appendChild(paragrafo);
};
