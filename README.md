# WCM.WebApi

## Objetivo da aplicação
 A aplicação tem como objetivo identificar a apartir de uma lista de filmes, quem é campeão e o vice campeão.

 A aplicação disponibiliza a lista de filmes na rota "v1/movies".

 Você pode passar 8 ids desses fimes na rota "v1/Championship" e através da regra de negócio o endpoint retornará o campeão e o vice.


## O que temos no projeto?

#### .NET Core

Versão 3.1

Caso precise instalar o SDK, você ppode encontra-lo clicando [aqui](https://dotnet.microsoft.com/download/dotnet-core/3.1)

## Ambiente de desenvolvimento

 - Linux Mint 19.3
 - VS Code
 - Dotnet SDK 3.1

#### Rodando a aplicação localmente

- Abra o terminal na pasta raiz do repositório
- Execute o seguinte comandos : 

    -  dotnet restore
    -  dotnet run --project src/WCM.WebApi/WCM.WebApi.csproj

- Abra o browser de sua preferência e acesse o endereço : [https://localhost:5001/swagger/index.html](https://localhost:5001/swagger/index.html)


#### Rodando os testes

- Abra o terminal na pasta raiz do repositório
- Execute o seguinte comandos : 
    -  dotnet restore
    -  dotnet build
    -  dotnet test



