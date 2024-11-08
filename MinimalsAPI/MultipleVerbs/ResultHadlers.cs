namespace MultipleVerbs
{
    public class ResultHandlers
    {
        public IResult ReplaceFruit(string id, Fruit fruit)
        {
            Fruit.All[id] = fruit;
            return Results.NoContent();
        }

        public static IResult AddFruit(string id, Fruit fruit)
        {
            return Fruit.All.TryAdd(id, fruit)
                ? TypedResults.Created($"/fruit/{id}", fruit)
                : Results.BadRequest(new { id = "A fruit with this id already exists"});
        }

        public IResult DeleteFruit(string id)
        {
            Fruit.All.Remove(id);
            return Results.NoContent();
        }
    }
}