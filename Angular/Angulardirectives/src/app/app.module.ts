import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgifComponent } from './Directives/ngif/ngif.component';
import { NgforComponent } from './Directives/ngfor/ngfor.component';
import { NgforstudentComponent } from './Directives/ngforstudent/ngforstudent.component';
import{FormsModule} from '@angular/forms';
import { NgforexComponent } from './Directives/ngforex/ngforex.component';
import { NgswitchComponent } from './Directives/ngswitch/ngswitch.component';

@NgModule({
  declarations: [
    AppComponent,
    NgifComponent,
    NgforComponent,
    NgforstudentComponent,
    NgforexComponent,
    NgswitchComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [NgforstudentComponent]
})
export class AppModule { }
