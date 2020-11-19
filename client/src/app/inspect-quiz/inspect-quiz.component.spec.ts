import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InspectQuizComponent } from './inspect-quiz.component';

describe('InspectQuizComponent', () => {
  let component: InspectQuizComponent;
  let fixture: ComponentFixture<InspectQuizComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InspectQuizComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InspectQuizComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
