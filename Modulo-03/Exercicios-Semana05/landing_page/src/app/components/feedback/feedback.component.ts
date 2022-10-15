import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'pro-feedback',
  templateUrl: './feedback.component.html',
  styleUrls: ['./feedback.component.scss']
})
export class FeedbackComponent implements OnInit {

  constructor(private formBuilder:FormBuilder) { }

  formFeedBack = this.formBuilder.group({
    email: this.formBuilder.control('', [Validators.required, Validators.email]),
    nome: this.formBuilder.control('', [Validators.required, Validators.minLength(3), Validators.pattern('^[A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ]*$')]),
    sobrenome: this.formBuilder.control('', [Validators.required, Validators.minLength(3)]),
    mensagem: this.formBuilder.control('', [Validators.required, Validators.minLength(3)]),

  })

  ngOnInit(): void {
  }
  spinner:boolean = false;

  showForm(){
    this.spinner = true;
    console.log(this.formFeedBack);
    setTimeout(() => {
      this.formFeedBack.reset();
      this.spinner = false;
    }, 500);
  }

}
