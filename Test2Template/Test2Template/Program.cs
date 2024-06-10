using Microsoft.EntityFrameworkCore;
using Test2Template.Api.MiddleWares;
using Test2Template.Api.Repositories;
using Test2Template.Api.Services;
using Test2Template.DataBase.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddExceptionHandler<ExceptionHandlingMiddleware>();

// Adding repositories
builder.Services.AddScoped<ImyRepository, MyRepository>();

// Adding services
builder.Services.AddScoped<ImyService, MyService>();

// Adding Controllers
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();
