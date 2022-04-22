import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'NGF-lista-item',
  templateUrl: './lista-item.component.html',
  styleUrls: ['./lista-item.component.scss']
})
export class ListaItemComponent {

  constructor() { }

  listaItens = [
    {
      nome: "Lanches Artesanais",
      img:"../../assets/imagens/hamburger.jpg",
      descricao:"Para cada tamanho de fome exste um hambúrger que acaba com ela perfeitamente!"
    },
    {
      nome: "Bebidas Diversas",
      img:"../../assets/imagens/bebida.jpg",
      descricao:"Bebidas na medida da sua sede! Refrigerantes, Sucos, Cervejas e muito mais..."
    }
  ];
  
  alerta(item:string){
    alert(`Você clicou em ${item}!`);
  };
  

}
