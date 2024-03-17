using HiWeb_Task.API.Extensions.DependencyInjections;

var builder = WebApplication.CreateBuilder(args);

// Option Configuration
var configuration = builder.Configuration;
builder.Services.AddOptionConfiguration(configuration);

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