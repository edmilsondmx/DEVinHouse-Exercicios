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
]

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    Exercicio01Component,
    Exercicio02Component,
    HomeComponent,
    Exercicio03Component,
    Exercicio04Component
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(ROUTES)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
