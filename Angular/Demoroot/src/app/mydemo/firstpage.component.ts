import { Component, OnInit } from '@angular/core';

@Component({
 
  templateUrl: './firstpage.component.html',
  styleUrls: ['./firstpage.component.css']
})
export class FirstpageComponent implements OnInit {
   title:string="Firstpage"
   name:string="User"
   date:string="04/02/2020"
  constructor() { }

  ngOnInit() {
  }

}
