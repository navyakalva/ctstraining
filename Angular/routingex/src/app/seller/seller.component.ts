import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
@Component({
  selector: 'app-seller',
  templateUrl: './seller.component.html',
  styleUrls: ['./seller.component.css']
})
export class SellerComponent implements OnInit {

  uname:string
  constructor(private route:Router) {
    if(sessionStorage.getItem("se"))
    {
    //read session storage
    this.uname=sessionStorage.getItem("se")
    console.log(this.uname)
    }
    else{
      this.route.navigateByUrl('login')
    }
   }
  ngOnInit() {
  }
  public logout()
  {
    sessionStorage.clear();
    //this.route.navigate(['login']);
    this.route.navigateByUrl('login')
  }


}
