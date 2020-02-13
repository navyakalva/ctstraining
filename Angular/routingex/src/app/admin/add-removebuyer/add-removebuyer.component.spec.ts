import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddRemovebuyerComponent } from './add-removebuyer.component';

describe('AddRemovebuyerComponent', () => {
  let component: AddRemovebuyerComponent;
  let fixture: ComponentFixture<AddRemovebuyerComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddRemovebuyerComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddRemovebuyerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
