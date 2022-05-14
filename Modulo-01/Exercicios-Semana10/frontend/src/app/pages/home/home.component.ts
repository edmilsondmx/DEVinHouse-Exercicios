import { Component } from '@angular/core';
import { Title } from '@angular/platform-browser';

@Component({
  selector: 'NGF-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent{

  constructor(private serviceTitle: Title) { 
    this.serviceTitle.setTitle('NG-FOOD - Home')
  }


}
