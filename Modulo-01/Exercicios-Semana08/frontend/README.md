# Exercicio Semana08 - NG-FOOD

Este projeto foi gerado com [Angular CLI](https://github.com/angular/angular-cli) version 13.3.3.

## Como rodar o projeto?
### Você precisará:
<ul>
    <li>Node JS(obrigatório)</li>
    <li>Visual Studio Code (recomendado)</li>
    <li>Git bash </li>
    <li>Angular CLI</li>
</ul>

*OBS: Para que a aplicação funcione como esperado, você deve deixar o frontend e o backend rodando simultaneamente (abra dois terminais):*

``` bash

#Com o primeiro terminal, abra a pasta backend e execute o comando:
$ json-server --watch db.json

#A aplicação (backend) será aberta na porta:3000 - acesse http://localhost:3000. 
```
Agora que o backend está ativo, é necessário repetir o processo para o frontend: 

```bash
#No segundo terminal, abra a pasta frontend e execute o comando:
$ ng serve -o

#A aplicação(frontend) será aberta na porta:4200 - acesse http://localhost:4200. 
```

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via a platform of your choice. To use this command, you need to first add a package that implements end-to-end testing capabilities.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI Overview and Command Reference](https://angular.io/cli) page.
