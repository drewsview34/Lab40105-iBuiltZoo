using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    public class Grizzley : Bears
    {
        public bool IsScary { get; set; }
        public override string Omnivore { get; set; }
        public override string Hibernates { get; set; }

        public bool IsAMascott()
        {
            return true;
        }

        public override bool FromTheJungle()
        {
            return base.FromTheJungle();
        }

        public override bool Poops()
        {
            return base.Poops();
        }
    }
}