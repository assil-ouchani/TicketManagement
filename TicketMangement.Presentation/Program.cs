using Microsoft.EntityFrameworkCore;
using TicketManagement.Infrastructure.Data;
using TicketManagement.Infrastructure.Data.DbContexts;
using TicketManagement.Infrastructure.Data.Repositories;
using TicketManagment.Domain.Interfaces;
using TicketMangemment.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Configure the in-memory database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("InMemoryDb"));

// Register services for dependency injection
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<TicketService>();

// Add Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseAuthorization();

app.MapControllers(); // Map controller endpoints

app.Run();
