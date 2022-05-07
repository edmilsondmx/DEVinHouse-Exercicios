import { Injectable } from '@angular/core';
import { ICardapio } from '../models/interface';
import Swal from 'sweetalert2';

@Injectable({
  providedIn: 'root'
})
export class PedidoService {

  listaItem:ICardapio[] = [];

  valorTotal:number = 0
  
  constructor() { }

  

  totalItens():number{
    return this.listaItem.length
  }


  inserirItens(item:ICardapio, qtd:number){
    if(qtd <= 0){
      this.alertaQuantidade()
    } else{
      const itens = Array(qtd).fill(item);
      this.listaItem.push(...itens)
      this.alertaItemAdicionado()
    }

  }

  limparLista(){
    this.listaItem = [];
  }

  removerItemLista(id:number){
    const itemIndex = this.listaItem.findIndex((item) => item.id === id);
    this.listaItem.splice(itemIndex, 1)
  }

  buscarItensPedido():ICardapio[]{
    return this.listaItem;
  }

  alertaItemAdicionado(){
    Swal.fire({
      position: 'top',
      text: '✔️ Item adicionado ao pedido',
      width: 350,
      color: '#007e08',
      background: '#bfffc4',
      showConfirmButton: false,
      timer: 700
    })
  }
  alertaQuantidade(){
    Swal.fire({
      position: 'top',
      text: '❌ Informe a quantidade!',
      width: 350,
      color: '#ff0000',
      background: '#ffcaca',
      showConfirmButton: false,
      timer: 700
    })
  }


}
