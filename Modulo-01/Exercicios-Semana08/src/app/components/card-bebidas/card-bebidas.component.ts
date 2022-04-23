import { Component, OnInit } from '@angular/core';
import { BEBIDAS_MOCK } from 'src/app/mocks/bebidas_mock';

@Component({
  selector: 'NGF-card-bebidas',
  templateUrl: './card-bebidas.component.html',
  styleUrls: ['./card-bebidas.component.scss']
})
export class CardBebidasComponent  {

  constructor() { }

  bebidas = BEBIDAS_MOCK;
}
