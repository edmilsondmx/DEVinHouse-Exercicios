import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { Exercicio01Component } from './components/exercicio01/exercicio01.component';
import { Exercicio02Component } from './components/exercicio02/exercicio02.component';
import { Route, RouterModule } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { Exercicio03Component } from './components/exercicio03/exercicio03.component';
import { Exercicio04Component } from './components/exercicio04/exercicio04.component';
import { Exercicio05Component } from './components/exercicio05/exercicio05.component';
import { Exercicio06Component } from './components/exercicio06/exercicio06.component';
import { FormsModule } from '@angular/forms';
import { Exercicio07Component } from './components/exercicio07/exercicio07.component';
import { Exercicio08Component } from './components/exercicio08/exercicio08.component';

const ROUTES:Route[] = [
  {
    path: '',
    component:HomeComponent
  },
  {
    path: 'exercicio01',
    component:Exercicio01Component
  },
  {
    path: 'exercicio02',
    component:Exercicio02Component
  },
  {
    path: 'exercicio03',
    component:Exercicio03Component
  },
  {
    path: 'exercicio04',
    component:Exercicio04Component
  },
  {
    path: 'exercicio05',
    component:Exercicio05Component
  },
  {
    path: 'exercicio06',
    component:Exercicio06Component
  },
  {
    path: 'exercicio07',
    component:Exercicio07Component
  },
  {
    path: 'exercicio08',
    component:Exercicio08Component
  },
]

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    Exercicio01Component,
    Exercicio02Component,
    HomeComponent,
    Exercicio03Component,
    Exercicio04Component,
    Exercicio05Component,
    Exercicio06Component,
    Exercicio07Component,
    Exercicio08Component
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(ROUTES)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
