import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Speaker } from '../interfaces/speaker-interface';

@Injectable({
  providedIn: 'root',
})
export class SpeakersService {
  readonly ROOT_URL = 'https://localhost:7216/api/Clinics';

  constructor(private http: HttpClient) {}

  getSpeakers() {
    return this.http.get<Speaker[]>(this.ROOT_URL);
  }
}
