var num = prompt("Qual número que deseja a tabuada?");
var tabuada = [];

for(i = 0; i <= 10; i++){
    console.log(`${num} x ${i} = ${num * i}`)
    tabuada.push(`${num} x ${i} = ${num * i}`)
}

alert(tabuada.join("\n"))