using FluentValidation;
using LightingService.Application;
using LightingService.Application.Common.Interfaces;
using LightingService.Domain.Interfaces.Repositories;
using LightingService.Infrastructure.Data;
using LightingService.Infrastructure.Repositories;
using LightingService.Infrastructure.Services.ESP32;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationAssemblyMarker).Assembly));

//Add FluentValidation
builder.Services.AddValidatorsFromAssemblyContaining<ApplicationAssemblyMarker>();

// Add repository
builder.Services.AddScoped<ITestRepository, TestRepository>();



// Add DbContext with PostgreSQL
builder.Services.AddDbContext<LightningServiceDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddHttpClient<ITableMotorService,TableMotorService>();

var app = builder.Build();

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
