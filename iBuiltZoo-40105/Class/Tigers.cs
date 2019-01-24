using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    public class Tigers : Felines
    {
        public virtual bool HasStrips { get; set; }
        public override bool Domestic { get; set; }
        
        public void TonyTheTiger()
        {
            Console.WriteLine("They'rrree Great!!");
        }

        public override bool KingOfTheJungle()
        {
            return true;
        }


    }
}
