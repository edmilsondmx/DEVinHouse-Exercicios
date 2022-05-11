import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'exe-exercicio04',
  templateUrl: './exercicio04.component.html',
  styleUrls: ['./exercicio04.component.scss']
})
export class Exercicio04Component implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  arrayFotos:any = [
 	 {
	    url: "https://live.staticflickr.com/65535/40735663513_6c328788c7_b.jpg",
      title: "Os Vingadores",
	    description:"Após Thanos eliminar metade das criaturas vivas, os Vingadores têm de lidar com a perda de amigos e entes queridos. Com Tony Stark vagando perdido no espaço sem água e comida, Steve Rogers e Natasha Romanov lideram a resistência contra o titã louco."
	  },
	  {
	    url: "https://sm.ign.com/t/ign_br/screenshot/default/dragon-ball-super_edy9.1200.jpg",
      title: "Dragon Ball Super: Broly",
	    description:"Apesar da Terra estar em um período de calmaria, Goku se recusa a parar de treinar constantemente. O que ele não imaginava era que seu novo inimigo seria Broly, um poderoso super saiyajin sedento por vingança, que deseja destruir todos que encontrar pela frente."
	  },
	  {
	    url: "https://cinemacao.com/wp-content/uploads/2020/03/qk2kl2kl2kl1k21-950x534-1.jpg",
      title: "O Auto da Compadecida",
	    description:"As aventuras de João Grilo e Chicó, dois nordestinos pobres que vivem de golpes para sobreviver. Eles estão sempre enganando o povo de um pequeno vilarejo, inclusive o temido cangaceiro Severino de Aracaju, que os persegue pela região."
	  },
	  {
	    url: "https://studiosol-a.akamaihd.net/uploadfile/letras/playlists/8/6/7/b/867ba6f11ed8efa1725d117419bf86c5.jpg",
      title: "As Branquelas",
	    description:"Dois irmãos agentes do FBI, Marcus e Kevin Copeland, acidentalmente evitam que bandidos sejam presos em uma apreensão de drogas. Como castigo, eles são forçados a escoltar um par de socialites nos Hamptons."
	  },
	  {
	    url: "http://1.bp.blogspot.com/-RrfZUN1YZAk/VF-_eYqyLoI/AAAAAAAAESI/2QqMAgFuaFo/s1600/os-intocaveis-no-cineclube-lumiar.jpg",
      title: "Intocáveis",
	    description:"Um milionário tetraplégico contrata um homem da periferia para ser o seu acompanhante, apesar de sua aparente falta de preparo. No entanto, a relação que antes era profissional cresce e vira uma amizade que mudará a vida dos dois."
	  },
	  {
	    url: "https://www.metalpiracicaba.com.br/wp-content/uploads/2018/04/marlon-1-696x407.jpg",
      title: "O Poderoso Chefão",
	    description:"Uma família mafiosa luta para estabelecer sua supremacia nos Estados Unidos depois da Segunda Guerra Mundial. Uma tentativa de assassinato deixa o chefão Vito Corleone incapacitado e força os filhos Michael e Sonny a assumir os negócios."
	  },
	]

}
