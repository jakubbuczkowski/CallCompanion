using CallCompanion.Controllers;
using CallCompanion.Data;
using CallCompanion.Interfaces;
using CallCompanion.Repositories;
using CallCompanion.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//builder.Services.AddSingleton<IContactsRepository, ContactsRepository>();
//builder.Services.AddTransient<ContactsController>();
builder.Services.AddScoped<IContactsRepository, ContactsRepositoryDB>();
builder.Services.AddScoped<ContactsService>();
builder.Services.AddDbContext<CallCompanionDbContext>(options => options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
