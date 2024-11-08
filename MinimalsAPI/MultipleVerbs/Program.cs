using MultipleVerbs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Returns all elements witg lambda
app.MapGet("/fruit", () => Fruit.All);


var getFruit = (string id) => Fruit.All[id];
app.MapGet("/fruit/{id}", getFruit);

app.MapPost("/fruit/{id}", Handlers.AddFruit); // static method

var handler = new Handlers();
app.MapPut("/fruit/{id}", handler.ReplaceFruit);

app.MapDelete("/fruit/{id}", handler.DeleteFruit);

app.Run();
