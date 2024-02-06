import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { SpeakersPageComponent } from './speakers/speakers-page.component';
import { EventsPageComponent } from './events/events-page.component';
import { RegisterPageComponent } from './register/register-page.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'speakers', component: SpeakersPageComponent },
  { path: 'events', component: EventsPageComponent },
  { path: 'register', component: RegisterPageComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
