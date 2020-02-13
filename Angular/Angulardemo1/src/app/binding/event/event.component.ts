import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-event',
  templateUrl: './event.component.html',
  styleUrls: ['./event.component.css']
})
export class EventComponent implements OnInit {
   name:string;
  constructor() { }

  ngOnInit() {
  }
  public setName()
  {
    this.name="abc";
  }
  public Greet(val:string)
  {
    this.name=val;
  }

}
