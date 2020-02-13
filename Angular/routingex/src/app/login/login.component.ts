import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  uname:string;
  pwd:string;
  errmsg:string;
  constructor(private route:Router) {

   }

  ngOnInit() {
  }
  public validate()
  {
    if(this.uname=="admin" && this.pwd=="12345")
    {
      //set value in session
      sessionStorage.setItem("ad",this.uname)
      this.route.navigateByUrl('admin')
    }
    else
    {
      this.errmsg="invalid details";
    }
    if(this.uname=="buyer" && this.pwd=="12345")
    {
      //set value in session
      sessionStorage.setItem("bu",this.uname)
      this.route.navigateByUrl('buyer')
    }
    else
    {
      this.errmsg="invalid details";
    }
    if(this.uname=="seller" && this.pwd=="12345")
    {
      //set value in session
      sessionStorage.setItem("se",this.uname)
      this.route.navigateByUrl('seller')
    }
    else
    {
      this.errmsg="invalid details";
    }
  }

}
