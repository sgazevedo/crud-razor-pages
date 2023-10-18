# CRUD com ASP.NET MVC e Razor Pages

Repositório contendo implementação de CRUD de uma plataforma online de Cursos, onde são possíveis cadastrar Alunos (Students) e Inscrições (Subscriptions). O desafio foi feito no canal balta.io, no YouTube. 

Esse CRUD foi gerado com Scaffold, e a idéia é na sequencia aplicar refatorações para melhorar o projeto, como separar frontend e backend, aplicar domínio rico, testes, etc.

## Comandos executados

Abaixo serão listados os comandos utilizados para criação de forma "crua" o projeto e os CRUDS (Scaffold).

Esse comando abaixo cria um novo projeto de Razor Pages em ASP.NET 7.0, e também contendo autenticação com ASP.NET Identity.

´´´
dotnet new razor -o OnlineCoursePlatform.Web -f net7.0 --auth Individual
´´´

Os comandos abaixo são executados para adicionar no projeto o EntityFrameworkCore, a ferramenta dotnet-ef, gerar as migrations das entidades criadas e atualizar o database criando as novas tabelas das entidades

´´´
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet tool install --global dotnet-ef
dotnet ef migrations add v1
dotnet ef database update
´´´

Os comandos abaixo são para instalar pacote de Code Generator e adicionar o package no projeto, para permitir fazer Scaffold.

´´´
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
´´´

O comando abaixo é o comando padrão para o Scaffold, afim de criar páginas de CRUD para manutenção de dados da entidade.

´´´
dotnet aspnet-codegenerator razorpage nome-pagina template -m model -dc data-context -sqlite -udl -outDir local-page
´´´
Sobre os parâmetros:
- nome-pagina: o nome do arquivo da página
- template: são 5 possíveis: Create, Edit, Delete, List, Details
- model: o model/entidade de referência
- data-context: O data context de referência da entidade.
- sqlite: caso não informado, o padrão é SQL Server
- udl: Uses default layout, serve para utilizar o layout padrão do ASP.NET. Pode se usar também a flag --useDefaultLayout 
- outdir: diretório onde a página será criada

Abaixo, todos os comandos executados para criação das páginas dos CRUDS para Sudents e Subscriptions.

Para criar o CRUD de Students:
´´´
dotnet aspnet-codegenerator razorpage Create Create -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students

dotnet aspnet-codegenerator razorpage Edit Edit -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students

dotnet aspnet-codegenerator razorpage Delete Delete -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students

dotnet aspnet-codegenerator razorpage Details Details -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students

dotnet aspnet-codegenerator razorpage Index List -m Student -dc ApplicationDbContext -sqlite -udl -outDir Pages/Students

´´´

Para criar o CRUD de Subscriptions:
´´´
dotnet aspnet-codegenerator razorpage Create Create -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions

dotnet aspnet-codegenerator razorpage Edit Edit -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions

dotnet aspnet-codegenerator razorpage Delete Delete -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions

dotnet aspnet-codegenerator razorpage Details Details -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions

dotnet aspnet-codegenerator razorpage Index List -m Subscription -dc ApplicationDbContext -sqlite -udl -outDir Pages/Subscriptions

´´´