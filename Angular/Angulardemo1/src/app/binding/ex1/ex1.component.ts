import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ex1',
  templateUrl: './ex1.component.html',
  styleUrls: ['./ex1.component.css']
})
export class Ex1Component implements OnInit {
  num1:number;
  num2:number;
  
  constructor() { 
    
  }

  ngOnInit() {
  }
  public add(val1:number,val2:number)
  {
    
    this.num1=Number(val1)+Number(val2);
    
  }
  public sub(val1:number,val2:number)
  {
    this.num2=Number(val1)-Number(val2);
  }

}
