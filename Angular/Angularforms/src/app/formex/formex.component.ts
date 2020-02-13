import { Component, OnInit } from '@angular/core';
import{FormBuilder,FormGroup,Validators} from '@angular/forms';
import { Formclassex } from '../formclassex';
@Component({
  selector: 'app-formex',
  templateUrl: './formex.component.html',
  styleUrls: ['./formex.component.css']
})
export class FormexComponent implements OnInit {
  empform:FormGroup;
  submitted=false;
  id:string;
  name:string;
  joindate:Date;
  designation:string;
  mobile:number;
  mail:string;
  password:string;
  list:Formclassex[]=[];
  item:Formclassex;
 
  constructor(private formbuilder:FormBuilder)
   { 
    this.item=new Formclassex();
   }

  ngOnInit() 
  {
    this.empform=this.formbuilder.group({
      id:['',[Validators.required,Validators.pattern("^[E][0-9]{4}$")]],
      name:['',[Validators.required,Validators.pattern("^[A-Z]{5,10}$")]],
      joindate:['',Validators.required],
      designation:['',Validators.required],
      mobile:['',[Validators.required,
              Validators.pattern("^[6-9][0-9]{9}$")]],
      mail:['',[Validators.required,Validators.email]],
      password:['',[Validators.required,Validators.pattern("^[A-Z]{7}[@,#,$,%,&,*]$")]],
    })
  }
  get f(){return this.empform.controls;}
  onSubmit()
  {
    this.submitted= true;
    //display form value on success
    if(this.empform.valid)
    {
      alert("Success")
      console.log(JSON.stringify(this.empform.value));
      this.item.id=this.empform.value["id"];
      this.item.name=this.empform.value["name"];
      this.item.joindate=this.empform.value["joindate"];
      this.item.designation=this.empform.value["designation"];
      this.item.mobile=this.empform.value["mobile"];
      this.item.mail=this.empform.value["mail"];
      this.item.password=this.empform.value["password"];
      this.list.push(this.item);
      console.log(this.item);
    }

  }
 


}
