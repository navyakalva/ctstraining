import { Component, OnInit } from '@angular/core';
import{FormBuilder,FormGroup,Validators} from '@angular/forms';
import{User} from '../user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginform:FormGroup;
  submit=false;
  item:User;
  constructor(private frombuilder:FormBuilder)
   {
     this.item=new User();
    }

  ngOnInit()
   {
      this.loginform=this.frombuilder.group({
        uname:['',Validators.required],
        pwd:['',Validators.required]
      });
  }
  onSubmit()
  {
    this.submit=true;
    if(this.loginform.invalid)
    {
      return;
      
    }
    else
    {
       alert("form is validated");
       console.log(this.loginform.value)//return js object
       console.log(JSON.stringify(this.loginform.value))//return json object
       console.log(this.loginform.value["uname"]);
       console.log(this.loginform.value["pwd"]);
       //assign values to model
       this.item.uname=this.loginform.value["uname"];
       this.item.pwd=this.loginform.value["pwd"];
       console.log(this.item)
      
    }
  }
  get f() {return this.loginform.controls;}
  onReset()
  {
    this.submit=false;
    this.loginform.reset();
  }

}
