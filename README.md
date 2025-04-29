# 🎬 Sistema de Gerenciamento de Filmes

Este é um sistema básico em ASP.NET Core 8 que permite cadastrar, listar, atualizar e deletar filmes, com suporte a categorias (gêneros).

## 🔧 Tecnologias Usadas

- .NET 8 Minimal API
- SQLite
- Entity Framework Core
- Git + GitHub

## 🧩 Relacionamento

- Um **Filme** pertence a um **Gênero**
- Um **Gênero** pode ter vários **Filmes**

## 📦 Executando o projeto

```bash
dotnet restore
dotnet ef database update
dotnet run

📮 Endpoints principais
GET /filmes – Lista todos os filmes


GET /filmes/{id} – Detalhes de um filme


POST /filmes – Cadastrar filme


PUT /filmes/{id} – Atualizar filme


DELETE /filmes/{id} – Deletar filme


📹 Vídeo demonstrativo
//
