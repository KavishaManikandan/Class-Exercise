import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Baby } from './baby';

describe('Baby', () => {
  let component: Baby;
  let fixture: ComponentFixture<Baby>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Baby]
    })
    .compileComponents();

    fixture = TestBed.createComponent(Baby);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
