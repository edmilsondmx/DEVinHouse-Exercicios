import { Component, OnInit } from '@angular/core';
import { MOCK_EXERCICIOS } from 'src/app/mock/mock_exercicios';
import { IExercicios } from 'src/app/models/interface';

@Component({
  selector: 'exe-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  exerciciosSemana11:IExercicios[] = MOCK_EXERCICIOS;

  constructor() { }

  ngOnInit(): void {
  }

}
