import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SliderComponent } from './components/slider/slider.component';
import { NavbarComponent } from '../shared/navbar/navbar.component';
import { HomeComponent } from './home.component';
import { CarouselModule } from 'primeng/carousel';
import { OurMissionComponent } from './components/our-mission/our-mission.component';
import { LatestEventComponent } from './components/latest-event/latest-event.component';

@NgModule({
  declarations: [HomeComponent, SliderComponent, OurMissionComponent, LatestEventComponent],
  imports: [CommonModule, NavbarComponent, CarouselModule],
})
export class HomeModule {}
