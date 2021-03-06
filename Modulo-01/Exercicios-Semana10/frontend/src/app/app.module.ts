import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { HomeComponent } from './pages/home/home.component';
import { ListaItemComponent } from './components/lista-item/lista-item.component';
import { ComidasComponent } from './pages/comidas/comidas.component';
import { BebidasComponent } from './pages/bebidas/bebidas.component';
import { RouterModule, Route } from '@angular/router';
import { ContatoComponent } from './pages/contato/contato.component';
import { HttpClientModule } from '@angular/common/http';
import { CardapioComponent } from './pages/cardapio/cardapio.component';
import { FormsModule } from '@angular/forms';
import { ItemCardapioComponent } from './components/item-cardapio/item-cardapio.component';
import { PedidoListaComponent } from './components/pedido-lista/pedido-lista.component';

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
  },
  {
    path: 'pedido',
    component:PedidoListaComponent
  }
]

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    HomeComponent,
    ListaItemComponent,
    ComidasComponent,
    BebidasComponent,
    ContatoComponent,
    CardapioComponent,
    ItemCardapioComponent,
    PedidoListaComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(ROUTES),
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
