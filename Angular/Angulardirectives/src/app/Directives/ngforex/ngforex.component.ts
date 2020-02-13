import { Component, OnInit } from '@angular/core';
import { Ex } from 'src/app/Models/ex';

@Component({
  selector: 'app-ngforex',
  templateUrl: './ngforex.component.html',
  styleUrls: ['./ngforex.component.css']
})
export class NgforexComponent implements OnInit {
item:Ex
list:Ex[]=[]
pid:number;
pname:string;
domain:string;
startdate:Date;
enddate:Date;
domains:string[]=["Java",".Net","Testing"];


  constructor() 
  { 

  }

  ngOnInit() {
  }
  public Add()
  {
    this.item=new Ex();
    this.item.pid=this.pid;
    this.item.pname=this.pname;
    this.item.domain=this.domain;
    this.item.startdate=this.startdate;
    this.item.enddate=this.enddate;
    this.list.push(this.item)
  }

}
