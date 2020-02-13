import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';
import { areAllEquivalent } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-ngforstudent',
  templateUrl: './ngforstudent.component.html',
  styleUrls: ['./ngforstudent.component.css']
})
export class NgforstudentComponent implements OnInit {
  val:boolean=true
   list:Student[]=[];
   sid:number;
   sname:string;
   std:string;
   age:number;
   item:Student;
   stds:string[]=["I","II","III","IV","V"];
  constructor() 
  { 
    this.list=[
    {sid:1,sname:'aa',std:'II',age:12},
    {sid:2,sname:'bb',std:'III',age:13},
    {sid:3,sname:'cc',std:'IV',age:14},
    {sid:4,sname:'dd',std:'V',age:15},
  ]
  }

  ngOnInit() {
  }
  public Add()
  {
    this.item=new Student();
    this.item.sid=this.sid;
    this.item.sname=this.sname;
    this.item.std=this.std;
    this.item.age=this.age;
    this.list.push(this.item);//add item to array
    console.log(this.list)
  }
  public Setval()
  {
    this.val=!this.val;
  }
}
