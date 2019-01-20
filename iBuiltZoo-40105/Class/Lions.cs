using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    class Lions : Felines
    {
        public bool HasStrips { get; set; }
        public override bool Domestic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void EatHumans()
        {
            Console.WriteLine("I Can Eat Humans");
        }

        public bool EatPlants()
        {
            Console.WriteLine("I Don't Like Plants");
            return true;
        }
    }
}