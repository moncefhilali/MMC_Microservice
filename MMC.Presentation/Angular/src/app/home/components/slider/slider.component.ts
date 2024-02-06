import { Component, Input } from '@angular/core';
import { Event } from 'src/app/events/interfaces/events-interface';

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css'],
})
export class SliderComponent {
  @Input() events: any[] = [];
}
