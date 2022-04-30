import { Component, OnInit } from '@angular/core';
import { Produto } from 'src/assets/exercicio09';

@Component({
  selector: 'exe-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit, Produto {

  title = 'Exercicio09-semana09';

  valorTotal:number = 0;

  nome: string = '';
  valor: number = 0;
  codigo: number = 0;
  quantidade: number = 0;
  emEstoque: boolean = true;

  sofa:Produto = {
    nome: "Sofá 4 lugares",
    valor: 120,
    codigo: 1,
    quantidade: 30,
    emEstoque: true
  };

  ngOnInit(): void {
    this.comprar(this.sofa, 30);
    this.comprar(this.sofa, 10);
  }

  comprar(produto:Produto, quantidade:number){
    if(produto.emEstoque){
      this.valorTotal = produto.valor * quantidade;

      produto.quantidade -= quantidade;
      console.log(produto.quantidade);
      if(!produto.quantidade){
        produto.emEstoque = false;
      }
      console.log(produto.emEstoque);
    } else {
      alert('Produto sem estouqe!!');
    }

  };

}
