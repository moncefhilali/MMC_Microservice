import { Component } from '@angular/core';
import { Event } from './interfaces/events-interface';
import { EventsService } from './services/events.service';

@Component({
  selector: 'app-events-page',
  templateUrl: './events-page.component.html',
  styleUrls: ['./events-page.component.css'],
})
export class EventsPageComponent {
  allEvents: Event[] = [];
  constructor(private eventService: EventsService) {}

  ngOnInit() {
    this.eventService.getEvents().subscribe((response) => {
      this.allEvents = response;
      console.log(response);
    });
  }
}
