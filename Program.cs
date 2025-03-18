using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using MyApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Configuración de la Base de Datos SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar los servicios con inyección de dependencias
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();
