using DAl.Model;
using Microsoft.EntityFrameworkCore;
using IObjects.Repository;
using BL.DataManager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>(opts => opts.UseSqlServer(builder.Configuration["ConnectionOrder_WorkFlow"]));
builder.Services.AddScoped<IDataRepository<User>, UserManager>();
builder.Services.AddScoped<IDataRepository<Order>, OrderManager>();
builder.Services.AddScoped<IDataRepository<Product>, ProductManager>();
builder.Services.AddScoped<IDataRepository<Payment>, PaymentManager>();
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
