using HiWeb_Task.API.Extensions.DependencyInjections;
using HiWeb_Task.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Option Configuration
var configuration = builder.Configuration;
builder.Services.AddOptionConfiguration(configuration);

// DbContext Configuration
builder.Services.AddDbContext<AppDbContext>();

// MediatR Configuration
builder.Services.AddMediatRConfiguration();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();