const botao = document.getElementById('btn');
const numCep = document.getElementById('numCep');

const res = document.getElementById('res')

const address = document.createElement('address');

botao.addEventListener('click', calcular);
async function calcular(){
    if(numCep.value.length === 0){
        alert('ERRO: O campo de busca deve ser preenchido!')
    } else if(numCep.value.length !== 8){
        alert('ERRO: Digite um CEP válido!');
    } else{
        try{
            const response = await fetch(`https://viacep.com.br/ws/${numCep.value}/json/`);
            const endereco = await response.json();
            if(endereco.erro === true){
                alert("Não foi possível consultar o CEP informado!")
            }else{
                address.innerHTML = `${endereco?.logradouro}
                 - ${endereco?.complemento}
                ${endereco?.bairro}
                 - ${endereco?.localidade} - ${endereco?.uf}
                 - ${endereco.cep}`
            }
            
        } catch(err){
            console.log(err);
        };
    };
    
    res.appendChild(address);
};