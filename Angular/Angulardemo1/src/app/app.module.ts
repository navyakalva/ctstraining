import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DemoComponent } from './UI/demo/demo.component';
import { ViewComponent } from './UI/view/view.component';
import { ViewCustomerComponent } from './UI/view-customer/view-customer.component';
import { PropertybindingComponent } from './UI/propertybinding/propertybinding.component';
import { EventComponent } from './binding/event/event.component';
import { Ex1Component } from './binding/ex1/ex1.component';
import { Demo1Component } from './TwoWay/demo1/demo1.component';
import { EmpdemoComponent } from './binding/empdemo/empdemo.component';

@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    ViewComponent,
    ViewCustomerComponent,
    PropertybindingComponent,
    EventComponent,
    Ex1Component,
    Demo1Component,
    EmpdemoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [EmpdemoComponent]
})
export class AppModule { }
