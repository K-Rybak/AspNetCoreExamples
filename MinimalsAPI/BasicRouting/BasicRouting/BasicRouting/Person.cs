using System;

public record Person(string FirstName, string LastName)
{
    public static readonly List<Person> People = new()
    {
        new("Tom", "Hanks"),
        new("Denzel", "Washington"),
        new("Leondardo", "DiCaprio"),
        new("Al", "Pacino"),
        new("Morgan", "Freeman"),
    };
};
