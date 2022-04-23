import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { MainComponent } from './components/main/main.component';
import { HomeComponent } from './pages/home/home.component';
import { ListaItemComponent } from './components/lista-item/lista-item.component';
import { ComidasComponent } from './pages/comidas/comidas.component';
import { BebidasComponent } from './pages/bebidas/bebidas.component';
import { CardsComponent } from './components/cards/cards.component';
import { CardBebidasComponent } from './components/card-bebidas/card-bebidas.component';
import { RouterModule, Route } from '@angular/router';
import { ContatoComponent } from './pages/contato/contato.component';
import { HttpClientModule } from '@angular/common/http';
import { CardapioComponent } from './pages/cardapio/cardapio.component';

const ROUTES: Route[] = [
  {
    path: '',
    component:HomeComponent
  },
  {
    path: 'cardapio',
    component:CardapioComponent
  },
  {
    path: 'comidas',
    component:ComidasComponent
  },
  {
    path: 'bebidas',
    component:BebidasComponent
  },
  {
    path: 'contato',
    component:ContatoComponent
  }
]

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    MainComponent,
    HomeComponent,
    ListaItemComponent,
    ComidasComponent,
    BebidasComponent,
    CardsComponent,
    CardBebidasComponent,
    ContatoComponent,
    CardapioComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(ROUTES),
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
