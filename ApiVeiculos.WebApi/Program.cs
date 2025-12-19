using ApiVeiculos.Application.Behaviors;
using ApiVeiculos.Application.Commands.Adicionar;
using ApiVeiculos.Application.VeiculoService;
using ApiVeiculos.Application.VeiculoService.Interfaces;
using ApiVeiculos.Domain.Interfaces.Repositories;
using ApiVeiculos.Infrastructure.Context;
using ApiVeiculos.Infrastructure.Repository;
using ApiVeiculos.WebApi.OpenAPI;
using FluentValidation;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters
            .Add(new JsonStringEnumConverter());
    });

builder.Services.AdicionarSwagger();

builder.Services.AddDbContext<VeiculoDbContext>(options =>
    options.UseInMemoryDatabase("VeiculosDb"));

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(AdicionarVeiculoCommand).Assembly));

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<AdicionarVeiculoCommandValidator>();

builder.Services.AddScoped<IVeiculoRepository, VeiculoRepository>();
builder.Services.AddScoped<IVeiculoService, VeiculoService>();
builder.Services.AddTransient(typeof(IPipelineBehavior<,>),
    typeof(ValidationBehavior<,>));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UsarSwagger();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.Run();
