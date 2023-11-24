using Core.Creational.AbstractFactory;
using Core.Creational.AbstractFactory.Interfaces;
using Core.Creational.FactoryMethod.Factory;
using Core.Creational.FactoryMethod.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ITransportFactory, TransportFactory>();
builder.Services.AddSingleton<IFurniteFactory, FurnitureFactory>();

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
