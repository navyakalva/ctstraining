import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-propertybinding',
  templateUrl: './propertybinding.component.html',
  styleUrls: ['./propertybinding.component.css']
})
export class PropertybindingComponent implements OnInit {
obj:Student;
  constructor() {
    this.obj=new Student();
    this.obj.Sname='Nav';
    this.obj.Sid=1;
    this.obj.Std='II';
    this.obj.Age=12;
    this.obj.Dob=new Date(20,2,4)
   }

  ngOnInit() {
  }

}
