using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Shop.AppData.Interfaces;
using Shop.AppData.Mocks;

var builder = WebApplication.CreateBuilder();
builder.Services.AddTransient<IAllCars, MockCars>();
builder.Services.AddTransient<ICarsCategory, MockCategory>();
builder.Services.AddControllers();
builder.Services.AddHealthChecks();
builder.Services.AddMvc();
var app = builder.Build();
app.MapHealthChecks("/healthz");

//app.MapGet("/", () => "Hello World!");
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cars}/{action=List}/{id?}");

app.Run();