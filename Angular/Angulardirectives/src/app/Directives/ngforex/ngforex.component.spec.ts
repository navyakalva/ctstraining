import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NgforexComponent } from './ngforex.component';

describe('NgforexComponent', () => {
  let component: NgforexComponent;
  let fixture: ComponentFixture<NgforexComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NgforexComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NgforexComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
