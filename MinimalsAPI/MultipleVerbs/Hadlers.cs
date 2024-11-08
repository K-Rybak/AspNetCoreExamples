using System;

namespace MultipleVerbs
{
    public class Handlers
    {
        public void ReplaceFruit(string id, Fruit fruit)
        {
            Fruit.All[id] = fruit;
        }

        public static void AddFruit(string id, Fruit fruit)
        {
            Fruit.All.Add(id, fruit);
        }

        public void DeleteFruit(string id)
        {
            Fruit.All.Remove(id);
        }
    }
}