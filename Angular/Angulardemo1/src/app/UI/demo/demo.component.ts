import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
name:string="Anil";
class:string="It";
age:number=12;
  constructor() { }

  ngOnInit() {
  }

}
