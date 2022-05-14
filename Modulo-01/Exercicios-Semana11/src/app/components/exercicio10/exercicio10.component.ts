import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'exe-exercicio10',
  templateUrl: './exercicio10.component.html',
  styleUrls: ['./exercicio10.component.scss']
})
export class Exercicio10Component implements OnInit {

  newUser:boolean = false;
  edicao:boolean = false;

  users:any = [
    {
      firstName:"Edmilson",
      lastName:"Gomes"
    },
    {
      firstName:"Cristiano",
      lastName:"Ronaldo"
    },
    {
      firstName:"Leonel",
      lastName:"Messi"
    },
    {
      firstName:"Erling",
      lastName:"Haaland"
    },
  ]


  firstName: string = '';
  lastName: string = '';

  first: string = '';
  last: string = '';
  index:number = 0

 


  constructor() { }

  ngOnInit(): void {
  }

  salvar(){
    this.users.push({firstName:this.firstName, lastName:this.lastName});
    this.newUser = false;
  }

  remover(index:number){
    this.users.splice(index, 1);
  }

  btnNewUser(){
    this.newUser = true;
  }

  editar(index:number){
    this.edicao = true;
    this.first = this.users[index].firstName
    this.last = this.users[index].lastName
    this.index = index
  }

  salvarEdit(){
    this.users[this.index].firstName = this.first
    this.users[this.index].lastName = this.last
    this.edicao = false;
  }

}
