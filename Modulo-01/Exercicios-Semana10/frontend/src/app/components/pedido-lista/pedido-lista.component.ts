import { Component, OnInit } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { ICardapio } from 'src/app/models/interface';
import { PedidoService } from 'src/app/services/pedido.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'NGF-pedido-lista',
  templateUrl: './pedido-lista.component.html',
  styleUrls: ['./pedido-lista.component.scss']
})
export class PedidoListaComponent implements OnInit {

  listaPedido:ICardapio[] = []


  constructor(
    private pedidoService:PedidoService,
    private router:Router) { }

  ngOnInit(): void {
    this.listaPedido = this.pedidoService.buscarItensPedido()
  }

  removerItemLista(id:number){
    this.pedidoService.removerItemLista(id);
  }
  limparLista(){
    this.pedidoService.limparLista();
    this.listaPedido = this.pedidoService.buscarItensPedido()
  }
  valorTotal(){
    const vTotal = this.pedidoService.listaItem.reduce((soma, item) => soma + item.preco, 0);
    return vTotal.toFixed(2).replace('.',',')
  }


  finalizarPedido(){
    Swal.fire({
      title: 'Pedido Confirmado!',
      text: `Valor Total do Pedido: R$ ${this.valorTotal()}`,
      icon: 'success',
      showCancelButton: false,
      confirmButtonColor: '#007e08',
      confirmButtonText: 'OK',
    }).then((result) => {
      if (result.isConfirmed) {
        this.router.navigate(['']);
        this.limparLista()
        Swal.fire({
          title: 'Seu pedido está sendo Preparado!',
          text: "Te avisaremos assim que estiver pronto.",
          width: 400,
          padding: '3em',
          color: '#007e08',
          background: '#fff',
          backdrop: `
            rgba(0, 0, 0, 0.4)
            url("https://i.pinimg.com/originals/b0/20/f9/b020f9f4e1903aa2ee3a25b8f65f46c9.gif")
            left
            no-repeat
          `
        })

      }
    })
  }

  deletarPedido(){
    Swal.fire({
      title: 'Tem Certeza?',
      text: "Isso irá esvaziar seu carrinho!",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#d33',
      cancelButtonColor: '#007e08',
      confirmButtonText: 'Sim, Limpar Pedido!',
      cancelButtonText: 'Cancelar'
    }).then((result) => {
      if (result.isConfirmed) {
        this.router.navigate(['cardapio']);
        this.limparLista();
        Swal.fire(
          'Itens excluídos',
          'Seu Carrinho está vazio!',
          'success'
        )
      }
    })
  }


}
