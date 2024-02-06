import { Component, Input } from '@angular/core';
import { Event } from '../../interfaces/events-interface';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css'],
})
export class EventsComponent {
  @Input() events: Event[] = [];
}
