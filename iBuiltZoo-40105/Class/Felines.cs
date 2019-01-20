using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    public abstract class Felines
    {
        public string Cats { get; set; }
        abstract public bool Domestic { get; set; }
        public string Meals { get; set; }

        public void FelinesPurr()
        {
            Console.WriteLine("We All Purrrr");
        }

        public virtual bool KingOfTheJungle()
        {
            return true;
        }

    }
}