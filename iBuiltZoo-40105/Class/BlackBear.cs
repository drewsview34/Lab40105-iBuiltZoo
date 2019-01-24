using System;
using System.Collections.Generic;
using System.Text;
using iBuiltZoo_40105.Interfaces;

namespace iBuiltZoo_40105.Class
{
    public class Blackbear : Animal, IAtTheZoo
    {
        public bool IsAtTheZoo { get; set; }
        public override string Omnivore { get; set; }
        public override string Hibernates { get; set; }

        public void IsWild()
        {
            Console.WriteLine("are wild");
        }

        public override bool Poops()
        {
            return true;
        }

        public override bool CanRoar()
        {
            return true;
        }

        public override string EatsMeat()
        {
            return "I eat a lot of meat";
        }

        public bool AtTheZoo()
        {
            return true ;
        }

        
    }
}
