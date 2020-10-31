import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuizSentConfirmationComponent } from './quiz-sent-confirmation.component';

describe('QuizSentConfirmationComponent', () => {
  let component: QuizSentConfirmationComponent;
  let fixture: ComponentFixture<QuizSentConfirmationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuizSentConfirmationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuizSentConfirmationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
