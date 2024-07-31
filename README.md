# ecommerce-backend

## Visão Geral

O backend do projeto `ecommerce-backend` é uma API desenvolvida com .NET 8.0 para gerenciamento de clientes em uma loja. 

## Estrutura do Projeto

O projeto está dividido nas seguintes camadas:

- **API**: Contém os controladores e configurações da API.
- **APPLICATION**: Contém a lógica de aplicação e os serviços.
- **CONFIG**: Configurações gerais e arquivos de configuração.
- **CORE**: Contém as interfaces e abstrações principais.
- **DOMAINS**: Modelos e lógica de domínio.
- **TEST**: Projetos de teste para a API.



## Tecnologias Utilizadas

- **.NET 8.0**: Framework para desenvolvimento de aplicações.
- **AutoMapper**: Para mapeamento entre objetos.
- **Microsoft.EntityFrameworkCore**: ORM para interagir com bancos de dados.
- **MongoDB**: Banco de dados NoSQL.
- **xUnit**: Framework de testes para .NET.
- **Swashbuckle.AspNetCore**: Para documentação da API com Swagger.
- **BCrypt.Net-Core**: Para hashing de senhas.

## Versões Abordadas

O backend está atualizado com as seguintes tecnologias e versões:

- **.NET**: `8.0`
- **AutoMapper**: `13.0.1`
- **Microsoft.AspNetCore.Authentication.JwtBearer**: `8.0.7`
- **Swashbuckle.AspNetCore**: `6.4.0`
- **BCrypt.Net-Core**: `1.6.0`
- **Microsoft.EntityFrameworkCore**: `8.0.7`
- **MongoDB.Driver**: `2.28.0`
- **xUnit**: `2.5.3`

## Scripts

Para executar as tarefas principais do backend, use os seguintes comandos:

- **Desenvolvimento**: `dotnet run --project Backend.API/Backend.API.csproj` - Inicia o servidor de desenvolvimento.
- **Construção**: `dotnet build` - Compila o projeto para produção.
- **Testes**: `dotnet test` - Executa os testes unitários e de integração.

## Rotas da API

### Clientes

- **GET** `/api/clients`  
  Obtém a lista de clientes.  
  **Autorização**: Anônima

- **GET** `/api/clients/{id}`  
  Obtém um cliente específico pelo ID.  
  **Autorização**: Anônima

- **POST** `/api/clients/VerifyRegister`  
  Verifica o registro de um cliente.  
  **Autorização**: Anônima  
  **Corpo da Requisição**: `VerifyClientDTO`

- **POST** `/api/clients`  
  Cria um novo cliente.  
  **Autorização**: Anônima  
  **Corpo da Requisição**: `ClientDTO`

- **PUT** `/api/clients/{id}`  
  Atualiza as informações de um cliente existente.  
  **Autorização**: Anônima  
  **Corpo da Requisição**: `ClientDTO`

## Documentação da API

A documentação da API está disponível em [Swagger UI]([http://localhost:5000/swagger](https://localhost:7165/swagger/index.html)) quando o servidor está em execução no ambiente de desenvolvimento.


## Contato

Para dúvidas ou mais informações, entre em contato com o mantenedor do projeto (pedrinhoas7@gmail.com).
