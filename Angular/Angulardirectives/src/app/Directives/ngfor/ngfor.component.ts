import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-ngfor',
  templateUrl: './ngfor.component.html',
  styleUrls: ['./ngfor.component.css']
})
export class NgforComponent implements OnInit {
   no:number[]=[12,23,34,45]
   name:string[]=["aa","bb","cc","dd"]
  constructor()
  { 
    this.name.push("ee")
  }

  ngOnInit() {
  }

}
