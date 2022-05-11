import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'exe-exercicio03',
  templateUrl: './exercicio03.component.html',
  styleUrls: ['./exercicio03.component.scss']
})
export class Exercicio03Component implements OnInit {

  arrayList:string[] = [
    'Os Vingadores',
    'Dragon Ball Super',
    'O Auto da Compadecida',
    'As Branquelas',
    'Intocáveis'
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
