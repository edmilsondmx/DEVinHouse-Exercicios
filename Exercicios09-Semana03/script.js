res = document.getElementById('res')

var hoje = new Date
var hora = hoje.getHours()
var minuto = hoje.getMinutes()

function checkTime(i) {
    if (i < 10){
        i = "0" +  i
    }
    return i
}

hora = checkTime(hora)
minuto = checkTime(minuto)


window.alert(hora + ":" + minuto)

res.innerHTML = `${hora}:${minuto}`