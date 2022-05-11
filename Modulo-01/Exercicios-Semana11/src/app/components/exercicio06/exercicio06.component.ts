import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'exe-exercicio06',
  templateUrl: './exercicio06.component.html',
  styleUrls: ['./exercicio06.component.scss']
})
export class Exercicio06Component implements OnInit {

  click:boolean = false

  usuario:string = "";
  cpf:number = 0;
  diaAniversario:number = 0;
  senha:string = "";

  constructor() { }

  ngOnInit(): void {
    
  }

  cadastrar(){
    if(this.usuario && this.cpf && this.diaAniversario && this.senha){
      this.click = true;
    }

  }

}
