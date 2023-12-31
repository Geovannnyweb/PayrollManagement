using Api._DependencyInjection;
using Application.Interfaces;
using Application.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Inject();

var app = builder.Build();

//app.MapGet("/dbconnection", async ([FromServices] DbEmployeeContext dbcontext) =>
//{
   /// dbcontext.Database.EnsureCreated();
    ///return Results.Ok($"Base de datos en memoria: {dbcontext.Database.IsInMemory()}");
//});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
