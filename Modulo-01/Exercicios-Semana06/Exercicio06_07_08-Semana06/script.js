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
                thead.innerHTML = /*HTML*/ `
                <tr><th> CEP: </th> <td> ${numCep[0].cep} </td></tr>
                <tr><th>Logradouro: </th><td>${numCep[0].logradouro}</td></tr>
                <tr><th>Complemento: </th><td>${numCep[0]?.complemento}</td></tr>
                <tr><th>Bairro: </th><td>${numCep[0].bairro}</td></tr>
                <tr><th>Localidade: </th><td>${numCep[0].localidade}</td></tr>
                <tr><th>UF: </th><td>${numCep[0].uf}</td></tr>
                <tr><th>DDD: </th><td>${numCep[0].ddd}</td></tr>`;
                
            };
        } catch(err){
            alert('ERRO: ',err);
        };
    };
    tabela.appendChild(thead);
    res.appendChild(paragrafo);
};
