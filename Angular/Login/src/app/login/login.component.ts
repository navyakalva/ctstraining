import { Component, OnInit } from '@angular/core';
import{Userlogin} from 'src/app/Models/Userlogin';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  
  item:Userlogin
  constructor() { 
    this.item=new Userlogin();
  }

  ngOnInit() {
  }
  public Login()
  {
     
     if(this.item.uname=="Admin"&&this.item.pwd==12345)
     {
       console.log("successfull")
     }
     else{
       console.log("Invalid")
     }

  }

}
