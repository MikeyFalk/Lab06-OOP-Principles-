using System;

namespace FakeZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dragon scaly = new Dragon();
            Unicorn sparkles = new Unicorn();
            Console.WriteLine(sparkles.Diet);
            Console.WriteLine($"The dragon eats {scaly.Diet}");

            HoneyBadger toughGuy = new HoneyBadger();
            Console.WriteLine(toughGuy.Eat());

            Wombat william = new Wombat();
            Console.WriteLine($"The Wombat has {william.Eyes} eyes");
        }
    }
    
}
