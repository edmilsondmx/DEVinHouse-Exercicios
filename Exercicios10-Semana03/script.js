var vInicial = Number(prompt("Qual o valor inicial?"));
var vRaiz = Number(prompt("Qual o valor raiz?"));
var res = document.getElementById('res')

for (var i = 0; i < 10; i++) {
    res.innerHTML += vInicial + " "
    vInicial += vRaiz
    
};


