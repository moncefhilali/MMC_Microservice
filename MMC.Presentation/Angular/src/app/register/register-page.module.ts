import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterPageComponent } from './register-page.component';
import { NavbarComponent } from '../shared/navbar/navbar.component';
import { HeaderComponent } from '../shared/header/header.component';

@NgModule({
  declarations: [RegisterPageComponent],
  imports: [CommonModule, NavbarComponent, HeaderComponent],
})
export class RegisterPageModule {}
