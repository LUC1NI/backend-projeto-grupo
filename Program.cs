using Microsoft.EntityFrameworkCore;
using BackendProjeto.Data;

var builder = WebApplication.CreateBuilder(args);

// Configura o banco de dados
// cola aqui leo o builder 


// Swagger (documentação da API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// AQUI VOCÊS VÃO ADICIONAR OS ENDPOINTS DE FILME E GÊNERO

app.Run();
