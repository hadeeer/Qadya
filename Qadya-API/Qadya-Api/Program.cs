using Microsoft.EntityFrameworkCore;
using Qadya.Data.Data;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// 1. استخراج الـ Connection String من ملف appsettings.json
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2.database config (Dependency Injection)
builder.Services.AddDbContext<ApplicationDbContext>(dbconfig =>
    dbconfig.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
