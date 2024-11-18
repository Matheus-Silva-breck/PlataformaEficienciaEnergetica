# PlataformaEficienciaEnergetica

Este projeto ASP.NET Core MVC implementa uma plataforma básica para gerenciamento de dados de eficiência energética de prédios.

## Funcionalidades

* Cadastro de prédios com nome e consumo energético.
* Edição de dados de prédios existentes.
* Exclusão de prédios.
* Listagem de prédios cadastrados.

## Tecnologias Utilizadas

* ASP.NET Core MVC
* Entity Framework Core
* Oracle Database (ou outro banco de dados, dependendo da sua configuração)


## Pré-requisitos

* .NET SDK (versão X.X ou superior) -  [Download](https://dotnet.microsoft.com/download)
* Oracle Client (se você estiver usando Oracle Database) - [Download](https://www.oracle.com/database/technologies/instant-client/downloads.html)

## Configuração

1. **Clonar o repositório:**

git clone https://github.com/SeuUsuario/PlataformaEficienciaEnergetica.git

2. **Configurar a string de conexão:**

**Abra o arquivo appsettings.json e atualize a string de conexão DefaultConnection com as credenciais do seu banco de dados.**

"ConnectionStrings": {
    "DefaultConnection": "SuaStringDeConexao"
  }

3. **Executar as migrations:**

**Abra o console do NuGet Package Manager (Tools > NuGet Package Manager > Package Manager Console) e execute os seguintes comandos:**
dotnet ef migrations add InitialCreate  (ou o nome da migration inicial)
dotnet ef database update

## Executando o projeto

1. **Navegue até a pasta do projeto:**
cd PlataformaEficienciaEnergetica

2. **Execute o projeto:**
dotnet run

O aplicativo será iniciado e estará acessível em https://localhost:5001 (ou em outra porta, dependendo da sua configuração).

-------------------------------------------------------------------------------------------------------------------------------
## Integrantes do grupo
- **Nome: Eduardo Rodrigues Shiraga**
- **RM: 553705**
- **Nome: Giovani Shiraishi Borba**
- **RM: 553724**
- Nome: Matheus Rodrigo da Silva
- **RM: 553180**

## Licença
**Este projeto está licenciado sob a MIT License - veja o arquivo LICENSE para mais detalhes.**

**Lembre-se de:**
* Substituir `SuaStringDeConexao` pela string de conexão correta do seu banco de dados.
