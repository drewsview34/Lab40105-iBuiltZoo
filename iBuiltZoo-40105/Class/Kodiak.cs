using iBuiltZoo_40105.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    public class Kodiak : Bears, IAtTheZoo
    {
        public string HasTeeth { get; set; }
        public override string Omnivore { get; set; }
        public override string Hibernates { get; set; }

        public bool HasNoFur()
        {
            return true;
        }

        public bool CanFly()
        {
            throw new NotImplementedException();
        }

        public override bool FromTheJungle()
        {
            return base.FromTheJungle();
        
        }

        public bool AtTheZoo()
        {
            return true;
        }

        public bool AtTheZoo(IAtTheZoo atTheZoo)
        {
            throw new NotImplementedException();
        }
    }

}