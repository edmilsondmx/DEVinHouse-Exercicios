function checkTime(i) {
    if (i < 10){
        i = "0" +  i
    }
    return i
}

function startTime(){
    var hoje = new Date()
    var hora = hoje.getHours()
    var minuto = hoje.getMinutes()
    var segundo = hoje.getSeconds()
    hora = checkTime(hora)
    minuto = checkTime(minuto)
    segundo = checkTime(segundo)
    console.log(`${hora}:${minuto}:${segundo}`)    
}

const intervalId = setInterval(() => {
    startTime();
}, 2000);

/* clearInterval(intervalId); */