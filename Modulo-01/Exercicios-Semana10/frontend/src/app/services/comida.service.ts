import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICardapio } from '../models/interface';

@Injectable({
  providedIn: 'root'
})
export class ComidaService {

  constructor(private http: HttpClient) { }

  devolverComida():Observable<ICardapio[]>{
    return this.http.get<ICardapio[]>('http://localhost:3000/comidas')
  }
}
