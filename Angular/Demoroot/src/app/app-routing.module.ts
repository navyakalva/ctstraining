import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FirstpageComponent } from './mydemo/firstpage.component';
import { SecondpageComponent } from './mydemo/secondpage.component';


const routes: Routes = [ {path:"secondpage",component:SecondpageComponent},
{path:"firstpage",component:FirstpageComponent},
{path:"",redirectTo:"/firstpage",pathMatch:'full'}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
