using iBuiltZoo_40105.Class;
using System;
using iBuiltZoo_40105.Interfaces;

namespace iBuiltZoo_40105
{
    class Program
    {
        static void Main(string[] args)
        {
            Blackbear blackBear = new Blackbear();
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
            Console.WriteLine($"Kodiaks {kodiak.Carnivore}");
            Console.WriteLine($"Kodiaks Don't Have a Tail { kodiak.CanStand}");

            Grizzley grizzley = new Grizzley();
            Console.WriteLine("============GRIZZLEY============");
            Console.WriteLine(grizzley.EatsMeat());
            Console.WriteLine($"Grizzlies Do hibernate {grizzley.Hibernates}");
            Console.WriteLine($"Grizzlies Do { grizzley.HasTail }");

            
            Lions lions = new Lions();
            Console.WriteLine("============LIONS============");
            Console.WriteLine($"Lions eat meals {lions.Meals}");
            Console.WriteLine($"Lions are domestic {lions.Domestic}");
            Console.WriteLine($"Lions have stripes {lions.HasStrips}");


        }
    }
}