global using System;
using Microsoft.OpenApi.Models;
using AdoptionManager.Persistance;
using AdoptionManager.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var corsPolicyName = "ClientCors";
var allowedOrigins = builder.Configuration.GetSection("AllowedOrigins").Get<List<string>>();

// Add services to the container.

builder.Services.AddPersistance(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsPolicyName,
        corsBuilder =>
        {
            corsBuilder.WithOrigins(string.Join(", ", allowedOrigins));
        });
});

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "AdoptionManager",
        Description = "An ASP.NET Core Web API for managing animals adoption",
        Contact = new OpenApiContact
        {
            Name = "Daria",
            Email = "luniewska.d@gmail.com",
            Url = new Uri("https://www.linkedin.com/in/daria-luniewska/")
        }
    });
    var filePath = Path.Combine(AppContext.BaseDirectory, "AdoptionManager.Api.xml");
    options.IncludeXmlComments(filePath);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
    await app.SeedDatabaseWithTestData();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(corsPolicyName);

app.UseAuthorization();

app.MapControllers();

app.Run();
