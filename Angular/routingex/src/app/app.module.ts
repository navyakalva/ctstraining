import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import{FormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
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

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    BuyerComponent,
    SellerComponent,
    AdminComponent,
    BuyitemComponent,
    ViewcartComponent,
    PaymentComponent,
    AdditemComponent,
    ViewitemComponent,
    AddCategoryComponent,
    AddRemovebuyerComponent,
    AddRemovesellerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
