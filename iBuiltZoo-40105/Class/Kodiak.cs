using iBuiltZoo_40105.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace iBuiltZoo_40105.Class
{
    public class Kodiak : Bears, IGoesFishing
    {
        public string HasTeeth { get; set; }
        public override string Omnivore { get; set; }
        public override string Hibernates { get; set; }

        public override bool CanRoar()
        {
            return true;
        }

        public bool CanFly()
        {
            return false;
        }

        public override bool FromTheJungle()
        {
            return false;
        
        }

        public override bool Poops()
        {
            return true;
        }
        public override bool GoesFishing()
        {
            return base.GoesFishing();
        }
    }
}