using System.Text;
using DotNetEnv;
using Microsoft.OpenApi.Models;
using Appointment_Management.Data; 
using Microsoft.EntityFrameworkCore;
using Appointment_Management.Services;
using Appointment_Management.Repositories;

Env.Load();

var DB_HOST = Environment.GetEnvironmentVariable("DB_HOST");
var DB_NAME = Environment.GetEnvironmentVariable("DB_NAME");
var DB_PORT = Environment.GetEnvironmentVariable("DB_PORT");
var DB_USERNAME = Environment.GetEnvironmentVariable("DB_USERNAME");
var DB_PASSWORD = Environment.GetEnvironmentVariable("DB_PASSWORD");

var JWT_KEY = Environment.GetEnvironmentVariable("JWT_KEY");
var JWT_ISSUER = Environment.GetEnvironmentVariable("JWT_ISSUER");
var JWT_AUDIENCE = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
var JWT_EXPIRES_IN = Environment.GetEnvironmentVariable("JWT_EXPIRES_IN");

var stringConnection = $"server={DB_HOST};port={DB_PORT};database={DB_NAME};uid={DB_USERNAME};password={DB_PASSWORD}";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(stringConnection, ServerVersion.Parse("8.0.20-mysql"));
});

builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Appointment Management API",
        Version = "v1",
        Description = "A simple API for managing appointments.",
        Contact = new OpenApiContact
        {
            Name = "Your Name",
            Email = "your.email@example.com"
        }
    });
});

var app = builder.Build();

app.Use(async (context, next) =>
{
    if (context.Request.Path == "/")
    {
        context.Response.Redirect("/swagger");
    }
    else
    {
        await next.Invoke();
    }
});

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Appointment Management API v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run(); 
