import { Component, Inject, OnInit } from '@angular/core';
import { Aluno, Nota } from 'src/assets/exercicio10';


@Component({
  selector: 'exe-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent extends Aluno implements OnInit {
  title = 'Exercicio10-Semana09';

  media:number = 0;
  override passou: boolean = false;
  cadeira:string = "";

  ngOnInit(): void {
    let aluno1:Aluno = new Aluno();
    aluno1.nome = 'Jonas'
    aluno1.matricula = 1
    let notas:Nota[] = [
      {
        cadeira: "Geografia",
        ponto: 4,
        aluno: aluno1
      },
      {
        cadeira: "Geografia",
        ponto: 8,
        aluno: aluno1
      },
      {
        cadeira: "Geografia",
        ponto: 3,
        aluno: aluno1
      },
      {
        cadeira: "Geografia",
        ponto: 10,
        aluno: aluno1
      }
    ];

    let total = notas.reduce((soma, item) => soma + item.ponto, 0);
    this.media = total / notas.length;

    this.passou = this.aprovado(this.media)
    this.cadeira = notas[0].cadeira
    console.log(this.media)
    
  }


}
