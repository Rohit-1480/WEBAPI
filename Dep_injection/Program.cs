using Dep_injection.Models;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connection = builder.Configuration.GetConnectionString("InventoryDatabase");
builder.Services.AddDbContextPool<InventoryContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });
var app = builder.Build();
//app.MapGet("/", () => "Hello World!");
//app.MapGet("/Rohit", () => "Hello Rohit!");

//app.UseSwaggerUI(c =>
//{
//    c.SwaggerEndpoint("/myApi/swagger/v1/swagger.json", "V1 Docs");

//});
//app.MapControllerRoute(name: "WeatherForecast",
//               pattern: "{controller=WeatherForecast}/{action=Get}/{id?}");
//app.MapControllerRoute(name: "GETCATEGORY",
//               pattern: "{controller=WeatherForecast}/{action=GetCat}/{id?}");
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
