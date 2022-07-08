# dev-in-ndd-2-mod-6-sem
Módulo 2 - Semana 6  - DEV-IN-HOUSE-NDD


https://github.com/jamildaruix/dev-in-house-ndd-2-mod-6-sem

**Enunciado**

Estrutura de como ficar o projeto 

/modulo2-semana6
    modulo2-semana6.sln
    /modulo2-semana6-api
        modulo2-semana6-api.csproj
    /modulo2-semana6-tests
        modulo2-semana6-tests.csproj


1. Criar um diretório e solução chamado "modulo2-semana6"
----------------

1.1: Solução chamada "modulo2-semana6"
1.2: Comando para criar a solução dotnet new sln -n modulo2-semana6


1. Criar uma API em C# com Nome "modulo2-semana6-api" 
----------------
1.1: Esse projeto vai precisar validar alguns métodos  "modulo2-semana6-api"
1.2: Comando para criar o projeto dotnet new webapi --name modulo2-semana6-api
1.3: Comando para adicionar o projeto na solução dotnet sln add .\modulo2-semana6-api\modulo2-semana6-api.csproj
1.4: Comando para restaurar os pacotes donet restore
1.4: Comando para build donet build
1.5: Comando para exeuctar a api dotnet run

https://localhost:{{porta:confiugraca}}/swagger/index.html


2 - Criação de um aplicação para Teste chamada "modulo2-semana6-tests"
----------------

2.1: Esse projeto vai efetuar os teste da aplicação "modulo2-semana6-tests"
2.2: comando para criar o projeto dotnet new xunit -n modulo2-semana6-tests
2.3: Comando para adicionar o projeto na solução dotnet sln add .\modulo2-semana6-tests\modulo2-semana6-tests.csproj
2.4: Comando para testar o método dotnet test .\modulo2-semana6-tests\modulo2-semana6-tests.csproj

3 - Referenciar o projeto da api no projeto do teste
----------------

3.1: Comando para referenciar o projeto API no TESTS dotnet add .\modulo2-semana6-tests\modulo2-semana6-tests.csproj reference .\modulo2-semana6-api\modulo2-semana6-api.csproj


4 - Separei em partes os exercícios para ficar o melhor entendimento e fluir  a resolução de uma forma menos complicada
----------------

5 - Objetivo dos exercícios é a criação de uma API para efetuar testes de regras na api e classes
----------------
