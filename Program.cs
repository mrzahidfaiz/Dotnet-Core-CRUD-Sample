using Microsoft.EntityFrameworkCore;
using Web_Api_CRUD_Dotnet_Core_8.Model;

var builder = WebApplication.CreateBuilder(args);

// DataBase
builder.Services.AddDbContext<AppDbContext>( options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("PrimaryDbConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
