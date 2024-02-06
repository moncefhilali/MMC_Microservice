import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SpeakersPageComponent } from './speakers-page.component';

describe('SpeakersPageComponent', () => {
  let component: SpeakersPageComponent;
  let fixture: ComponentFixture<SpeakersPageComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SpeakersPageComponent]
    });
    fixture = TestBed.createComponent(SpeakersPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
