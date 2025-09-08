import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Mother } from './mother';

describe('Mother', () => {
  let component: Mother;
  let fixture: ComponentFixture<Mother>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Mother]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Mother);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
