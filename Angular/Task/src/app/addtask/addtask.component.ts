import { Component, OnInit } from '@angular/core';
import { Task } from '../Models/task';

@Component({
  selector: 'app-addtask',
  templateUrl: './addtask.component.html',
  styleUrls: ['./addtask.component.css']
})
export class AddtaskComponent implements OnInit {
  list:Task[]=[];
item:Task;
name:string;
priority:number;
startdate:Date;
enddate:Date;
  constructor() { 
     this.item=new Task();
     this.list=[{name:'aa',priority:2,startdate:new Date(2020,2,13),enddate:new Date(2020,4,21)}];
     
  }

  ngOnInit() {
  }
public Add()
{
     this.item.name=this.name;
     this.item.priority=this.priority;
     this.item.startdate=this.startdate;
     this.item.enddate=this.enddate;
     if(localStorage.getItem("t2"))
     {
       this.list=JSON.parse(localStorage.getItem("t2"));
     }
     this.list.push(this.item);
     localStorage.setItem("listdata",JSON.stringify(this.list));
     
}
public reset()
  {
    localStorage.clear()
  }
}