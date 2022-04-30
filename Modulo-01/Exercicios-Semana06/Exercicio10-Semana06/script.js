const botao = document.getElementById('btn');

botao.addEventListener('click', inverter);

const CLASS_RED = 'vermelho';
const CLASS_BLUE = 'azul'

function inverter() {
    const listaItens = document.querySelectorAll('li')

    listaItens.forEach(item => {
        item.className === CLASS_BLUE?item.className = CLASS_RED:item.className = CLASS_BLUE;
    });
};