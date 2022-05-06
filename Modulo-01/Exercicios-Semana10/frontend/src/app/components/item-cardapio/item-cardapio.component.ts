import { Component, Input, OnInit } from '@angular/core';
import { ICardapio } from 'src/app/models/interface';

@Component({
  selector: 'NGF-item-cardapio',
  templateUrl: './item-cardapio.component.html',
  styleUrls: ['./item-cardapio.component.scss']
})
export class ItemCardapioComponent implements OnInit {

  @Input()
  lanches: ICardapio = {
    id:0,
    enderecoImg:'',
    titulo:'',
    descricao:'',
    preco:0,
  }

  @Input()
  bebidas: ICardapio = {
    id: 0,
    enderecoImg:'',
    titulo:'',
    descricao:'',
    preco:0,
  }

  



  constructor() { }

  ngOnInit(): void {
  }

}
