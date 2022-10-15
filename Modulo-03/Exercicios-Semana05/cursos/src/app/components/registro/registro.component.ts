import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-registro',
  templateUrl: './registro.component.html',
  styleUrls: ['./registro.component.css']
})
export class RegistroComponent implements OnInit {

  constructor(private formBuilder:FormBuilder) { }

  ngOnInit(): void {
  }

  formRegister = this.formBuilder.group({
    nome: this.formBuilder.control(''),
    cargaHoraria: this.formBuilder.control(''),
    escola: this.formBuilder.control('SENAI/SC - Serviço Nacional de Aprendizagem Industrial'),
    professor: this.formBuilder.control(''),
    materia: this.formBuilder.control(''),
  })

  showForm(){
    console.log(this.formRegister)
  }

}
