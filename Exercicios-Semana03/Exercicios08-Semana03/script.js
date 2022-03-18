var operacao = prompt('Que tipo de calculo deseja fazer( " + ", " - ", " * ", " / ")?');
var num1 = Number(prompt("Qual o primeiro valor que deseja calcular?"));
var num2 = Number(prompt("Qual o segundo valor que deseja calcular?"));

var res;

switch (operacao) {
    case "+":
        res = num1 + num2
        break;
    case "-":
        res = num1 - num2
        break;
    case "*":
        res = num1 * num2
        break;
    case "/":
        res = num1 / num2
        break;
    default:
        window.alert("Operador inválido!")
        break;
}



/*if (operacao == "+"){
    res = num1 + num2;
} else if (operacao == "-"){
    res = num1 - num2;
} else if(operacao == "*"){
    res = num1 * num2;
} else if(operacao == "/"){
    res = num1 / num2;
} else{
    res = "Operador inválido!"
};
 */


window.alert("O resultado do seu cálculo é: "+ res +"!");

