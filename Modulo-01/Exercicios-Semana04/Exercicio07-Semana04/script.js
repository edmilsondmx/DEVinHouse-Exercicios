const tempFahrenheit = [ 0, 32, 45, 50, 75, 80, 99, 120 ];

const tempCelsius = tempFahrenheit.map(item => Math.round((item -32)* 5 / 9));
console.log(tempFahrenheit)
console.log(tempCelsius)