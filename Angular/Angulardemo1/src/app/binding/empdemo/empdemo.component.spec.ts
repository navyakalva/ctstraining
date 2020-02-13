import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EmpdemoComponent } from './empdemo.component';

describe('EmpdemoComponent', () => {
  let component: EmpdemoComponent;
  let fixture: ComponentFixture<EmpdemoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EmpdemoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmpdemoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
