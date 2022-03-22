/* function calcular(num1, num2, operador){
    switch(operador) {
        case "+":
            console.log(`A soma de ${num1} e ${num2} é: ${num1 + num2}.`);
            break;
        case "-":
            console.log(`A subtração de ${num1} e ${num2} é: ${num1 - num2}.`);
            break;
        case "*":
            console.log(`A multiplicação de ${num1} e ${num2} é: ${num1 * num2}.`);
            break;
        case "/":
            console.log(`A divisão de ${num1} e ${num2} é: ${num1 / num2}.`);
            break;
        default:
            console.log("Operador não disponível!");
    }
};

calcular(2, 8, "+");
calcular(20, 5, "-");
calcular(7, 9, "*");
calcular(15, 3, "/");
calcular(11, 3, "%"); */

function calcular(num1, num2, operador){
    switch(operador) {
        case "+":
            alert(`A soma de ${num1} e ${num2} é: ${num1 + num2}.`);
            break;
        case "-":
            alert(`A subtração de ${num1} e ${num2} é: ${num1 - num2}.`);
            break;
        case "*":
            alert(`A multiplicação de ${num1} e ${num2} é: ${num1 * num2}.`);
            break;
        case "/":
            alert(`A divisão de ${num1} e ${num2} é: ${num1 / num2}.`);
            break;
        default:
            alert("Operador não disponível!");
    }
};

calcular(Number(prompt("Qual o primeiro número?")), Number(prompt("Qual o segundo número?")), prompt("Qual a operação: ' + ' ' - ' ' * ' ' / '"));