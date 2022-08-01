
using Microsoft.EntityFrameworkCore;
using Repository.Repository;
using Repository.RepositoryImpl;
using Service.Services;
using Service.ServicesImpl;
using UnitofWork.Core;
using UnitofWork.CoreImpl;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//REPOSITORIO
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepositoryImpl>();

//SERVICIOS
builder.Services.AddScoped<IUsuarioService, UsuarioServiceImpl>();


//Unit of Work
builder.Services.AddScoped<IUnitOfWork, UnitOfWorkImpl>();

//DBcontext
builder.Services.AddDbContext<Infraestructura.Data.ApplicationDbContext>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Cors
builder.Services.AddCors();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<Infraestructura.Data.ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Cors van antes de la autorizacion
app.UseCors(x=>x.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());
app.UseAuthorization();

app.MapControllers();

app.Run();
