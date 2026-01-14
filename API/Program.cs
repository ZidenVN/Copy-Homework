using Application;
using Application.Abtractions;
using Application.Mapper;
using Application.Repositories;
using Infrastructure.ApplicationDbContext;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Load configuration
var configuration = builder.Configuration;

// Controllers
builder.Services.AddControllers();

// Add SQL Server
builder.Services.AddDbContext<AccountDbContext>(cfg =>
    cfg.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IAccountDbContext>(provider =>
    provider.GetRequiredService<AccountDbContext>());
// Repositories
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Services
builder.Services.AddScoped<IUserService, UserService>();

// Auto Mapper Configurations
builder.Services.AddAutoMapper(typeof(UserProfile).Assembly);

// Build app
var app = builder.Build();


app.MapControllers();

app.Run();
