using NpgSqlExample.DbHandler;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var dbHandler = new DbHandler();

app.MapGet("/cars", () => dbHandler.GetCars());

app.Run();
