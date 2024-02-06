import { Component, Input } from '@angular/core';
import { Speaker } from '../../interfaces/speaker-interface';

@Component({
  selector: 'app-speakers',
  templateUrl: './speakers.component.html',
  styleUrls: ['./speakers.component.css'],
})
export class SpeakersComponent {
  @Input() speakers: Speaker[] = [];
}
