import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-latest-event',
  templateUrl: './latest-event.component.html',
  styleUrls: ['./latest-event.component.css'],
})
export class LatestEventComponent {
  constructor(private router: Router) {}

  redirectToAnotherPage() {
    this.router.navigate(['/register']);
  }
}
