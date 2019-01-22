using iBuiltZoo_40105.Class;
using System;

namespace iBuiltZoo_40105
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackBear blackBear = new BlackBear();
            Console.WriteLine("============BLACK BEAR============");
            Console.WriteLine(blackBear.EatsMeat());
            Console.WriteLine($"Black Bears are at the zoo {blackBear.IsAtTheZoo}");
            Console.WriteLine($"Black Bears eat plants and meat {blackBear.Omnivore}");

            Tigers tigers = new Tigers();
            Console.WriteLine("============TIGERS============");
            Console.WriteLine($"Tigers don't have tails {tigers.HasStrips}");
            Console.WriteLine($"Tigers are not considered King of the Jungle {tigers.KingOfTheJungle()}");
            Console.WriteLine($"Tigers are domestic {tigers.Domestic}");

            Kodiak kodiak = new Kodiak();
            Console.WriteLine("============KODIAK============");
            Console.WriteLine(kodiak.EatsMeat());
            Console.WriteLine($"Kodiaks {kodiak.Sit()}");
            Console.WriteLine($"Kodiaks Don't Have a Tail { kodiak.HasTail} ");

            Grizzley grizzley = new Grizzley();
            Console.WriteLine("============GRIZZLEY============");
            Console.WriteLine(grizzley.EatsMeat());
            Console.WriteLine($"Grizzlies Do hibernate {grizzley.Hibernates}");
            Console.WriteLine($"Grizzlies Do { grizzley.HasTail }");




        }
    }
}