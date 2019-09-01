import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from 'src/app/login/login.component';
import { AppComponent } from 'src/app/app.component';
import { HomeComponent } from 'src/app/home/home.component';


const routes: Routes = [
  {
    path: '',
    component: LoginComponent
  },
{
  path: 'Home',
  component: HomeComponent
},
  {
    path: 'login',
    component: LoginComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
