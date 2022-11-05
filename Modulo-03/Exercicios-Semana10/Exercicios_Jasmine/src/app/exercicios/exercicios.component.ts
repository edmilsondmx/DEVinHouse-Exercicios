import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-exercicios',
  templateUrl: './exercicios.component.html',
  styleUrls: ['./exercicios.component.scss']
})
export class ExerciciosComponent implements OnInit {

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

}
