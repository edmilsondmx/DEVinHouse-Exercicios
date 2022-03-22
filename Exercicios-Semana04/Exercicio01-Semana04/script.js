// Jovens - Indivíduos de até 15 anos;
// Adultos - Indivíduos com idade entre 16 até 64 anos;
// Idosos - Indivíduos de 65 anos em diante.

var idade = prompt("Qual a sua idade?");

if(idade <= 15){
    alert("Você tem " + idade + " anos, então é uma pessoa Jovem!");
    console.log("Você tem " + idade + " anos, então é uma pessoa Jovem!");
} else if(idade < 65){
    alert("Você tem " + idade + " anos, então é uma pessoa Adulta!");
    console.log("Você tem " + idade + " anos, então é uma pessoa Adulta!");
} else{
    alert("Você tem " + idade + " anos, então é uma pessoa Idosa!");
    console.log("Você tem " + idade + " anos, então é uma pessoa Idosa!");
};