import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NgforstudentComponent } from './ngforstudent.component';

describe('NgforstudentComponent', () => {
  let component: NgforstudentComponent;
  let fixture: ComponentFixture<NgforstudentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NgforstudentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NgforstudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
