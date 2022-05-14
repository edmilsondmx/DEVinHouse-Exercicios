import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'NGF-contato',
  templateUrl: './contato.component.html',
  styleUrls: ['./contato.component.scss']
})
export class ContatoComponent implements OnInit {

  constructor(private serviceTitle: Title) {
    this.serviceTitle.setTitle('NG-FOOD - Contato')
  }

  ngOnInit(): void {
  }

}
