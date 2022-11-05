import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ExerciciosComponent } from './exercicios.component';

describe('ExerciciosComponent', () => {
  let component: ExerciciosComponent;
  let fixture: ComponentFixture<ExerciciosComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ExerciciosComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ExerciciosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('validar o uso do toBe', () => {
    const aluno = component.returnAluno('Edmilson'); 
    expect(component.returnAluno('Edmilson')).toBe(aluno);
  });

  it('validar o uso do toEqual', () => {
    const professor = component.returnAluno('Edmilson'); 
    expect(component.returnAluno('Edmilson')).toBe(professor);
  });
});
