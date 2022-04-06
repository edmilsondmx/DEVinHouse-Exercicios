const uf = document.getElementById('uf');
const cidade = document.getElementById('cidade');
const rua = document.getElementById('rua');

const botao = document.getElementById('btn');

botao.addEventListener('click', buscar)

async function buscar(){
    const response = await fetch(`https://viacep.com.br/ws/${uf.value}/${cidade.value}/${rua.value}/json/`);
    const numCep = await response.json();

    console.log(numCep[0].cep);
};
