const botao = document.getElementById('btn');
const numCep = document.getElementById('numCep');

const res = document.getElementById('res')

const paragrafo = document.createElement('p');

botao.addEventListener('click', calcular);
async function calcular(){
    if(numCep.value.length !== 8){
        alert('ERRO: Digite um CEP válido!');
    } else{
        try{
            const response = await fetch(`https://viacep.com.br/ws/${numCep.value}/json/`);
            const res = await response.json();
            console.log(res);
        } catch(err){
            console.log('Erro: ',err);
        };
    };
    
    /* res.appendChild(paragrafo); */
};