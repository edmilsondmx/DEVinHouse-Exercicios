import { Component, OnInit } from '@angular/core';
import { IAnimal } from 'src/app/models/interface';

@Component({
  selector: 'exe-exercicio09',
  templateUrl: './exercicio09.component.html',
  styleUrls: ['./exercicio09.component.scss']
})
export class Exercicio09Component implements OnInit {

  cadastro:boolean = false

  animal:IAnimal = {
    nomeDono: "",
    cpf: '',
    email: "",
    nomeCachorro: "",
    codCachorro: 0,
  }
  

  constructor() { }

  ngOnInit(): void {
    
  }

  cadastrar(){
    this.cadastro = true;
  }


}
