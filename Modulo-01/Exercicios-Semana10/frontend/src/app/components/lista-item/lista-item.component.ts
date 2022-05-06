import { Component, OnInit } from '@angular/core';
import { MENU_MOCK } from 'src/app/mocks/menu_mock';
import { IMenu } from 'src/app/models/interface';

@Component({
  selector: 'NGF-lista-item',
  templateUrl: './lista-item.component.html',
  styleUrls: ['./lista-item.component.scss']
})
export class ListaItemComponent {

  listaMenu:IMenu[] = MENU_MOCK;

  constructor() { }

  

}
