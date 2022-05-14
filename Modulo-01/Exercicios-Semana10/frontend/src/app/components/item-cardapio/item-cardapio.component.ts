
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { ICardapio } from 'src/app/models/interface';
import { PedidoService } from 'src/app/services/pedido.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'NGF-item-cardapio',
  templateUrl: './item-cardapio.component.html',
  styleUrls: ['./item-cardapio.component.scss']
})
export class ItemCardapioComponent implements OnInit {

  @Input()
  item: ICardapio = {
    id:0,
    enderecoImg:'',
    titulo:'',
    descricao:'',
    preco:0,
  }

  /* @Output() adicionaItem = new EventEmitter<ICardapio>() */
  

  qtd:number = 1;
  constructor(private pedidoService:PedidoService) { }

  ngOnInit(): void {
   
  }

  adicionarItem(item:ICardapio){
    this.pedidoService.inserirItens(item, this.qtd);
  
  }

  incrementarQtd(){
    this.qtd = this.qtd + 1;
  }
  diminuirQtd(){
    if (this.qtd <= 1){
      this.qtd = this.qtd
    } else{
      this.qtd = this.qtd - 1;
    }
  }

  
  

}
