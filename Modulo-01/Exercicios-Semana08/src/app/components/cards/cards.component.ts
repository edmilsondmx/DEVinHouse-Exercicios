import { Component } from '@angular/core';
import { COMIDAS_MOCK } from 'src/app/mocks/comidas_mock';

@Component({
  selector: 'NGF-cards',
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.scss']
})
export class CardsComponent  {

  constructor() { }

  lanches = COMIDAS_MOCK;


}
