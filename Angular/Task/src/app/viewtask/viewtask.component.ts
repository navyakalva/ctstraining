import { Component, OnInit } from '@angular/core';
import { Task } from '../Models/task';
import { Router } from '@angular/router';

@Component({
  selector: 'app-viewtask',
  templateUrl: './viewtask.component.html',
  styleUrls: ['./viewtask.component.css']
})
export class ViewtaskComponent implements OnInit {

    list:Task[]=[];
  constructor(private route:Router) {
    if(localStorage.getItem("listdata"))
    {
      this.list=JSON.parse(localStorage.getItem("listdata"));
    }
  }
      
   ngOnInit() {
  }
  

}
