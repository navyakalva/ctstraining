import { Component, OnInit } from '@angular/core';
import {Student} from 'src/app/Models/student';
@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
  obj:Student
  constructor() { 
    this.obj={Sid:1,Sname:'Anil',Dob:new Date(93,7,13),Age:21,Std:'II'};
    
  }

  ngOnInit() {
  }

}
