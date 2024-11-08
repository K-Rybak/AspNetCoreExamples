namespace MultipleVerbs
{
    public record Fruit(string Name, int Stock)
    {
        public static readonly Dictionary<string, Fruit> All = [];
    };
}