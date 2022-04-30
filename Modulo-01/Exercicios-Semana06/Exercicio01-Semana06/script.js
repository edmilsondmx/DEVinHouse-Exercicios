const botao = document.getElementById('btn');


botao.addEventListener('click', alteraTitulo);
function alteraTitulo(){
    document.getElementById('title').textContent = 'Título da Página Alterado!'
};