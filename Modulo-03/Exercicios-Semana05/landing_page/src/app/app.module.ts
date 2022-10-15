import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { HomeComponent } from './components/home/home.component';
import { SobreComponent } from './components/sobre/sobre.component';
import { HabilidadesComponent } from './components/habilidades/habilidades.component';
import { ProjetosComponent } from './components/projetos/projetos.component';
import { CarreiraComponent } from './components/carreira/carreira.component';
import { FeedbackComponent } from './components/feedback/feedback.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    HomeComponent,
    SobreComponent,
    HabilidadesComponent,
    ProjetosComponent,
    CarreiraComponent,
    FeedbackComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
