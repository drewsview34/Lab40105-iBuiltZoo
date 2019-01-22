using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    public abstract class Animal
    {
        public virtual string Carnivore { get; set; }
        public abstract string Omnivore { get; set; }
        public abstract string Hibernates { get; set; }
        public virtual string CanStand { get; set; }


        public virtual string EatsMeat()
        {
            return "eat meat";
        }

        public virtual bool GoesFishing()
        {
            Console.WriteLine("I can hunt");
            return true;
        }

        public virtual bool Poops()
        {
            return true;

        }
    }
}