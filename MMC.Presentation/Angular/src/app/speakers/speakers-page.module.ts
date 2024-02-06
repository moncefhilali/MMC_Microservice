import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SpeakersPageComponent } from './speakers-page.component';
import { NavbarComponent } from '../shared/navbar/navbar.component';
import { HeaderComponent } from '../shared/header/header.component';
import { SpeakersComponent } from './components/speakers/speakers.component';

@NgModule({
  declarations: [SpeakersPageComponent, SpeakersComponent],
  imports: [CommonModule, NavbarComponent, HeaderComponent],
})
export class SpeakersPageModule {}
