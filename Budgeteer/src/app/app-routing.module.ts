import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthService } from './serverices/auth.service';
import { ProfileComponent } from './profile/profile.component';
import { AuthGuard } from './auth.guard';
import { WeatherComponent } from './weather/weather.component';


const routes: Routes = [
  {
    path: 'profile',
    component: ProfileComponent,
    canActivate: [AuthGuard]
  },
  {
    path: 'weather',
    component: WeatherComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
  constructor(public auth: AuthService) { }
}
