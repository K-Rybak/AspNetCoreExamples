var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello world");

app.MapGet("/person/{name}", (string name) =>
    Person.People.Where(x => x.FirstName.StartsWith(name)));

app.Run();