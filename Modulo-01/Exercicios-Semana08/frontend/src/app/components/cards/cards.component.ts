import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { COMIDAS_MOCK } from 'src/app/mocks/comidas_mock';
import { ICardapio } from 'src/app/models/interface';

@Component({
  selector: 'NGF-cards',
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.scss']
})
export class CardsComponent implements OnInit  {

  lanches: ICardapio[] = [] /* COMIDAS_MOCK */;

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http
    .get<ICardapio[]>('http://localhost:3000/comidas')
    .subscribe((resultado) => {
      this.lanches = resultado;
    });
  }


}
