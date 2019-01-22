using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    public class BlackBear : Animal
    {
        public bool IsAtTheZoo { get; set; }
        public override string Omnivore { get; set; }
        public override string Hibernates { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IsWild()
        {
            Console.WriteLine("are wild");
        }

        public override bool Poops()
        {
            return base.Poops();
        }

        public override string EatsMeat()
        {
            return base.EatsMeat();
        }
    }
}