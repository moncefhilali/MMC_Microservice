import { Component } from '@angular/core';
import { Speaker } from './interfaces/speaker-interface';
import { SpeakersService } from './services/speakers.service';

@Component({
  selector: 'app-speakers-page',
  templateUrl: './speakers-page.component.html',
  styleUrls: ['./speakers-page.component.css'],
})
export class SpeakersPageComponent {
  allSpeakers: Speaker[] = [];
  constructor(private speakerService: SpeakersService) {}

  ngOnInit() {
    this.speakerService.getSpeakers().subscribe((response) => {
      this.allSpeakers = response;
      console.log(response);
    });
  }
}
