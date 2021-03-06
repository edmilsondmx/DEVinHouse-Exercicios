import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';
import { ICardapio } from 'src/app/models/interface';
import { ComidaService } from 'src/app/services/comida.service';

@Component({
  selector: 'NGF-comidas',
  templateUrl: './comidas.component.html',
  styleUrls: ['./comidas.component.scss']
})
export class ComidasComponent implements OnInit {

  lanches: ICardapio[] = [] /* COMIDAS_MOCK */;

  termo:string = "";

  constructor(
    private comidaService:ComidaService,
    private titeService:Title 
    ) 
    { 
      this.titeService.setTitle('NG-FOOD - Lanches')
    }

  ngOnInit(): void {
    this.buscarComida()
  }

  buscarComida(){
    this.comidaService.devolverComida()
    .subscribe((resultado) => {
      this.lanches = resultado;
    });
  }

  filtrarTermo(){
    if(this.termo.trim()){
      let pesquisa = this.lanches.filter((item) => item.descricao.toLowerCase().includes(this.termo) || item.titulo.toLowerCase().includes(this.termo))
      this.lanches = pesquisa;
      
    } else{
      this.buscarComida();
    }
  }
  

}
