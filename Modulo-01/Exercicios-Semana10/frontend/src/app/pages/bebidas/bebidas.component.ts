import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { BEBIDAS_MOCK } from 'src/app/mocks/bebidas_mock';
import { ICardapio } from 'src/app/models/interface';
import { BebidaService } from 'src/app/services/bebida.service';

@Component({
  selector: 'NGF-bebidas',
  templateUrl: './bebidas.component.html',
  styleUrls: ['./bebidas.component.scss']
})
export class BebidasComponent implements OnInit {

  bebidas: ICardapio[] = [] /* BEBIDAS_MOCK */;

  constructor(private bebidaService:BebidaService) { }

  ngOnInit(): void {
    this.buscarBebida()

  }

  buscarBebida(){
    this.bebidaService.devolverBebida()
    .subscribe((resultado: ICardapio[]) => {
      this.bebidas = resultado;
    });
  }


}
