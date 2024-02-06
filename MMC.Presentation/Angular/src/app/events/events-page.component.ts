import { Component } from '@angular/core';

@Component({
  selector: 'app-events-page',
  templateUrl: './events-page.component.html',
  styleUrls: ['./events-page.component.css'],
})
export class EventsPageComponent {
  allEvents: any[] = [
    {
      title: 'Global AI Bootcamp 2024',
      place: '2024-04-26 - Tanger in Morocco',
      imageUrl: 'event_poster_1.png',
    },
    {
      title: 'Microsoft Tech Day',
      place: '2024-02-17 - Beni Mellal in Morocco',
      imageUrl: 'event_poster_2.jpg',
    },
    {
      title: 'Microsoft Tech Talks',
      place: '2023-12-09 - Agadir in Morocco',
      imageUrl: 'event_poster_3.png',
    },
    {
      title: 'Microsoft Tech Talks',
      place: '2023-11-25 - Khouribga in Morocco',
      imageUrl: 'event_poster_4.jpg',
    },
    {
      title: 'Digital Transformation Using Azure Services',
      place: '2023-09-30 - Ouarzazate in Morocco',
      imageUrl: 'event_poster_5.png',
    },
    {
      title: 'Transformation Digitale avec Services cloud Azure',
      place: '2023-06-17 - Meknès in',
      imageUrl: 'event_poster_6.jpg',
    },
  ];
}
