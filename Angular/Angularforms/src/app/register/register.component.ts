import { Component, OnInit } from '@angular/core';
import{FormBuilder,FormGroup,Validators} from '@angular/forms';
@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
registerform:FormGroup;
submitted=false;
  constructor(private formbuilder:FormBuilder) 
  { }

  ngOnInit() 
  {
    this.registerform=this.formbuilder.group({
      title:['',Validators.required],
      firstname:['',[Validators.required,Validators.pattern('^[a-z]{3,6}$')]],
      lastname:['',Validators.required],
      mobile:['',[Validators.required,
              Validators.pattern("^[6-9][0-9]{9}$")]],
      email:['',[Validators.required,Validators.email]],
      password:['',[Validators.required,Validators.minLength(6)]],
      acceptTerms:[false,Validators.requiredTrue]

    })
  }
  get f(){return this.registerform.controls;}
  onSubmit()
  {
    this.submitted= true;
    //display form value on success
    if(this.registerform.valid)
    {
      alert("Success")
      console.log(JSON.stringify(this.registerform.value));
    }

  }
  onReset()
  {
    this.submitted=false;
    this.registerform.reset();
  }

}
