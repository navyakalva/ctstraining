import { Component, OnInit } from '@angular/core';
import { FormBuilder,FormGroup,Validators,} from '@angular/forms';


@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  productform:FormGroup;
  submit=false;
    constructor(private frombuilder:FormBuilder) { }
 

  ngOnInit() {
    this.productform=this.frombuilder.group({
      prodid:['',Validators.required],
      prodname:['',Validators.required],
      price:['',Validators.required],
      stock:['',Validators.required],

    });
  }
  onSubmit()
  {
    this.submit=true;
    if(this.productform.invalid)
    {
      return;
      //console.log(this.loginform.value["uname"])
      //console.log(this.loginform.value["pwd"])
      //this.item.uname=this.loginform.value=["uname"]
    }
    else
    {
       alert("form is validated");
       //console.log(this.loginform.value["uname"]);
       //console.log(this.loginform.value["pwd"]);
    }
  }
  get f() {return this.productform.controls;}
  onReset()
  {
    this.submit=false;
    this.productform.reset();
  }


}
