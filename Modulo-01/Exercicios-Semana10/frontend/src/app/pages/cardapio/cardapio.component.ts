import { Component, OnInit } from '@angular/core';
import { Title } from '@angular/platform-browser';


@Component({
  selector: 'NGF-cardapio',
  templateUrl: './cardapio.component.html',
  styleUrls: ['./cardapio.component.scss']
})
export class CardapioComponent implements OnInit {

  constructor(private titleService: Title) { 
    this.titleService.setTitle('NG-FOOD - Cardápio')
  }

  ngOnInit(): void {
  }

}
