var anoNasc = prompt("Qual ano do seu nascimento?")
var anoAtual = prompt("Qual o ano atual?")

var idadeSjf = anoAtual - anoNasc
var idadeSnf = (anoAtual - 1) - anoNasc

window.alert("Sua idade é " + idadeSjf + " ou " + idadeSnf + "!")