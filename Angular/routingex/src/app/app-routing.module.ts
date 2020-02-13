import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { BuyerComponent } from './buyer/buyer.component';
import { SellerComponent } from './seller/seller.component';
import { AdminComponent } from './admin/admin.component';
import { BuyitemComponent } from './buyer/buyitem/buyitem.component';
import { ViewcartComponent } from './buyer/viewcart/viewcart.component';
import { PaymentComponent } from './buyer/payment/payment.component';
import { AdditemComponent } from './seller/additem/additem.component';
import { ViewitemComponent } from './seller/viewitem/viewitem.component';
import { AddCategoryComponent } from './admin/add-category/add-category.component';
import { AddRemovebuyerComponent } from './admin/add-removebuyer/add-removebuyer.component';
import { AddRemovesellerComponent } from './admin/add-removeseller/add-removeseller.component';


const routes: Routes = [
  {path:'login',component:LoginComponent},
  {path:'buyer',component:BuyerComponent,children:[
    {path:'buyitem',component:BuyitemComponent},
    {path:'viewcart',component:ViewcartComponent},
    {path:'payment',component:PaymentComponent},
  ]},
  {path:'seller',component:SellerComponent,children:[
    {path:'additem',component:AdditemComponent},
    {path:'viewitem',component:ViewitemComponent},
  ]},
  {path:'admin',component:AdminComponent,children:[
    {path:'add-category',component:AddCategoryComponent},
    {path:'add-removebuyer',component:AddRemovebuyerComponent},
    {path:'add-removeseller',component:AddRemovesellerComponent},
  ]},
  {path:'',redirectTo:'login',pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
