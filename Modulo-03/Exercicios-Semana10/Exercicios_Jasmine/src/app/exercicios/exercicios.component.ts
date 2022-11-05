import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-exercicios',
  templateUrl: './exercicios.component.html',
  styleUrls: ['./exercicios.component.scss']
})
export class ExerciciosComponent implements OnInit {

  linguagens:string[] = ['javascript', 'csharp', 'java', 'python', 'php', 'node.js']
  constructor() { }

  ngOnInit(): void {
  }

  returnAluno(value:string):string{
    let aluno = value;
    return aluno;
  }

  exibirEmail(value:string):string{
    return value;
  }

  returNull(){
    return;
  }

  soma(n1:number, n2:number):number{
    return n1+n2;
  }

  testeExemplo():boolean{
    let n1 = 1;
    if(n1 > 5)
      return true;
    return false;    
  }

  private exibirCpf(){
    return '111.222.333-44'
  }

  testeCpf():void{
    this.exibirCpf();
  }

}
