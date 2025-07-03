

==============================
📚 API de Gestão de Biblioteca
==============================

API RESTful construída em .NET 5 com arquitetura baseada em DDD para gerenciar livros e empréstimos.

---------------------
🧩 Tecnologias usadas
---------------------
- ASP.NET Core (.NET 5)
- Entity Framework Core
- SQL Server
- Swagger
- Arquitetura DDD (Domain Driven Design)

-----------------------------
📦 Estrutura do Projeto (DDD)
-----------------------------
/API                 → Controllers da Web API
/Application         → Interfaces e Serviços de Aplicação
/Domain              → Entidades e Regras de Negócio
/Infrastructure      → Persistência com EF Core

------------------------
⚙️ Configuração Rápida
------------------------

1. Configure a string de conexão no `appsettings.json`:

  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=BibliotecaDb;Trusted_Connection=True;"
  }

2. Crie o banco de dados:

   a. dotnet ef migrations add InitialCreate
    dotnet ef database update.
   
   Ou
   
   b. Coloquei o script para criação das tabelas no README.txt dentro do projeto.

4. Execute a API:

  dotnet run --project API

4. Acesse o Swagger:

  https://localhost:5001/swagger

----------------------
📌 Endpoints da API
----------------------

== LIVROS ==
[POST]   /api/livros
→ Cria um novo livro

[GET]    /api/livros/{id}
→ Obtém um livro por ID

[GET]    /api/livros
→ Lista todos os livros

== EMPRÉSTIMOS ==
[POST]   /api/emprestimos
→ Solicita um empréstimo (JSON: { "livroId": int })

[POST]   /api/emprestimos/{id}/devolucao
→ Realiza devolução de um empréstimo

[GET]    /api/emprestimos
→ Lista todos os empréstimos

--------------------------
🧪 Testes Automatizados
--------------------------
Os testes podem ser adicionados na pasta `/Tests`. Execute com:

  dotnet test

-------------------------
👨‍💻 Autor
-------------------------
Desenvolvido por Kauã Alves

-------------------------
📄 Licença
-------------------------
MIT License
