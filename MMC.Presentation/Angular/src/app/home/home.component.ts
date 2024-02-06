import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
export class HomeComponent {
  allEvents: any[] = [
    {
      title: 'Microsoft Tech Day 2024/02/17 - in Beni Mellal',
      imagePath: 'event_1.png',
    },
    {
      title: 'Microsoft Tech Talks 2023/12/09 - in Agadir',
      imagePath: 'event_2.jpg',
    },
    {
      title: 'Microsoft Tech Talks 2023/11/25 - in Khouribga',
      imagePath: 'event_3.jpg',
    },
    {
      title:
        'Digital Transformation Using Azure Services 2023/09/30 - in Ouarzazate',
      imagePath: 'event_4.jpg',
    },
    {
      title:
        'Transformation Digitale avec Services cloud Azure 2023/06/17 - in Meknès',
      imagePath: 'event_5.jpg',
    },
    {
      title:
        'Trasformation Digital Using AZURE CLOUD SERVICES 2023/05/27 - in Khouribga',
      imagePath: 'event_6.jpg',
    },
  ];
}
