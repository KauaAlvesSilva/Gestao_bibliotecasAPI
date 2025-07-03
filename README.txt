Criar Tabela do SQL: 

Tabela Livro: 

CREATE TABLE Livros (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Titulo NVARCHAR(255) NOT NULL,
    Autor NVARCHAR(255) NOT NULL,
    AnoPublicacao INT NOT NULL,
    QuantidadeDisponivel INT NOT NULL
);


Tabela Emprestimo:

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

