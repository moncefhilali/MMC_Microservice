import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EventsPageComponent } from './events-page.component';
import { NavbarComponent } from '../shared/navbar/navbar.component';
import { HeaderComponent } from '../shared/header/header.component';
import { EventsComponent } from './components/events/events.component';

@NgModule({
  declarations: [EventsPageComponent, EventsComponent],
  imports: [CommonModule, NavbarComponent, HeaderComponent],
})
export class EventsPageModule {}
