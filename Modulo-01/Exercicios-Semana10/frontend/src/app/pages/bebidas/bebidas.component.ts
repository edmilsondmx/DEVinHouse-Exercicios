import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ICardapio } from 'src/app/models/interface';
import { BebidaService } from 'src/app/services/bebida.service';

@Component({
  selector: 'NGF-bebidas',
  templateUrl: './bebidas.component.html',
  styleUrls: ['./bebidas.component.scss']
})
export class BebidasComponent implements OnInit {

  bebidas: ICardapio[] = [] /* BEBIDAS_MOCK */;

  termo:string = "";

  constructor(
    private bebidaService:BebidaService,
    private titleService:Title ) 
    { 
      this.titleService.setTitle('NG-FOOD - Bebidas')
    }

  ngOnInit(): void {
    this.buscarBebida()

  }

  buscarBebida(){
    this.bebidaService.devolverBebida()
    .subscribe((resultado: ICardapio[]) => {
      this.bebidas = resultado;
    });
  }

  filtrarTermo(){
    if(this.termo.trim()){
      let pesquisa = this.bebidas.filter((item) => item.descricao.toLowerCase().includes(this.termo) || item.titulo.toLowerCase().includes(this.termo))
      this.bebidas = pesquisa;
    } else {
      this.buscarBebida();
    }
  }


}
