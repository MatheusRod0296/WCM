# WCM.WebApi

## Objetivo da aplicação
 A Aplicação tem como objetivo identificar a apartir de uma lista de filmes, quem é campeoão e o vice campeão.
 A Aplicação disponibiliza a lista de filmes na rota "v1/movies"
 Voce pode passar 8 ids desses fimes na rota "v1/Championship" e atraves da regra de negocio o endpoint retornará o campeão e o vice.


## O que temos no projeto?

#### .NET Core

Versão 3.1

Caso precise instalar o Sdk, você ppode encontra-lo clicando [aqui(https://dotnet.microsoft.com/download/dotnet-core/3.1)]

## Ambiente de desenvolvimento

 - Linux Mint 19.3
 - VS Code
 - Dotnet SDK 3.1

#### Rodando a aplicação localmente

- Abra o terminal na pasta raiz do repositório
- Execute o seguinte comandos : 
    1 dotnet restore
    2 dotnet run --project src/WCM.WebApi/WCM.WebApi.csproj

- abra o browser de sua preferencia e acesse o endereço : [https://localhost:5001/swagger/index.html(https://localhost:5001/swagger/index.html)]


#### Rodando os testes

- Abra o terminal na pasta raiz do repositório
- Execute o seguinte comandos : 
    1 dotnet restore
    2 dotnet build
    3 dotnet test



