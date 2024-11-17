using MultipleVerbs;
using System.Net.Mime;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
//Returns all elements witg lambda
app.MapGet("/fruit", () => Fruit.All);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var getFruit = (string id) => Fruit.All[id];
app.MapGet("/fruit/{id:int:min(1)}", getFruit);

app.MapPost("/fruit/{id}", Handlers.AddFruit)
    .WithParameterValidation(); // static method

var handler = new Handlers();
app.MapPut("/fruit/{id}", handler.ReplaceFruit);

app.MapDelete("/fruit/{id}", handler.DeleteFruit);

app.MapGet("/teapot", (HttpResponse response) =>
{
    response.StatusCode = 418;
    response.ContentType = MediaTypeNames.Text.Plain;
    return response.WriteAsync("I'm a teapot!");
});

app.Run();
