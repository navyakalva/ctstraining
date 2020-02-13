import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'twowaybinding';
  Name:string="Anil";
  onclick():void
  {
    console.log(this.Name);
  }
}
