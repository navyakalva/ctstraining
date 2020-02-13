import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FormexComponent } from './formex.component';

describe('FormexComponent', () => {
  let component: FormexComponent;
  let fixture: ComponentFixture<FormexComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FormexComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FormexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
