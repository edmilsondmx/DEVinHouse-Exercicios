const botao = document.getElementById('btn');
const num1 = document.getElementById('num1');
const num2 = document.getElementById('num2');
const operador = document.getElementById('operador');
const res = document.getElementById('res')

const paragrafo = document.createElement('p');

botao.addEventListener('click', calcular);
function calcular(){
    if(num1.value.length === 0 || num2.value.length === 0 || operador.value == ""){
        alert('ERRO: Não foi possivel fazer a operação!');
    } else{
        switch (operador.value) {
            case 'soma':
                paragrafo.innerHTML = `O Resultado é: ${Number(num1.value) + Number(num2.value)}`;
                break;
            case 'subtracao':
                paragrafo.innerHTML = `O Resultado é: ${Number(num1.value) - Number(num2.value)}`;
                break;
            case 'multiplicacao':
                paragrafo.innerHTML = `O Resultado é: ${Number(num1.value) * Number(num2.value)}`;
                break;
            case 'divisao':
                paragrafo.innerHTML = `O Resultado é: ${Number(num1.value) / Number(num2.value)}`;
                break;
        
            default:
                break;
        };
    };
    
    res.appendChild(paragrafo);
};