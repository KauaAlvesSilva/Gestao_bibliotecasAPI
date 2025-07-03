

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
Crie as tabelas: 
  CREATE TABLE Livros (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(255) NOT NULL,
    Autor NVARCHAR(255) NOT NULL,
    AnoPublicacao INT NOT NULL,
    QuantidadeDisponivel INT NOT NULL
);

CREATE TABLE Emprestimos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    LivroId INT NOT NULL,
    DataEmprestimo DATETIME2 NOT NULL,
    DataDevolucao DATETIME2 NULL,
    Status NVARCHAR(20) NOT NULL,

    CONSTRAINT FK_Emprestimos_Livros FOREIGN KEY (LivroId)
        REFERENCES Livros(Id)
        ON DELETE CASCADE
);

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
