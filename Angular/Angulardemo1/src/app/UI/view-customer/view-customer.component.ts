import { Component, OnInit } from '@angular/core';
import {Customer} from 'src/app/Models/Customer';

@Component({
  selector: 'app-view-customer',
  templateUrl: './view-customer.component.html',
  styleUrls: ['./view-customer.component.css']
})
export class ViewCustomerComponent implements OnInit {
   obj:Customer;
  constructor() { 
this.obj={Cname:'Nav',Email:'navi@cts',Mobile:987654321,City:'tnl',Address:'chennai'};
  }

  ngOnInit() {
  }

}
