import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthService } from './serverices/auth.service';
import { AuthGuard } from './auth.guard';
import { MainComponent } from './main/main.component';


const routes: Routes = [

  {
    path: 'budget',
    component: MainComponent,
    canActivate: [AuthGuard]
  },
  {
    path: '**',
    redirectTo: '/budget'
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
  constructor(public auth: AuthService) { }
}
