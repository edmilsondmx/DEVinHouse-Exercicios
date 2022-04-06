const uf = document.getElementById('uf');
const cidade = document.getElementById('cidade');
const rua = document.getElementById('rua');

const botao = document.getElementById('btn');

botao.addEventListener('click', buscar)


async function buscar(){
    if(uf.value.length === 0 || uf.value.length > 2){
        alert(`ERRO: Preencha o campo UF corretamente!`);
    } else if(cidade.value.length === 0){
        alert(`ERRO: Preencha o campo Cidade!`);
    } else if(rua.value.length === 0){
        alert(`ERRO: Preencha o campo Rua!`);
    } else {
        const response = await fetch(`https://viacep.com.br/ws/${uf.value}/${cidade.value}/${rua.value}/json/`);
        const numCep = await response.json();

        console.log(numCep[0].cep);
    }
};
