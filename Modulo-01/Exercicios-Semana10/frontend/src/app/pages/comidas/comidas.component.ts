import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { COMIDAS_MOCK } from 'src/app/mocks/comidas_mock';
import { ICardapio } from 'src/app/models/interface';
import { ComidaService } from 'src/app/services/comida.service';
import { PedidoService } from 'src/app/services/pedido.service';

@Component({
  selector: 'NGF-comidas',
  templateUrl: './comidas.component.html',
  styleUrls: ['./comidas.component.scss']
})
export class ComidasComponent implements OnInit {

  lanches: ICardapio[] = [] /* COMIDAS_MOCK */;

  lanche:string = "";

  constructor(private comidaService:ComidaService) { }

  ngOnInit(): void {
    this.buscarComida()

  }

  buscarComida(){
    this.comidaService.devolverComida()
    .subscribe((resultado) => {
      this.lanches = resultado;
    });
  }
  

}
