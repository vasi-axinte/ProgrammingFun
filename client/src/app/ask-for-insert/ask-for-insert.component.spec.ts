import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AskForInsertComponent } from './ask-for-insert.component';

describe('AskForInsertComponent', () => {
  let component: AskForInsertComponent;
  let fixture: ComponentFixture<AskForInsertComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AskForInsertComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AskForInsertComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
