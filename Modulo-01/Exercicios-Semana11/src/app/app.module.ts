import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { Exercicio01Component } from './components/exercicio01/exercicio01.component';
import { Exercicio02Component } from './components/exercicio02/exercicio02.component';
import { Route, RouterModule } from '@angular/router';

const ROUTES:Route[] = [
  {
    path: 'exercicio01',
    component:Exercicio01Component
  },
  {
    path: 'exercicio02',
    component:Exercicio02Component
  },
]

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    Exercicio01Component,
    Exercicio02Component
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(ROUTES)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
