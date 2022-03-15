res = document.getElementById('res')

var hoje = new Date
var hora = hoje.getHours()
var minuto = hoje.getMinutes()

window.alert(hora + ":" + minuto)

res.innerHTML = `${hora}:${minuto}`