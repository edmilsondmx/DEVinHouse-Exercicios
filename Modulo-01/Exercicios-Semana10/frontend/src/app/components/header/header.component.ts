import { Component, OnInit } from '@angular/core';
import { PedidoService } from 'src/app/services/pedido.service';

@Component({
  selector: 'NGF-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  qtdItensPedido:number = 0;

  constructor(private pedidoService: PedidoService) {}

  ngOnInit(): void {
   
  }

  buscaTotalItem(){
    return this.pedidoService.totalItens()
  }
  


}
