import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angularex2';
  customer:any[]=[{"name":'Mani',"country":'India',"age":19},{"name":'Anil',"country":'India',"age":25},
                  {"name":'Navya',"country":'USA',"age":21}];
  StudentbyCountry:any[]=[
    { "country":"India", "student":[{"name":'Mani',"age":19},{"name":'Anil',"age":25}] },
    { "country":"USA", "student":[{"name":'Tom',"age":19},{"name":'Jerry',"age":25}]   },
  ];
}
