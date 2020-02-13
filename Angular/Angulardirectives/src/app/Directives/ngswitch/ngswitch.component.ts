import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ngswitch',
  templateUrl: './ngswitch.component.html',
  styleUrls: ['./ngswitch.component.css']
})
export class NgswitchComponent implements OnInit {
items:any[]=[
  {name:'one',val:1},
  {name:'two',val:2},
  {name:'three',val:3},
];
selectedvalue:string="three";
  constructor() { }

  ngOnInit() {
  }

}
