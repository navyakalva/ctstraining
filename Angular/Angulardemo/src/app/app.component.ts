import { Component } from '@angular/core';

@Component({
  selector: 'app-root',

  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title:string = 'Angulardemo';
  num:number=10;
  imagepath:string='assets/Images/flower.jpg';
  fname:string="Anil";
  lname:string="Kalva";
  isdisabled:boolean=false;
  mystyle:string="boldclass italicclass";
  applystyle:boolean=true;
  getname():string
  {
    this.fname=this.fname.toUpperCase()
    this.lname=this.lname.toUpperCase()
     return this.fname+" "+this.lname;
  }
}
