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
            Console.WriteLine($"Black Bears are at the zoo{blackBear.IsAtTheZoo}");
            Console.WriteLine($"Black Bears eat plants and meat {blackBear.Omnivore}");

            Tigers tigers = new Tigers();
            Console.WriteLine("============TIGERS============");
            Console.WriteLine($"Tigers can be considered {tigers.Cats}");
            Console.WriteLine($"Tigers are not {tigers.KingOfTheJungle()}");
            Console.WriteLine($"Tigers are not domestic {tigers.Domestic}");

            Kodiak kodiak = new Kodiak();
            Console.WriteLine("============KODIAK============");
            Console.WriteLine(kodiak.EatsMeat());
            Console.WriteLine($"Kodiaks Can {kodiak.Sit()}");
            Console.WriteLine($"Kodiaks Don't Have A { kodiak.HasTail} ");

            Grizzley grizzley = new Grizzley();
            Console.WriteLine("============GRIZZLEY============");
            Console.WriteLine(grizzley.EatsMeat());
            Console.WriteLine($"Grizzlies Do {grizzley.Hibernates}");
            Console.WriteLine($"Grizzlies Do { grizzley.HasTail }");




        }
    }
}