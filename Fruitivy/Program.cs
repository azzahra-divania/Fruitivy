using Fruitivy;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//connectionstring ke dev.json
string connString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllers();

//saat run project langsung connect ke db server
builder.Services.AddDbContext<FruitivyDBContext>(options =>
{
    options.UseNpgsql(connString);
});

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
