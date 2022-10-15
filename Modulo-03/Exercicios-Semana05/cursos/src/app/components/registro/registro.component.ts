import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

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
    nome: this.formBuilder.control('', [Validators.required, Validators.minLength(3), Validators.pattern('^[A-Za-z]*$')]),
    cargaHoraria: this.formBuilder.control('', [Validators.required, Validators.min(30), Validators.max(100)]),
    escola: this.formBuilder.control('SENAI/SC - Serviço Nacional de Aprendizagem Industrial', [Validators.required, Validators.minLength(3), Validators.pattern('^[@!#$%-^&*A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ/s ]*$')]),
    professor: this.formBuilder.control('', [Validators.required]),
    materia: this.formBuilder.control('', [Validators.required]),
  })

  showForm(){
    console.log(this.formRegister);
    
  }
  resetForm(){
    this.formRegister.reset();
  }

}
