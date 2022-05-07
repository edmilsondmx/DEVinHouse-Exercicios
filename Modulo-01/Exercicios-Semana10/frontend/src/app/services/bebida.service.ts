import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ICardapio } from '../models/interface';

@Injectable({
  providedIn: 'root'
})
export class BebidaService {

  constructor(private http: HttpClient) { }

  devolverBebida():Observable<ICardapio[]>{
    return this.http.get<ICardapio[]>('http://localhost:3000/bebidas')
  }
}
