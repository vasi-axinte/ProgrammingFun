import { ComponentFixture, TestBed } from '@angular/core/testing';

import { InsertQuestionsComponent } from './insert-questions.component';

describe('InsertQuestionsComponent', () => {
  let component: InsertQuestionsComponent;
  let fixture: ComponentFixture<InsertQuestionsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ InsertQuestionsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(InsertQuestionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
