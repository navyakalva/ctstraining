import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'my-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent 
{
  firstname:string="NAVYA";
  lastname:string="KALVA";
  email:string="navi@cts.com";
  age:number=21;
  getStyle()
  {
    let styles={"font-style":"italic","color":"brown"};
    return styles;
  }

}

