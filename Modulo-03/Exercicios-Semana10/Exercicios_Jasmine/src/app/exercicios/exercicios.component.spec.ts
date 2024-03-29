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

  it('validar o uso do toMatch', () => {
    const email = component.exibirEmail('edmilson@email.com.br')

    expect(email).toMatch(/^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)?$/i)
  });

  it('validar o uso do toBeDefined', () => {
    const email = component.exibirEmail('edmilson@email.com')

    expect(email).toBeDefined();
  });

  it('validar o uso do toBeUndefined', () => {
    expect(component.returNull()).toBeUndefined();
  });

  it('validar o uso do toBeTruthy', () => { 
    expect(component.soma).toBeTruthy();
  });

  it('validar o uso do toBeFalse', () => {
    expect(component.testeExemplo()).toBeFalse();
  });

  it('validar o uso do toContain', () => {

    expect(component.linguagens).toContain('csharp');
  });

  it('validar o uso do toBeGreaterThan', () => {
    const result = component.soma(23, 37);
    expect(result).toBeGreaterThan(30);
  });

  it('validar o uso do toBeLessThan', () => {
    const result = component.soma(7, 15);
    expect(result).toBeLessThan(30);
  });

  it('deve chamar metodo exibirCpf(), quando metodo testeCpf() for chamado', () => {
    const cpf = 'exibirCpf';

    spyOn<any>(component, 'exibirCpf');

    component.testeCpf();

    expect(component[cpf]).toHaveBeenCalled();
  });


});
