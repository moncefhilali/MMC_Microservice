import { Component } from '@angular/core';

@Component({
  selector: 'app-speakers-page',
  templateUrl: './speakers-page.component.html',
  styleUrls: ['./speakers-page.component.css'],
})
export class SpeakersPageComponent {
  allSpeakers: any = [
    {
      name: 'Anas Belabbes',
      imagePath: 'speaker_1.jpg',
    },
    {
      name: 'Hassan Fadili',
      imagePath: 'speaker_2.jpg',
    },
    {
      name: 'Said Wahid',
      imagePath: 'speaker_3.jpg',
    },
    {
      name: 'Outman Bazzaz',
      imagePath: 'speaker_4.jpg',
    },
    {
      name: 'Mohssine Masaaf',
      imagePath: 'speaker_5.jpg',
    },
    {
      name: 'Youssef Chigane',
      imagePath: 'speaker_6.jpg',
    },
  ];
}
