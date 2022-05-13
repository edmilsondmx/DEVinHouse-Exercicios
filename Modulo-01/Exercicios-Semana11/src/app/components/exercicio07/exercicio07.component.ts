import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'exe-exercicio07',
  templateUrl: './exercicio07.component.html',
  styleUrls: ['./exercicio07.component.scss']
})
export class Exercicio07Component implements OnInit {

  click:boolean = false


  usuario:string = "";
  cpf:number = 0;
  diaAniversario:number = 0;
  senha:string = "";

  constructor() { }

  ngOnInit(): void {
    
  }

  cadastrar(){
    this.click = true;

  }
}
