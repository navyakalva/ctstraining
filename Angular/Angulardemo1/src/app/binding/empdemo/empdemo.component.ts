import { Component, OnInit } from '@angular/core';
import{Employ} from 'src/app/Models/Employ';
@Component({
  selector: 'app-empdemo',
  templateUrl: './empdemo.component.html',
  styleUrls: ['./empdemo.component.css']
})
export class EmpdemoComponent implements OnInit {
 item:Employ
  constructor() { 
    this.item=new Employ();
  }

  ngOnInit() {
  }
  public Add()
  {
   
    console.log(this.item)
  }

}
