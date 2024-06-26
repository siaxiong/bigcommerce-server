using BigCommerce_Server.Services;
using System.Collections;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient<BigCommerceB2B_Service>();
builder.Services.AddHttpClient<BigCommerceNonB2B_Service>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var hashtable = Environment.GetEnvironmentVariables();
foreach (DictionaryEntry entry in hashtable)
{
    Console.WriteLine(entry.Key + ":" + entry.Value);
}
Console.WriteLine("Hello");

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
