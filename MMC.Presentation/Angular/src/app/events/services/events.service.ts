import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Event } from '../interfaces/events-interface';

@Injectable({
  providedIn: 'root',
})
export class EventsService {
  readonly ROOT_URL = 'https://greatpurplewave28.conveyor.cloud/api/Event';

  constructor(private http: HttpClient) {}

  getEvents() {
    return this.http.get<Event[]>(this.ROOT_URL);
  }
}
